using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetMove : MonoBehaviour
{
    public float speed = 1.5f;
    private Vector3 targetPosition;
    private Resources target;
 
    void Start () {
        targetPosition = transform.position;
    }
     
    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = transform.position.z;
        }
        //transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }   
}
