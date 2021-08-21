using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class iPawn : MonoBehaviour
{
    private GameObject target;
    
    public virtual void select()
    {
        //adds the pawn to the users selection.
        // TODO: Override this in other classes
    }
    
    public virtual void deselect()
    {
        //removes the pawn from the users selection.
        
    }
    
    public void setTarget(GameObject target)
    {
        //sets a target for work to the pawn.
        this.target = null;
    }
    
    public GameObject getTarget()
    {
        //returns the current target or null.
        return target;
    }

    public virtual void doWork()
    {
        //either does work on the assigned target, moves to the assigned target, or idles in place.
        // TODO: Override this in extending classes
    }
}
