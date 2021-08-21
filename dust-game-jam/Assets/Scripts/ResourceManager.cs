using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public GameObject[] deposits;   // interactible resource deposits (drop resources)
    public GameObject[] resources;  // collectible resources

    public void spawnDeposit(ResourceType type)
    {
        switch (type)
        {
            case ResourceType.Bone:
                // instantiate bone deposit
                break;
            case ResourceType.Stone:
                // instantiate stone deposit
                break;
            case ResourceType.Iron:
                // instantiate iron deposit
                break;
        }
    }

    public void spawnDrop(ResourceType type)
    {
        switch (type)
        {
            case ResourceType.Bone:
                // instantiate bone drop
                break;
            case ResourceType.Stone:
                // instantiate stone drop
                break;
            case ResourceType.Iron:
                // instantiate iron drop
                break;
            case ResourceType.Thaumite:
                // instantiate thaumite drop
                break;
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
