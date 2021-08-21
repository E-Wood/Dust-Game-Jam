using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : iAssignable
{
    //Called by pawns when in range of targeted assignable.
    public override void doWork()
    {
        GameManager.Instance.stone++;
    }
}
