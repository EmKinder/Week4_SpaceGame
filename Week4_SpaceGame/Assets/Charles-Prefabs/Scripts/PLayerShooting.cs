using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerShooting : MonoBehaviour
{

    public GameObject laser;
    public Transform laserPos;

    private float timer;
    private GameObject enemy;
    public AudioSource audio;
    public AudioClip pewpew;
    bool canShoot;
    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot == true)
        {
            timer += Time.deltaTime;


            if (timer > 2 && Input.GetMouseButton(0))
            {
                audio.clip = pewpew;
                audio.Play();
                timer = 0;
                Shoot();
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

