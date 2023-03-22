using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLazer : MonoBehaviour
{
    public GameObject lazerPosition;
    public GameObject lazerSpawn;
    private Rigidbody rb;
    public float force;
    float timer;
    bool canShoot;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Laser Positions");
        Debug.Log(transform.position);
        Debug.Log(lazerPosition.transform.position);
        Vector3 direction = transform.TransformPoint(transform.position) - lazerPosition.transform.TransformPoint(lazerPosition.transform.position);
        rb.velocity = new Vector3(direction.x, direction.y, direction.z).normalized * force;
        transform.LookAt(lazerPosition.transform);
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
            Destroy(this.gameObject);
        }
    }
}
