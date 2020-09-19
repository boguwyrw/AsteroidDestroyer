using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControllerScript : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    private int score;

    private void Start()
    {
        ScoreCalculation();
    }

    private void Update()
    {
        ScoreCalculation();
    }

    private void ScoreCalculation()
    {
        score = DestructionOfLaserScript.playerScore;
        DisplayScoreText();
    }

    private void DisplayScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
