using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShootingScript : MonoBehaviour, IShootingScript
{
    [SerializeField]
    private GameObject laser;
    [SerializeField]
    private Transform firePoint;

    private void Start()
    {
        InvokeRepeating("IShootingScript.Shooting", 0.0f, 0.5f);
    }

    void IShootingScript.Shooting()
    {
        Instantiate(laser, firePoint.position, firePoint.rotation);
    }
}
