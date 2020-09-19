using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipShootingScript : MonoBehaviour
{
    [SerializeField]
    private GameObject laser;
    [SerializeField]
    private Transform firePoint;

    private void Start()
    {
        InvokeRepeating("Shooting", 0.0f, 0.5f);
    }

    private void Shooting()
    {
        Instantiate(laser, firePoint.position, firePoint.rotation);
    }
}
