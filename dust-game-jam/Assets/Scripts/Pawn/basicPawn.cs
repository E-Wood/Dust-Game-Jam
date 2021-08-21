using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicPawn : iPawn
{
    public float distanceToWork;
    public float speed;

    private float startOfWork = 0;      //startOfWork == 0 means no work action has been started - is idling or moving
    private float workLength = 20;   //should be calculated as 20 (seconds) * workSpeed (currently in Pawn.cs, need to merge Pawn classes)

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        if (this.target != null) {
            if (Vector3EX.horizontalDistance(gameObject, this.target.gameObject) <= distanceToWork)
            {
                //I apologise for this implementation. It's 1:30am. 
                if (startOfWork == 0)
                {
                    startOfWork = Time.time;
                } if (Time.time - startOfWork > workLength)
                {
                    this.target.doWork();
                    startOfWork = 0;    //resets work cycle
                }
            } else
            {
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
                movementVector.x = 1 * speed;
            } else if (transform.position.x > this.target.transform.position.x)
            {
                movementVector.x = -1 * speed;
            }

            transform.position += movementVector;
        }
    }
}
