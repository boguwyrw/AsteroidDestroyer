using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipScript : MonoBehaviour
{
    private Vector2 screenBounds;
    private float spaceshipSpeed = 8;

    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0.0f));
    }

    private void Update()
    {
        PlayerMovement();
        PlayerBounds();
    }

    private void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * spaceshipSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right * spaceshipSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.up * spaceshipSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.up * spaceshipSpeed * Time.deltaTime);
        }
    }

    private void PlayerBounds()
    {
        Vector2 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(transform.position.x, -screenBounds.x + 1.5f, screenBounds.x - 1.5f);
        playerPosition.y = Mathf.Clamp(transform.position.y, -screenBounds.y, screenBounds.y);
        transform.position = playerPosition;
    }
}
