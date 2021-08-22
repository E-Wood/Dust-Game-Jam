using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : iAssignable
{
    public override void doWork()
    {
        EnemyController.eControllerInstance.reduceHealth();
    }
}
