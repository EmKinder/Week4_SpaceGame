using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class JNScoreSystem : MonoBehaviour
{
   public int score;
    public Text textScore;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ScoreText()
    {
        textScore.text = score.ToString();
    }

    public void AddPointSystem(int point)
    {
        score = score + point;
        ScoreText();

        if(score >= 1500)
        {
            //load win scene
        }
    }

    public void MinusPointSystem(int point)
    {
        score = score - point;
        ScoreText();

    }

}
