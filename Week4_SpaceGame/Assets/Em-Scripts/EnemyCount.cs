using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCount : MonoBehaviour
{

    public int enemiesLeft;
    ManageScene ms;
    GameObject player;
    bool moveToPosition1;
    bool moveToPosition2;
    bool moveToStartPosition;
    public bool CheckEnemiesLeftBool;

    // Start is called before the first frame update
    void Start()
    {
        enemiesLeft = 24;
        ms = gameObject.GetComponent<ManageScene>();
        player = GameObject.FindGameObjectWithTag("Player");
        moveToPosition1 = false;
        moveToPosition2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        CheckEnemiesLeft();
      /*  if (CheckEnemiesLeftBool)
        {
            TriggerEnemiesLeftTest();
            CheckEnemiesLeftBool = false;
        }*/
        if (player)
        {
            if (moveToStartPosition) {
                if (!(player.transform.position.z >= 55))
                    player.transform.position += new Vector3(0, 0, 20f) * Time.deltaTime;
                else
                    moveToStartPosition = false;

                if (moveToPosition1)
                {
                    if (!(player.transform.position.z >= 235))
                        player.transform.position += new Vector3(0, 0, 20f) * Time.deltaTime;
                else
                    moveToPosition1 = false;

                    if (moveToPosition2) 
                        if (!(player.transform.position.z >= 445)) 
                            player.transform.position += new Vector3(0, 0, 20f) * Time.deltaTime;
                        else 
                            moveToPosition2 = false;
                        
                    }
            }
        }
    }
        

    public void SetEnemiesLeft()
    {
        enemiesLeft -= 1;
        CheckEnemiesLeft();

    }

    public void ResetEnemies()
    {
        enemiesLeft = 24;
    }

    public void CheckEnemiesLeft()
    {

        if(enemiesLeft == 24)
        {
            moveToStartPosition = true;
        }
        if (enemiesLeft == 16)
        {
            Debug.Log("Enemies = 16");
            moveToPosition1 = true;
        }
        if (enemiesLeft == 8)
        {
            moveToPosition2 = true;
            // player.transform.position.z//233
        }
        if (enemiesLeft == 0)
        {
            ms.GameOverWin();
        }
    }

    public void TriggerEnemiesLeftTest()
    {
        SetEnemiesLeft();
    }
    
}
