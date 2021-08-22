using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static List<iAssignable> deposits = new List<iAssignable>();   // interactible resource deposits (drop resources)
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
        
        // to anyone who sees this, including myself, I'm sorry
        foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Assignment"))
        {
            if (gameObject.GetComponent<BoneDeposit>() == null) continue;
            
            BoneDeposit bd = gameObject.GetComponent<BoneDeposit>();
            bd.setPosition(gameObject.transform.position);
            deposits.Add(bd);
            //TODO: do this again for iron deposits when they're around
        }
        
        // TODO: Test drops - pls delete later
        spawnDrop(ResourceType.Bone, new Vector3(0, 0, 0));
        spawnDrop(ResourceType.Stone, new Vector3(1, 0, 0));
        spawnDrop(ResourceType.Iron, new Vector3(2, 0, 0));
        spawnDrop(ResourceType.Thaumite, new Vector3(3, 0, 0));
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
                Bone boneCom = thisBone.GetComponent<Bone>();
                boneCom.setGameObject(thisBone);
                resources.Add(boneCom);
                break;
            case ResourceType.Stone:
                GameObject thisStone = Instantiate(stone, spawnLocation, Quaternion.identity);
                Stone stoneCom = thisStone.GetComponent<Stone>();
                stoneCom.setGameObject(thisStone);
                resources.Add(stoneCom);
                break;
            case ResourceType.Iron:
                GameObject thisIron = Instantiate(iron, spawnLocation, Quaternion.identity);
                Iron ironCom = thisIron.GetComponent<Iron>();
                ironCom.setGameObject(thisIron);
                resources.Add(ironCom);
                break;
            case ResourceType.Thaumite:
                GameObject thisThau = Instantiate(thaumite, spawnLocation, Quaternion.identity);
                Thaumite thauCom = thisThau.GetComponent<Thaumite>();
                thauCom.setGameObject(thisThau);
                resources.Add(thauCom);
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
