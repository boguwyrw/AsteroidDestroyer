using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameControllerScript : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        DestructionOfLaserScript.playerScore = 0;
        Time.timeScale = 1.0f;
    }
}
