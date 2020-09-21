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

    private List<GameObject> asteroidsQueue = new List<GameObject>();

    private int distance = 10;
    private int numberOfRowsAndColumns = 16;
    private int startPoint;

    private void Awake()
    {
        startPoint = distance * numberOfRowsAndColumns - distance;
        //CreatingAsteroids();
        CreatingRowOfAsteroids();
    }

    private void Start()
    {
        remainingTime = timeDelay;
    }

    private void Update()
    {
        /*
        for (int i = 0; i < asteroidsQueue.Count; i++)
        {
            if (asteroidsQueue[i].activeSelf == false)
            {
                remainingTime = remainingTime - Time.deltaTime;
                if (remainingTime <= 0.0f)
                {
                    asteroidsQueue[i].SetActive(true);
                    asteroidsQueue[i].transform.position = new Vector3(Mathf.Clamp(asteroidsQueue[i].transform.position.x, -20, 20), Mathf.Clamp(asteroidsQueue[i].transform.position.y, 8, 12), 0);
                }
            }
        }
        */
        /*
        if (!asteroidClone)
        {
            remainingTime = remainingTime - Time.deltaTime;
            if (remainingTime <= 0.0f)
            {
                //CreatingAsteroids();
                remainingTime = timeDelay;
            }  
        }
        */
    }

    private void CreatingAsteroids()
    {
        int gridSize = (int)Mathf.Pow(numberOfRowsAndColumns, 2);
        for (int i = 0; i <= gridSize; i++)
        {
            asteroidClone = Instantiate(asteroid, new Vector3(-startPoint / 2 + (distance * (i % numberOfRowsAndColumns)), -startPoint / 2 + (distance * (i / numberOfRowsAndColumns)), 0), Quaternion.identity);
            asteroidClone.SetActive(true);
            asteroidsQueue.Add(asteroidClone);
        }
        
    }

    private void CreatingRowOfAsteroids()
    {
        int increasingDistance = 0;
        for (int i = 0; i < numberOfRowsAndColumns; i++)
        {
            asteroidClone = Instantiate(asteroid, new Vector3(-startPoint/2 + increasingDistance, -startPoint/2, 0.0f), Quaternion.identity);
            increasingDistance = increasingDistance + distance;
        }
    }
}
