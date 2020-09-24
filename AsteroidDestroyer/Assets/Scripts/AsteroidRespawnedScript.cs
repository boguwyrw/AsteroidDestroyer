using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRespawnedScript : MonoBehaviour
{
    private Vector2 screenBounds;

    private void Start()
    {
        SettingScreenBounds();
    }

    private void Update()
    {
        if (!AsteroidStatus())
        {
            StartCoroutine(ResumeObject());
        }
    }

    private bool AsteroidStatus()
    {
        return transform.GetChild(0).gameObject.activeSelf;
    }

    private void SettingScreenBounds()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0.0f));
    }

    private IEnumerator ResumeObject()
    {
        SettingScreenBounds();
        transform.position = new Vector3(Random.Range(screenBounds.x, int.MaxValue), Random.Range(screenBounds.y, int.MaxValue), 0.0f);
        yield return new WaitForSeconds(1);
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
