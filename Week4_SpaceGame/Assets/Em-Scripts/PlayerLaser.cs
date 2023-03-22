using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaser : MonoBehaviour
{
    public GameObject player;
    private Rigidbody rb;
    public float force;
   // EnemyDeath ed;
    float timer;
    bool canShoot;
  //  GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    
     //   Vector3 direction = player.transform.position - transform.position;
        rb.velocity = -player.transform.forward.normalized * force;
       // transform.LookAt(player.transform);
        transform.Rotate(90.0f, 0.0f, 0.0f);
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 10)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            EnemyDeath ed = other.gameObject.GetComponent<EnemyDeath>();
            // Destroy(this.gameObject);
            ed.ThisEnemyDeath();
        }
    }

}