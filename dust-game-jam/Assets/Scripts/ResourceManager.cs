using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public List<ScriptableObject> deposits = new List<ScriptableObject>();   // interactible resource deposits (drop resources)
    public List<ScriptableObject> resources = new List<ScriptableObject>();  // collectible resources

    // all the sprites to reference for drawing
    public GameObject bone;
    public GameObject stone;
    public GameObject iron;
    public GameObject thaumite;

    void Start()
    {
        // TODO: Test Method - pls delete later
        spawnDrop(ResourceType.Bone, new Vector3(0, 0, 0));
        spawnDrop(ResourceType.Stone, new Vector3(1, 0, 0));
        spawnDrop(ResourceType.Iron, new Vector3(2, 0, 0));
        spawnDrop(ResourceType.Thaumite, new Vector3(3, 0, 0));
        
        update();
    }

    public void spawnDrop(ResourceType type, Vector3 spawnLocation)
    {
        switch (type)
        {
            case ResourceType.Bone:
                Bone newBone = ScriptableObject.CreateInstance<Bone>();
                newBone.setPosition(spawnLocation);    
                resources.Add(newBone);
                break;
            case ResourceType.Stone:
                Stone newStone = ScriptableObject.CreateInstance<Stone>();
                newStone.setPosition(spawnLocation);    
                resources.Add(newStone);
                break;
            case ResourceType.Iron:
                Iron newIron = ScriptableObject.CreateInstance<Iron>();
                newIron.setPosition(spawnLocation);    
                resources.Add(newIron);
                break;
            case ResourceType.Thaumite:
                Thaumite newThaumite = ScriptableObject.CreateInstance<Thaumite>();
                newThaumite.setPosition(spawnLocation);    
                resources.Add(newThaumite);
                break;
        }
    }

    public void update()
    {
        foreach (ScriptableObject resource in resources)
        {
            if (resource.GetType() == typeof(Bone))
            {
                Bone thisBone = (Bone) resource;
                Instantiate(bone, thisBone.getPosition(), Quaternion.identity);
            } else if (resource.GetType() == typeof(Stone))
            {
                Stone thisStone = (Stone) resource;
                Instantiate(stone, thisStone.getPosition(), Quaternion.identity);
            } else if (resource.GetType() == typeof(Iron))
            {
                Iron thisIron = (Iron) resource;
                Instantiate(iron, thisIron.getPosition(), Quaternion.identity);
            } else if (resource.GetType() == typeof(Thaumite))
            {
                Thaumite thisThaumite = (Thaumite) resource;
                Instantiate(thaumite, thisThaumite.getPosition(), Quaternion.identity);
            }
        }
    }
    
    public enum ResourceType
    {
        Bone,
        Stone,
        Iron,
        Thaumite
    }
}
