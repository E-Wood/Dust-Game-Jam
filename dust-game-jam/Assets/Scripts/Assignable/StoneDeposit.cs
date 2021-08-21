using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneDeposit : iAssignable
{
    //Called by pawns when in range of targeted assignable.
    public virtual void doWork()
    {
        ResourceManager.rManagerInstance.spawnDrop(ResourceManager.ResourceType.Stone, this.getPosition());
    }
}
