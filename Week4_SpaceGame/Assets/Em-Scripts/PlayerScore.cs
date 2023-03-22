using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString("000000");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString("000000");
    }

    public void SetScore(int thisScore)
    {
        score += thisScore;
    }
    
}
