using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : iAssignable
{
    //Called by pawns when in range of targeted assignable.
    public virtual void doWork()
    {
        GameManager.Instance.bone++;
    }
}
