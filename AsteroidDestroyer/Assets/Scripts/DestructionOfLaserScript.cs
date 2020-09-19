using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionOfLaserScript : MonoBehaviour
{
    public static int playerScore = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool asteroidCollision = collision.gameObject.layer == 10;
        if (asteroidCollision)
        {
            Destroy(gameObject);
            playerScore++;
        }
    }
}
