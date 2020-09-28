using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private float laserSpeed = 6000;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        Invoke("DestroyLaser", 3.0f);
    }

    private void FixedUpdate()
    {
        FireLaser();
    }

    private void FireLaser()
    {
        rigidbody2D.AddForce(transform.up * laserSpeed * Time.deltaTime);
    }

    private void DestroyLaser()
    {
        Destroy(gameObject);
    }
}
