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

    private void Start()
    {
        remainingTime = timeDelay;
        CreatingAsteroids();
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
        int distance = 0;
        for (int i = 0; i <= 10; i++)
        {
            distance += 4;
            asteroidClone = Instantiate(asteroid, new Vector3(-20+distance, 12, 0), Quaternion.identity);
            asteroidClone.SetActive(true);
            asteroidsQueue.Add(asteroidClone);
        }
        
    }
}
