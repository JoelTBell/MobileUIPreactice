using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CLikcer : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    private string SCORE = "HighScore";
    public int TrueScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + TrueScore;
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt(SCORE);
    }

    public void AddPoint()
    {
        TrueScore++;

        if(PlayerPrefs.GetInt(SCORE) <= TrueScore)
        {
            PlayerPrefs.SetInt(SCORE, TrueScore);
        }

        highScoreText.text = "High Score: " + PlayerPrefs.GetInt(SCORE);
    }
}
