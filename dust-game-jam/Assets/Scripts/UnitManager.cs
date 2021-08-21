using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    public Unit _unit;

    public Transform builders;
    void Start()
    {
        GameObject unit = Instantiate(_unit.pawnPrefab, transform.position, Quaternion.identity, builders);
    }
}
