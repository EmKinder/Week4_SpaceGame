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
    PlayerAiming pa;
    GameObject playerMain;

    // Start is called before the first frame update
    void Start()
    {
        playerMain = GameObject.FindGameObjectWithTag("PlayerMain");
        enemiesLeft = 24;
        ms = gameObject.GetComponent<ManageScene>();
        player = GameObject.FindGameObjectWithTag("Player");
        moveToPosition1 = false;
        moveToPosition2 = false;
        moveToStartPosition = false;
        pa = GameObject.FindGameObjectWithTag("Aiming").GetComponent<PlayerAiming>();
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
        //  if (player)
        //   {
        if (playerMain)
        {
            if (moveToStartPosition)
            {
                if (!(playerMain.transform.position.z >= -12))
                {
                    pa.IfCanMoveMouse(false);
                    playerMain.transform.position += new Vector3(0, 0, 20f) * Time.deltaTime;
                }
                else
                {
                    pa.IfCanMoveMouse(true);
                    moveToStartPosition = false;
                }
            }


            if (moveToPosition1)
            {
                Debug.Log("PLAYER SHOULD BE MOVING");
                if (playerMain.transform.position.z <= 160)
                {
                    pa.IfCanMoveMouse(false);

                    Debug.Log("PLAYER REALLY SHOULD BE MOVING");
                    playerMain.transform.position += new Vector3(0, 0, 20f) * Time.deltaTime;
                }
                else
                {
                    pa.IfCanMoveMouse(true);

                    Debug.Log("PLAYER STOP MOVING");
                    moveToPosition1 = false;
                }
            }

            if (moveToPosition2)
            {
                if (!(playerMain.transform.localPosition.z >= 380))
                {
                    pa.IfCanMoveMouse(false);

                    playerMain.transform.position += new Vector3(0, 0, 20f) * Time.deltaTime;
                }

                else
                {
                    pa.IfCanMoveMouse(true);

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
