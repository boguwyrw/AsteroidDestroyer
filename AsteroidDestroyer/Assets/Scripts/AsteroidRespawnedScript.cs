using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRespawnedScript : MonoBehaviour
{
    private void Update()
    {
        //if (transform.GetChild(0).gameObject.activeSelf == false)
        if (!AsteroidStatus())
        {
            StartCoroutine(ResumeObject());
        }
    }

    private bool AsteroidStatus()
    {
        return transform.GetChild(0).gameObject.activeSelf;
    }

    private IEnumerator ResumeObject()
    {
        yield return new WaitForSeconds(1);
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
