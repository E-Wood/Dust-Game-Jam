using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Colonist", menuName = "New Colonist")]
public class Pawn : iPawn
{
    private PawnNeedsBar pawnNeedsBar;

    private targetMove moveTo;

    public bool isPlayerUnit;
    
    public new string pawnName;
    public GameObject pawnPrefab;

    public int health;
    public int hunger;
    public int thirst;
    public int sleep;
    public int attack;
    public float workSpeed;     //rate at which work is being done by the pawn - higher number = faster = less strain on sleep stat

    public Tool tool;

    public void calculateWorkSpeed()
    {
        //this function allows the workspeed of the pawn to be based off the tool's material. +0.5 for each tool, starting from 1 for Bone
        workSpeed = ((int)tool.material / 2) + 0.5f;
    }

    //------------------------MOUSE STUFF---------------------
    
    private Vector3 targetPosition;
    public float speed = 1.5f;
    public void OnMouseClick()
    {
        //moveTo.enabled = true; 
        while (true)
        {
            Debug.Log("here");
            if (Input.GetMouseButtonDown(0))
            {
                targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //targetPosition.z = transform.position.z; BUG
                break;
            }

            
        }
       // transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime); BUG

    }

    private void Update()
    {
        
    }


    private void OnMouseUp()
    {

        while (true)
        {
            Debug.Log("here");
            if (Input.GetMouseButtonDown(0))
            {
                targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
               // targetPosition.z = transform.position.z; BUG
                break;

            }

           // transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime); BUG
        }
    }


    public void OnMouseOver(){
       //pawnNeedsBar.enabled = true;
    }
    
    public void OnMouseExit(){
       // pawnNeedsBar.enabled = false;
    }

}
