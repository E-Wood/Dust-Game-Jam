using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bone : ScriptableObject
{
    public GameManager gameManager;
    public ResourceManager resourceManager;
    private Vector3 position;
    public void setPosition(Vector3 pos)
    {
        this.position = pos;
    }
    public Vector3 getPosition()
    {
        return position;
    }
    public void doWork()
    {
        gameManager.bone++;
        resourceManager.resources.Remove(this);
        resourceManager.update();
    }
}
