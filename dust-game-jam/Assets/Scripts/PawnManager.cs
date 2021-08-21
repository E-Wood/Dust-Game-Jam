using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnManager : MonoBehaviour
{
    public Pawn _pawn;
    public Transform builders;
    
    public Needs hunger;
    public Needs sleep;
    public Needs water;
    void Start()
    {
        //GameObject pawn = Instantiate(_pawn.pawnPrefab, transform.position, Quaternion.identity, builders);
        hunger.setDepletionRate(0.01f);
        sleep.setDepletionRate(0.05f);
        water.setDepletionRate(0.1f);
    }

    private void OnMouseOver()
    {
        
    }
}
