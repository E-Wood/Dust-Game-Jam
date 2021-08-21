using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface iPawn 
{
    //adds the pawn to the users selection.
    public void select();
    //removes the pawn from the users selection.
    public void deselect();
    //sets a target for work to the pawn.
    public void setTarget(GameObject target);
    //returns the current target or null.
    public GameObject getTarget();
    //either does work on the assigned target, moves to the assigned target, or idles in place.
    public void doWork();
}
