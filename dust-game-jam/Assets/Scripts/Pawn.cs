using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Colonist", menuName = "New Colonist")]
public class Pawn : ScriptableObject
{
    
    private double workFactor;      // intensity of work - to calculate drain of sleep stat
    // I've a couple questions about workFactor
    
    /* So we have the global:
     * private double workSpeed
     *
     * This is multiplied by workFactor, which is a value between 0 and 2
     * workFactor is calculated by the current hunger, thirst and tiredness
     * alongside any buffs given by the tools equipped
     */
    // BUG
  //  private Task currentTask;       // I'm thinking we can handle this in a TaskManager 

    private PawnNeedsBar pawnNeedsBar;

    private targetMove moveTo;

    /* BUG
    public Pawn(int hunger, int thirst, int sleep)
    {
        Idle,
        Farmer,
        Builder,
        Digger,
        Fighter
    }
    */
    
    public bool isPlayerUnit;

  //  public PawnType type; BUG
    public new string pawnName;
    public GameObject pawnPrefab;

    public int health;
    public int hunger;
    public int thirst;
    public int sleep;
    public int attack;
    public double workRate;
    
    


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
