using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JNMinusPoint : MonoBehaviour
{
    public int pointScore;
    public JNScoreSystem scoreSystem;

    // Start is called before the first frame update
    void Start()
    {
        scoreSystem = GameObject.Find("ScoringSystem").GetComponent<JNScoreSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {


            scoreSystem.MinusPointSystem(pointScore);




        }

    }
}
