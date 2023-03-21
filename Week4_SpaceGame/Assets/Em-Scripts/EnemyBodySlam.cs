using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBodySlam : MonoBehaviour
{

    Rigidbody rb;
    GameObject player;
    Transform playerTrans;
    float speed = 2.0f;
    Vector3 moveDirection;

    PlayerHealth ph;
    EnemyDeath ed;
    public EnemyMoveAndRotate mr;
   // bool canMove;

    public AudioSource audio;
    public AudioClip death;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerTrans = player.GetComponent<Transform>();
        ph = player.GetComponent<PlayerHealth>();
        ed = GetComponentInChildren<EnemyDeath>();
        //canMove = true;
        
      //  es = GetComponent<EnemyShooting>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            // canMove = false;
            mr.SetCanMove(false);
            ph.BeenHit(1);
            ed.ThisEnemyDeath();
           // es.SetCanShoot(false);
        }
    }
}
