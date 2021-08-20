using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    private int hunger;
    private int thirst;
    private int sleep;
    private double workFactor;      // intensity of work - to calculate drain of sleep stat
    private Task currentTask;
    
    public Pawn()
    {
        hunger = 100;
        thirst = 100;
        sleep = 100;
        workFactor = 1.0;
    }

    public void UpdateNeeds(int value)
    {
        hunger -= value;
        thirst -= value;
        sleep -= (int) (value * workFactor);
    }
    enum Task
    {
        // things a Pawn can be doing
        Sleep,
        Eat,
        Drink,
        Tend,
        Farm,
        Dig,
        Build,
        Fight
    }
    
}
