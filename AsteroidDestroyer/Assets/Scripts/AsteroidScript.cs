using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;
    private float asteroidSpeed;
    private float asteroidAngle;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.gravityScale = 0.0f;
        asteroidSpeed = Random.Range(25.0f, 100.0f);
        asteroidAngle = Random.Range(0.0f, 360f);
        transform.Rotate(new Vector3(0.0f, 0.0f, asteroidAngle));
    }

    private void FixedUpdate()
    {
        AsteroidFlight();
    }

    private void AsteroidFlight()
    {
        //rigidbody2D.AddForce(transform.right * asteroidSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * 3 * Time.deltaTime);
    }
}
