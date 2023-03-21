using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAiming : MonoBehaviour
{
    [SerializeField] private Camera fpsCamera;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private GameObject rotationObjects;
    public GameObject laser;
    public Transform laserPos;
    private float timer;
    public AudioSource audio;
    public AudioClip pewpew;
    public float speed = 15f;
    bool canShoot;

    private void Start()
    {
        canShoot = true;
    }

    private void Update()
    {
        Ray ray = fpsCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, layerMask))
        {
            
            transform.position = raycastHit.point;
            
            Vector3 rotation = raycastHit.point - rotationObjects.transform.position;
            float rotZ = Mathf.Atan2(rotation.x, rotation.z) * Mathf.Rad2Deg;
            float rotX = Mathf.Atan2(rotation.y, rotation.z) * Mathf.Rad2Deg;
            rotationObjects.transform.localRotation = Quaternion.Euler(-(rotX + 90), 0, rotZ);


            
            /*
            Vector3 targetDirection = raycastHit.point - rotationObjects.transform.position;
            float singleStep = speed * Time.deltaTime;
            Vector3 newDirection = Vector3.RotateTowards(rotationObjects.transform.forward, -targetDirection, singleStep, 0.0f);
            rotationObjects.transform.localRotation = Quaternion.LookRotation(newDirection);
            */



        }

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
        Instantiate(laser, laserPos.position, rotationObjects.transform.localRotation);
    }
}
