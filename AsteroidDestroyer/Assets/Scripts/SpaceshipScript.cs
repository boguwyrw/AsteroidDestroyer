using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipScript : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private float spaceshipSpeed = 8.0f;
    private float spaceshipRotationSpeed = 75.0f;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.gravityScale = 0.0f;
    }

    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * -spaceshipRotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * spaceshipRotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * spaceshipSpeed * Time.deltaTime);
        }
    }
}
