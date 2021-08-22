using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iEnemy : MonoBehaviour
{
    protected Vector3 closestPawn;
    public EnemyController EnemyController;
    private BoxCollider2D boxCollider;

    public void setController(GameObject controller)
    {
        EnemyController = controller.GetComponent<EnemyController>();
    }

    public void findClosestPawn()
    {
        // this is very shit and will cause bugs
        GameObject pawnObject = GameObject.FindWithTag("Pawn");
        closestPawn = pawnObject.transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent <BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        findClosestPawn();      // this is going to be a berry big broblem lol
    }
}
