using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JNMothershipFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject mothership;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mothership.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - 3);
    }
}
