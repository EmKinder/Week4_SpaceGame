using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveAndRotate : MonoBehaviour
{

    Rigidbody rb;
    GameObject player;
    Transform playerTrans;
    float speed = 2.0f;
    Vector3 moveDirection;

    PlayerHealth ph;
    EnemyDeath ed;
    bool canMove;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerTrans = player.GetComponent<Transform>();
        ph = player.GetComponent<PlayerHealth>();
        ed = GetComponentInChildren<EnemyDeath>();
        canMove = true;

    }

    // Update is called once per frame
    void Update()
    {

      /*  Vector3 targetDirection = player.transform.position - transform.position;

        float singleStep = speed * Time.deltaTime;

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        transform.localRotation = Quaternion.LookRotation(newDirection);*/

        if (canMove)
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);
            // Debug.Log(distance);


            if (distance < 70.0f)
            {
                transform.LookAt(playerTrans);
                transform.position += transform.forward * 5f * Time.deltaTime;
            }
        }
    }

    public void SetCanMove(bool ifCanMove)
    {
        canMove = ifCanMove;
    }
}
