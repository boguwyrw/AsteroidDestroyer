using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsControllerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject asteroid;

    private GameObject asteroidClone;
    private float timeDelay = 1.0f;
    private float remainingTime;

    private void Start()
    {
        remainingTime = timeDelay;
        CreatingAsteroid();
    }

    private void Update()
    {
        if (!asteroidClone)
        {
            remainingTime = remainingTime - Time.deltaTime;
            if (remainingTime <= 0.0f)
            {
                CreatingAsteroid();
                remainingTime = timeDelay;
            }  
        }
    }

    private void CreatingAsteroid()
    {
        asteroidClone = Instantiate(asteroid, new Vector3(12, 12, 0), Quaternion.identity);
    }
}
