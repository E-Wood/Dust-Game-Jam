using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    private int hunger;
    private int thirst;
    private int sleep;
    private double workFactor;      // intensity of work - to calculate drain of sleep stat
    // I've a couple questions about workFactor
    
    /* So we have the global:
     * private double workSpeed
     *
     * This is multiplied by workFactor, which is a value between 0 and 2
     * workFactor is calculated by the current hunger, thirst and tiredness
     * alongside any buffs given by the tools equipped
     */
    
    private Task currentTask;       // I'm thinking we can handle this in a TaskManager

    public Pawn(int hunger, int thirst, int sleep)
    {
        this.hunger = hunger;
        this.thirst = thirst;
        this.sleep = sleep;
    }

    public void UpdateNeeds(int value)
    {
        hunger -= value;
        thirst -= value;
        sleep -= (int) (value * workFactor);
    }
    
    // we will delegate this elsewhere
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
