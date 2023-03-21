using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject laser;
    public Transform laserPos;

    private float timer;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        float distance = Vector3.Distance(transform.position, player.transform.position);
       // Debug.Log(distance);


        if(distance < 10.0f)
        {
            if (timer > 2)
            {
                timer = 0;
                Shoot();
            }
        }
 
    }

    void Shoot()
    {
        Instantiate(laser, laserPos.position, Quaternion.identity);
    }
}
    