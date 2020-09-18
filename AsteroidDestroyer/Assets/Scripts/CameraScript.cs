using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
    private GameObject spaceship;

    private Vector3 cameraPosition;

    private void Update()
    {
        cameraPosition = new Vector3(spaceship.transform.position.x, spaceship.transform.position.y, transform.position.z);

        transform.position = cameraPosition;
    }
}
