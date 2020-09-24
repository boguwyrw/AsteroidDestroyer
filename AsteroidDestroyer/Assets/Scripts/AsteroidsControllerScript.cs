using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsControllerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject asteroid;
    [SerializeField]
    private int distance = 10;
    [SerializeField]
    private int numberOfRowsAndColumns = 4;

    private int increasingVerticalDistance = 0;
    private float startPoint;
    private GameObject asteroidClone;
    private List<GameObject> rowOfAsteroidsList = new List<GameObject>();
    private List<List<GameObject>> rowsList = new List<List<GameObject>>();

    private void Start()
    {
        startPoint = distance * numberOfRowsAndColumns - distance;
        CreatingListOfRows();
    }

    private void CreatingRowOfAsteroids()
    {
        int increasingHorizontalDistance = 0;
        for (int i = 0; i < numberOfRowsAndColumns; i++)
        {
            asteroidClone = Instantiate(asteroid, new Vector3(-startPoint/2 + increasingHorizontalDistance, -startPoint/2 + increasingVerticalDistance, 0.0f), Quaternion.identity);
            increasingHorizontalDistance = increasingHorizontalDistance + distance;
            rowOfAsteroidsList.Add(asteroidClone);
        }
    }

    private void CreatingListOfRows()
    {
        increasingVerticalDistance = 0;
        for (int i = 0; i < numberOfRowsAndColumns; i++)
        {
            CreatingRowOfAsteroids();
            rowsList.Add(rowOfAsteroidsList);
            rowOfAsteroidsList.Clear();
            increasingVerticalDistance = increasingVerticalDistance + distance;
        }  
    }
}
