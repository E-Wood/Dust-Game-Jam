using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface iAssignable
{
    //Returns current position.
    public Vector3 getPosition();
    //Called by pawns when in range of targeted assignable.
    public void doWork();

}
