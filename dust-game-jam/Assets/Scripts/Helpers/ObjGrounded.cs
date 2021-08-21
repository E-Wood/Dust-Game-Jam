using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//All Game Objects with the Grounded Script can only exist clamped onto the surface of a ObjGround object.
//If ground is not found on creation, the object should go into a inactive state until a ground object is found.
//Once a Ground object is found, the Grounded object will be possessive, if Ground cannot be found, it will use the
//last known Ground object.
//All collisions with ground should be checked within the "Ground" layer to isolate the ground objects.

public class ObjGrounded : MonoBehaviour
{


    float baseHeight;
    float leftBound;
    float rightBound;
    
    float groundLeft;
    float groundRight;
    float groundTop;
    
    GameObject groundObj;
    ObjGround groundScr;

    bool setup = false;

    private List<GameObject> groundList;

    //TODO: add exception call when a grounded object does not have a boxcollider2D.
    public void SetBounds()
    {
        BoxCollider2D tempCollider = gameObject.GetComponent<BoxCollider2D>();
        Vector3 tempExtents = tempCollider.bounds.extents;
        Vector2 tempCenter = tempCollider.offset;
        baseHeight = - (tempExtents.y - tempCenter.y/2);
        rightBound = (tempExtents.x - tempCenter.y / 2);
        leftBound = -(tempExtents.x - tempCenter.y / 2);
    }
    
    //Casts a raycast down, if that fails, a raycast up is used.
    void FindGround() {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, Mathf.Infinity, LayerMask.GetMask("Ground"));
        if(hit.collider == null || hit.transform.gameObject.GetComponent<ObjGround>() == null)
        {

            hit = Physics2D.Raycast(transform.position, -Vector2.down, Mathf.Infinity, LayerMask.GetMask("Ground"));
        }

        if (hit.collider != null && hit.transform.gameObject.GetComponent<ObjGround>() != null) {
            groundObj = hit.transform.gameObject;
            groundList[0] = groundObj;
            GetGroundBounds();
        }
    }

    //Finds the bounds of the current ground.
    void GetGroundBounds()
    {
        groundScr = groundObj.GetComponent<ObjGround>();

        //Call setup so the ground bounds are set, to be retrieved with the get functions.
        groundScr.Setup();

        groundLeft = groundObj.transform.position.x + groundScr.GetLeft();
        groundRight = groundObj.transform.position.x + groundScr.GetRight();
        groundTop = groundObj.transform.position.y + groundScr.GetHeight();
    }
    
    //Clamps the objects position onto the current ground.
    public Vector3 ClampPosition(Vector3 pos) {
        pos.x = Mathf.Clamp(pos.x, groundLeft - leftBound, groundRight - rightBound);
        pos.y = groundTop - baseHeight;
        return pos;
    }

    public List<GameObject> getGround()
    {
        return groundList;
    }
    
    public void setGround(GameObject ground)
    {
        groundObj = ground;
        groundList[0] = groundObj;
        GetGroundBounds();
        transform.position = ClampPosition(transform.position);
    }

    public float GetGroundedHeight()
    {
        return groundTop - baseHeight;
    }

    public bool CheckSameGround(GameObject otherGround)
    {
        return (otherGround.GetInstanceID() == groundObj.GetInstanceID());
    }

    new public void Setup()
    {
        if(!setup)
        {

            groundList = new List<GameObject>();
            groundList.Add(groundObj);
            SetBounds();
            FindGround();

            setup = true;
        }
    }

    new public void Start()
    {
        Setup();
    }

    // Update is called once per frame
    protected void Update()
    {
        SetBounds();
        FindGround();
        transform.position = ClampPosition(transform.position);
    }
}
