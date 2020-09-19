using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionOfSpaceshipScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool asteroidCollision = collision.gameObject.layer == 10;
        if (asteroidCollision)
        {
            Destroy(gameObject);
        }
    }
}
