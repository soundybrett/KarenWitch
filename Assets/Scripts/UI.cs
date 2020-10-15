using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text scoreText;
    public Text livesText;
    public void SetScoreText(int score)
    {
        scoreText.text = score.ToString();
    }

    public void SetLivesText(int Lives)
    {
        livesText.text = Lives.ToString();
    }
}
