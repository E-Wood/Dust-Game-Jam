using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iron : Pickup
{
    private GameObject thisGO;
    //Called by pawns when in range of targeted assignable.
    public override void doWork()
    {
        GameManager.Instance.iron++;
        Destroy(thisGO);
        ResourceManager.rManagerInstance.resources.Remove(this);
    }

    public void setGameObject(GameObject go)
    {
        this.thisGO = go;
    }
}
