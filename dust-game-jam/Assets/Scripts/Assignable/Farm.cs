using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : iAssignable
{
    public int worksTilHarvest = 5;
    public override void doWork()
    {
        worksTilHarvest--;
        if (worksTilHarvest <= 0)
        {
            //GameManager.Instance.incrementFood();
            worksTilHarvest = 5;
        }
        
    }
}
