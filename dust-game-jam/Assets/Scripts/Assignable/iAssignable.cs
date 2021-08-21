using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class iAssignable : MonoBehaviour
{
    private Vector3 position;

    //Returns current position.
    public void setPosition(Vector3 pos)
    {
        // sets position
        this.position = pos;
    }
    public Vector3 getPosition()
    {
        return position;
    }
    //Called by pawns when in range of targeted assignable.
    public virtual void doWork()
    {
        // TODO: Override this in extending classes
    }
}