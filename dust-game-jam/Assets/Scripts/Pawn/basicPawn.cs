using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class basicPawn : iPawn
{
    public float distanceToWork;
    public float speed;

    private float startOfWork = 0;      //startOfWork == 0 means no work action has been started - is idling or moving
    private float workLength;
    private float workSpeed;
    
    public Needs hunger;
    public Needs sleep;
    public Needs water;

    public CurrentTool currentTool;
    
    private Tool heldTool = new Tool(Tool.Type.Hands, Tool.Material.Thaumite);

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        calculateWorkSpeed();
        hunger.setDepletionRate(0.1f);
        sleep.setDepletionRate(0.2f);
        water.setDepletionRate(0.3f);
    }
    
    //---------------------------TOOL SHIT, COULD BE MOVED TO SUBCLASS???----------------------------
    public void calculateWorkSpeed()
    {
        //this function allows the workspeed of the pawn to be based off the tool's material. +0.5 for each tool, starting from 1 for Hands
        workSpeed = ((int)heldTool.material / 2) + 0.5f;
        workLength = 20 / workSpeed;    //20 seconds == base length for each work action, workSpeed modifier based on material of heldTool
    }

    public void updateHeldTool(Tool tool)
    {
        this.heldTool = tool;
        calculateWorkSpeed();
    }
    //------------------------------------------------------------------------------------------------

    override public void select()
    {
        //adds the pawn to the users selection.
        pawnController.addToSelection(gameObject);
        GetComponent<SpriteRenderer>().color = Color.green;
    }

    override public void deselect()
    {
        //removes the pawn from the users selection.
        pawnController.removeFromSelection(gameObject);
        GetComponent<SpriteRenderer>().color = Color.gray;
    }

    override public void doWork()
    {
        animator.SetBool("isMoving", false);

        if (this.target != null) {
            
            if (Vector3EX.horizontalDistance(gameObject, this.target.gameObject) <= distanceToWork)
            {

                if (this.target.GetType().IsSubclassOf(typeof(Pickup)))                   //if a pickup - pick it up instantly          
                {
                    this.target.doWork();
                } else if ((this.heldTool.material >= this.target.getIdealTool().material   //minimum tool material met
                           && this.heldTool.type == this.target.getIdealTool().type))       //correct tool type met
                {
                    //hooray! we can do this task!
                    
                    //I apologise for this implementation. It's 1:30am. 
                    if (startOfWork == 0)
                    {
                        startOfWork = Time.time;
                        target.startAnimation();
                        animator.SetBool(target.getAction(), true); //start the animation
                    } if (Time.time - startOfWork > workLength)
                    {
                        this.target.doWork();
                        startOfWork = 0;    //resets work cycle
                    }
                }
                else
                {
                    //TODO: some form of "oh no you can't do this with this tool!"
                }
            } else
            {
                animator.SetBool("isMoving", true);
                moveToTarget();
                startOfWork = 0;
            }
        }
    }

    private void moveToTarget()
    {

        if (this.target != null)
        {
            Vector3 movementVector = new Vector3(0, 0, 0);
            if (transform.position.x < this.target.transform.position.x) {
                movementVector.x = 1 * 0.02f;
            } else if (transform.position.x > this.target.transform.position.x)
            {
                movementVector.x = -1 * 0.02f;
            }

            transform.position += movementVector;
        }
    }
}
