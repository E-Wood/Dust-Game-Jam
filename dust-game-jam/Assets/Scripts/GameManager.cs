using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private Inventory inventory;

    public GameState State;

    public GameObject colonist;
    
    // resources to keep track of state - your code is perfect the way it is <3
    public int bone = 0;
    public int stone = 0;
    public int iron = 0;
    public int thaumite = 0;
    public int food = 100;
    public int water = 100;

    private void Awake()
    {
        Instance = this;
        inventory = new Inventory();
    }

    public static event Action<GameState> OnGameStateChanged; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float timetime = Time.time;
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;
        
        // we can use a switch here to update certain aspects of the game state
        // these are defined in the enumerator
        // we can leave this empty for now
        // is there a change? if so, invoke function
        OnGameStateChanged?.Invoke(newState);
        
    }
    
    // called to spawn enemy at position
    public void spawnEnemy(Vector3 spawnLocation)
    {
        //GameObject enemy = Instantiate(enemy, spawnLocation, Quaternion.identity);
    }

    public enum GameState
    {
        // things we need to look out for, so TBD
        // resources
        /*
         * Bone
         * Stone
         * Iron
         * Thaumite
         * Food
         * Water
         * Day
         * Night
         */
    }
}
