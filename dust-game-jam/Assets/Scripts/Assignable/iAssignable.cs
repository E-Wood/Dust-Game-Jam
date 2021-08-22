using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class iAssignable : MonoBehaviour
{
    private Vector3 position;
    public Tool idealTool = new Tool(Tool.Type.Hands, Tool.Material.Hands);

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

    public void setIdealTool(Tool tool)
    {
        this.idealTool = tool;
    }

    public Tool getIdealTool()
    {
        return this.idealTool;
    }

    public virtual void startAnimation()
    {
    }

    public virtual void endAnimation()
    {
    }

    public virtual String getAction()
    {
        return "";
    }

//Called by pawns when in range of targeted assignable.
    public virtual void doWork()
    {
        // TODO: Override this in extending classes
    }
}