using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    GameObject player;
    float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDirection = player.transform.position - transform.position;

        float singleStep = speed * Time.deltaTime;

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, -targetDirection, singleStep, 0.0f);

        transform.localRotation = Quaternion.LookRotation(newDirection);
    }
}
