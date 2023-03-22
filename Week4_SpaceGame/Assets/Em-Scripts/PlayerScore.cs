using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int score;
    Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();
        scoreText.text = score.ToString("000000");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();
        scoreText.text = score.ToString("000000");
    }

    public void SetScore(int thisScore)
    {
        score += thisScore;
    }

    public void ResetScore()
    {
        score = 0;
    }
    
}
