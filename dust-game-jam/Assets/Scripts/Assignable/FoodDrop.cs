using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDrop : iAssignable
{
    private GameObject thisGO;
    //Called by pawns when in range of targeted assignable.
    public override void doWork()
    {
        Destroy(thisGO);
        ResourceManager.rManagerInstance.resources.Remove(this);
    }

    public void setGameObject(GameObject go)
    {
        this.thisGO = go;
    }
}
