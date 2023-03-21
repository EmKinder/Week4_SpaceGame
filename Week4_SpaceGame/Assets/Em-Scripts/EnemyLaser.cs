using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyLaser : MonoBehaviour
{
    public GameObject player;
    private Rigidbody rb;
    public float force;
    PlayerHealth ph;
    float timer;
    bool canShoot;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        ph = player.GetComponent<PlayerHealth>();

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector3(direction.x, direction.y, direction.z).normalized * force;
        transform.LookAt(player.transform);
        transform.Rotate(90.0f, 0.0f, 0.0f);
        canShoot = true;
    }   

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 
        if(timer > 10)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ph.BeenHit(0.5f);
            Destroy(this.gameObject);
        }
    }

}
