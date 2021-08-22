using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrine : iAssignable
{
    public override void doWork()
    {
        ShrineController.SControllerInstance.UpdateShrine();
    }
}
