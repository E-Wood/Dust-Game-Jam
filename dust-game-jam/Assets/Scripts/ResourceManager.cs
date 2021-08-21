using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public List<iAssignable> deposits = new List<iAssignable>();   // interactible resource deposits (drop resources)
    public List<iAssignable> resources = new List<iAssignable>();  // collectible resources

    // all the sprites to reference for drawing
    public GameObject bone;
    public GameObject stone;
    public GameObject iron;
    public GameObject thaumite;
    public GameObject bDeposit;
    public Transform depoSize;
    
    // TODO: Someone else look at this bc I feel like this is dumb - Elias
    public static ResourceManager rManagerInstance;

    void Start()
    {
        rManagerInstance = this;
        // TODO: Test Method - pls delete later
        spawnDrop(ResourceType.Bone, new Vector3(0, 0, 0));
        spawnDrop(ResourceType.Stone, new Vector3(1, 0, 0));
        spawnDrop(ResourceType.Iron, new Vector3(2, 0, 0));
        spawnDrop(ResourceType.Thaumite, new Vector3(3, 0, 0));
        
        spawnDeposit(ResourceType.Bone, new Vector3(-5, -2.4f, 0));
    }

    public void spawnDeposit(ResourceType type, Vector3 spawnLocation)
    {
        switch (type)
        {
            case ResourceType.Bone:
                GameObject thisDepo = Instantiate(bDeposit, spawnLocation, Quaternion.identity, depoSize);
                deposits.Add(thisDepo.GetComponent<BoneDeposit>());
                if (deposits.Count > 0)
                {
                    deposits.LastOrDefault().setPosition(spawnLocation);
                }
                break;
            case ResourceType.Iron:
                //resources.Add(new IronDeposit());
                break;
        }
    }

    public void spawnDrop(ResourceType type, Vector3 spawnLocation)
    {
        switch (type)
        {
            case ResourceType.Bone:
                GameObject thisBone = Instantiate(bone, spawnLocation, Quaternion.identity);
                resources.Add(thisBone.GetComponent<Bone>());
                break;
            case ResourceType.Stone:
                GameObject thisStone = Instantiate(stone, spawnLocation, Quaternion.identity);
                resources.Add(thisStone.GetComponent<Stone>());
                break;
            case ResourceType.Iron:
                GameObject thisIron = Instantiate(iron, spawnLocation, Quaternion.identity);
                resources.Add(thisIron.GetComponent<Iron>());
                break;
            case ResourceType.Thaumite:
                GameObject thisThaumite = Instantiate(thaumite, spawnLocation, Quaternion.identity);
                resources.Add(thisThaumite.GetComponent<Thaumite>());
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
