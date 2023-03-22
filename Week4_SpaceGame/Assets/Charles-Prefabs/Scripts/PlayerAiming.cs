using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAiming : MonoBehaviour
{
    public Camera fpsCamera;
    public GameObject laser;
    public Transform laserPos;
    private float timer;
    public AudioSource audio;
    public AudioClip pewpew;
    public float speed = 15f;
    public GameObject ship;
    public float sensitivityX = 5f;
    public float sensitivityY = 5f;
    public float minimumX = -45f;
    public float maximumX = 45f;
    public float minimumY = -90f;
    public float maximumY = 90f;
    public float rotationX = 0f;
    public float rotationY = 0f;
    public GameObject player;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        //Aiming


        rotationX += Input.GetAxis("Mouse Y") * sensitivityX;
        rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);
        rotationY += Input.GetAxis("Mouse X") * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
        ship.transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);

        timer += Time.deltaTime;


        if (timer > 2 && Input.GetMouseButton(0))
        {
            audio.clip = pewpew;
            audio.Play();
            timer = 0;
            Shoot();
         }
    }

    void Shoot()
    {
        Debug.Log(laserPos.position);
        Debug.Log(laserPos.TransformPoint(laserPos.position));
        Instantiate(laser, laserPos.position, player.transform.rotation);
    }
}
