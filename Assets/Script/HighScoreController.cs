using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreController : MonoBehaviour
{
  //  public text scoreText;
    int score;


    void Start()
    {
        score = 0;
    }

    public void AddScore(int points)
    {
        score += points;


       // scoreText.text = string.Format("SCORE: {0:0000000000}", score);

    }

}
