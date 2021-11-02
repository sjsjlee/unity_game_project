using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static int score = 0;

    public Text scoreText;
    public Text highscoreText;

    private int savedScore = 0;
    private string keystring = "highscore";

    void Awake()
    {

        savedScore = PlayerPrefs.GetInt(keystring, 0);
        highscoreText.text = "HIGH SCORE:" + savedScore.ToString("000000");

    }
    void Start()
    {

    }

    void Update()
    {
        scoreText.text = "SCORE : " + score.ToString("000000");

        if (score > savedScore)
        {
            PlayerPrefs.SetInt(keystring, score);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

     
    }
}