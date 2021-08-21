using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Colonist", menuName = "New Colonist")]
public class Unit : ScriptableObject
{ 
    public enum PawnType
    {
        Idle,
        Farmer,
        Builder,
        Digger,
        Fighter
    }

    public bool isPlayerUnit;

    public PawnType type;
    public new string pawnName;
    public GameObject pawnPrefab;

    public int health;
    public int hunger;
    public int thirst;
    public int sleep;
    public int attack;
    public double workRate;

}
