using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//All GameObject with this script or it's descendants should act as solid ground
//for Grounded objects.
//All Ground objects must have a boxCollider2D.
//All Ground objects should be placed into the "Ground" Layer for the purposes of collisions.

public class ObjGround : MonoBehaviour
{

    float height;
    float leftBound;
    float rightBound;

    bool setup = false;

    //TODO: should add exception call when a Ground object does not have a boxcollider2D.
    void SetBounds() {
        BoxCollider2D tempCollider = gameObject.GetComponent<BoxCollider2D>();
        Vector3 tempExtents = tempCollider.bounds.extents;
        height = tempExtents.y;
        rightBound = tempExtents.x;
        leftBound = -tempExtents.x;
    }
    
    public float GetHeight() {
        return height;
    }
    
    public float GetLeft() {
        return leftBound;
    }
    
    public float GetRight() {
        return rightBound;
    }

    new public void Setup()
    {
        if(!setup)
        {
            SetBounds();
            setup = true;
        }
    }

    new public void Start()
    {
        Setup();
    }
}
