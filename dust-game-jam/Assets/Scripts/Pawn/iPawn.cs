using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iPawn : MonoBehaviour
{
    public PawnController pawnController;
    protected iAssignable target;

    private void Update()
    {
        doWork();
    }

    public void setController(GameObject controller)
    {
        pawnController = controller.GetComponent<PawnController>();
    }
    
    public virtual void select()
    {
        //adds the pawn to the users selection.
        // TODO: Override this in other classes
    }
    
    public virtual void deselect()
    {
        //removes the pawn from the users selection.

    }

    public virtual void doWork()
    {
        //either does work on the assigned target, moves to the assigned target, or idles in place.
        // TODO: Override this in extending classes
    }

    public void setTarget(GameObject target)
    {
        //sets a target for work to the pawn.
        try
        {
            this.target = target.GetComponent<iAssignable>();
        } catch
        {
            this.target = null;
        }
    }
    
    public iAssignable getTarget()
    {
        //returns the current target or null.
        return target;
    }
}
