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
    float x;
    float y;
    Vector3 rotate;
    public float sensitivityX = 5f;
    public float sensitivityY = 5f;
    public float minimumX = -45f;
    public float maximumX = 45f;
    public float minimumY = -90f;
    public float maximumY = 90f;
    public float rotationX = 0f;
    public float rotationY = 0f;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {


        Debug.Log(Input.mousePosition);

        /*
        Ray ray = fpsCamera.ScreenPointToRay(Input.mousePosition);
        //
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            Debug.Log("HHHHHHHHHHIIIIIIIIIIIIIIIIITTTTTTTTTTTTTTT");
            transform.position = raycastHit.point;
            
            Vector3 rotation = raycastHit.point - rotationObjects.transform.position;
            float rotZ = Mathf.Atan2(rotation.x, rotation.y) * Mathf.Rad2Deg;
            float rotX = Mathf.Atan2(rotation.z, rotation.y) * Mathf.Rad2Deg;
            rotationObjects.transform.rotation = Quaternion.Euler(rotX, 0, rotZ);


            /*
            Vector3 targetDirection = raycastHit.point - rotationObjects.transform.position;
            float singleStep = speed * Time.deltaTime;
            Vector3 newDirection = Vector3.RotateTowards(rotationObjects.transform.forward, -targetDirection, singleStep, 0.0f);
            rotationObjects.transform.localRotation = Quaternion.LookRotation(newDirection);
           



        }

         */


        //Aiming


        rotationX += Input.GetAxis("Mouse Y") * sensitivityX;
        rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);
        rotationY += Input.GetAxis("Mouse X") * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
        ship.transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);

        /*
        x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y");
        rotate = new Vector3(y * sensitivity, -(x * sensitivity), 0);
        ship.transform.eulerAngles = ship.transform.eulerAngles - rotate;
        */


        

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
        Instantiate(laser, laserPos.position, Quaternion.identity);
    }
}
