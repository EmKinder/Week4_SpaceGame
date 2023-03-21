using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject laser;
    public Transform laserPos;

    private float timer;
    private GameObject player;
    public AudioSource audio;
    public AudioClip pewpew;
    bool canShoot;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(canShoot == true) { 
            timer += Time.deltaTime;

            float distance = Vector3.Distance(transform.position, player.transform.position);
           // Debug.Log(distance);


            if(distance < 10.0f)
            {
                if (timer > 2)
                {
                    audio.clip = pewpew;
                    audio.Play();
                    timer = 0;
                    Shoot();
                }
            }
        }
    }

    void Shoot()
    {
        Instantiate(laser, laserPos.position, Quaternion.identity);
    }

    public void SetCanShoot(bool ifCanShoot)
    {
        canShoot = ifCanShoot;
    }
}
    