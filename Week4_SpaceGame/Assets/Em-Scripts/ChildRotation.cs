using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildRotation : MonoBehaviour
{
    GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.identity;
        transform.localPosition = Vector3.zero;
    }
}
