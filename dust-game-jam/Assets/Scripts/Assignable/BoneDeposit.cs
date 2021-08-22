using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneDeposit : iAssignable
{
    public Animator assignableAnimator;
    //Called by pawns when in range of targeted assignable.
    public override void doWork()
    {
        ResourceManager.rManagerInstance.spawnDrop(ResourceManager.ResourceType.Bone, this.getPosition());
    }

    public override void startAnimation()
    {
        assignableAnimator.SetBool("isBeingUsed", true);
    }

    public override void endAnimation()
    {
        assignableAnimator.SetBool("isBeingUsed", false);
    }

    public override String getAction()
    {
        return "isDigging";
    }
    
}
