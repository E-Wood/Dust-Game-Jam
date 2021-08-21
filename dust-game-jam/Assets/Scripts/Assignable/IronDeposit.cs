using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : iAssignable
{
    //Called by pawns when in range of targeted assignable.
    public virtual void doWork()
    {
        ResourceManager.rManagerInstance.spawnDrop(ResourceManager.ResourceType.Iron, this.getPosition());
    }
}
