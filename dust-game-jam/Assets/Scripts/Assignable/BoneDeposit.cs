using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneDeposit : iAssignable
{
    //Called by pawns when in range of targeted assignable.
    public override void doWork()
    {
        ResourceManager.rManagerInstance.spawnDrop(ResourceManager.ResourceType.Bone, this.getPosition());
    }
    
    
}
