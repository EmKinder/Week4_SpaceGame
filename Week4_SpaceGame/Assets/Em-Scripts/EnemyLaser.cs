using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyLaser : MonoBehaviour
{
    public GameObject player;
    private Rigidbody rb;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector3(direction.x, direction.y, direction.z).normalized * force;
        transform.LookAt(player.transform);
        transform.Rotate(90.0f, 0.0f, 0.0f);
        // float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(rot, 0, 0);
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
