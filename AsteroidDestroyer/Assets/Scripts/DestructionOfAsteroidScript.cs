using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionOfAsteroidScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool laserCollision = collision.gameObject.layer == 9;
        bool asteroidCollision = collision.gameObject.layer == 10;
        if (laserCollision || asteroidCollision)
        {
            gameObject.SetActive(false);
        }
    }
}
