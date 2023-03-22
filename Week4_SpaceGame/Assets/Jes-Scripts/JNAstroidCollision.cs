using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JNAstroidCollision : MonoBehaviour
{
    // Start is called before the first frame update
    ManageScene manager;
   public int whateverHealthTheyreLosing;
    
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<ManageScene>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //need to change to scene name to Lose Scene
            manager.GameOverLose();
         //  health.BeenHit(whateverHealthTheyreLosing);

        }
    }

}
