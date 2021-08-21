using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thaumite : iAssignable
{
    //Called by pawns when in range of targeted assignable.
    public override void doWork()
    {
        GameManager.Instance.thaumite++;
    }
}
