using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicEnemy : iEnemy
{
    public int health, attack;
    public float speed;

    public basicEnemy()
    {
        health = 100;
        attack = 5;
    }

    public void makeStrong()
    {
        health += 50;
        attack *= 3;
    }

    private void moveToTarget()
    {
        Vector3 movementVector = new Vector3(0, 0, 0);
            if (transform.position.x < this.closestPawn.x) {
                movementVector.x = 1 * speed;
            } else if (transform.position.x > this.closestPawn.x)
            {
                movementVector.x = -1 * speed;
            }

            transform.position += movementVector;
    }

}
