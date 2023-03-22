using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float senstivity = 1f;
    Vector3 rotate;
    float x;
    public GameObject laser;
    public Transform laserPos;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Mouse X");
        rotate = new Vector3(0, x * senstivity);
        transform.eulerAngles = transform.eulerAngles - rotate;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laser, laserPos.position, Quaternion.identity);
        }
    }

}
