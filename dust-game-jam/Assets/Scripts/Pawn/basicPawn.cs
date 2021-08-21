using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicPawn : iPawn
{
    public float distanceToWork;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
                this.target.doWork();
            } else
            {
                moveToTarget();
            }
        }
    }

    private void moveToTarget()
    {
        if (this.target != null)
        {
            Vector3 movementVector = new Vector3(0, 0, 0);
            float movementDirection = transform.position.x - this.target.transform.position.x;
            if (movementDirection > 0) {
                movementVector.x = 1 * speed * Time.deltaTime;
            } else
            {
                movementVector.x = -1 * speed * Time.deltaTime;
            }

            transform.position += movementVector;
        }
    }
}
