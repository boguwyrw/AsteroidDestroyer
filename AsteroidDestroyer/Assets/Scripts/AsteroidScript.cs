using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    private float asteroidSpeed;
    private float asteroidAngle;

    private void Start()
    {
        asteroidSpeed = Random.Range(0.5f, 7.5f);
        asteroidAngle = Random.Range(0.0f, 360f);
        transform.Rotate(new Vector3(0.0f, 0.0f, asteroidAngle));
    }

    private void FixedUpdate()
    {
        AsteroidFlight();
    }

    private void AsteroidFlight()
    {
        transform.Translate(Vector3.right * asteroidSpeed * Time.deltaTime);
    }
}
