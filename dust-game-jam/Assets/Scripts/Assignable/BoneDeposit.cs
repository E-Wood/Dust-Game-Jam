using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneDeposit : iAssignable
{
    //Called by pawns when in range of targeted assignable.
    public virtual void doWork()
    {
        ResourceManager.rManagerInstance.spawnDrop(ResourceManager.ResourceType.Bone, this.getPosition());
    }

    public BoneDeposit(GameObject sprite)
    {
        this.setPosition(new Vector3(-5.48f, -2.13f, 0));
        Instantiate(sprite, this.getPosition(), Quaternion.identity);
    }

    void Update()
    {
        doWork();
    }
}
