using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionOfSpaceshipScript : MonoBehaviour
{
    [SerializeField]
    private GameObject endGameController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool asteroidCollision = collision.gameObject.layer == 10;
        if (asteroidCollision)
        {
            endGameController.SetActive(true);
            Time.timeScale = 0.0f;
            Destroy(gameObject);
        }
    }
}
