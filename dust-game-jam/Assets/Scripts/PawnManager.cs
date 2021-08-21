using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnManager : MonoBehaviour
{
    public Pawn _pawn;
    public Transform builders;
    void Start()
    {
        GameObject pawn = Instantiate(_pawn.pawnPrefab, transform.position, Quaternion.identity, builders);
    }
    
}
