using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBodySlam : MonoBehaviour
{

    Rigidbody rb;
    PlayerHealth ph;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ph = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ph.BeenHit(1);
            //do animation then
            Destroy(this.gameObject);
        }
    }
}
