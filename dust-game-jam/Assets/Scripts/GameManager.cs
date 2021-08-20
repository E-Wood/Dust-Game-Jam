using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState State;
    
    // resources to keep track of state - probs could be private? probs could be done better? I'm lazy
    public int bone = 0;
    public int stone = 0;
    public int iron = 0;
    public int thaumite = 0;
    public int food = 100;
    public int water = 100;

    public List<Pawn> pawns = new List<Pawn>();

    private void Awake()
    {
        Instance = this;
    }

    public static event Action<GameState> OnGameStateChanged; 

    // Start is called before the first frame update
    void Start()
    {
        // populates the initial 
        for (int i = 0; i < 4; i++)
        {
            pawns.Add(new Pawn());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;
        
        // we can use a switch here to update certain aspects of the game state
        // these are defined in the enumerator
        //we can leave this empty for now
        switch (newState)
        {
        }
        
        // is there a change? if so, invoke function
        OnGameStateChanged?.Invoke(newState);
        
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
