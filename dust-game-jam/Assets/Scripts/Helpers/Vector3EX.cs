using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vector3EX
{
    public static float horizontalDistance(GameObject a, GameObject b)
    {
        float distance = Mathf.Abs(a.transform.position.x - b.transform.position.x);
        return distance;
    }
}
