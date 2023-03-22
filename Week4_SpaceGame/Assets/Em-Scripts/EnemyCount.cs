using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCount : MonoBehaviour
{

    public int enemiesLeft;
    ManageScene ms; 
    // Start is called before the first frame update
    void Start()
    {
        enemiesLeft = 24;
        ms = gameObject.GetComponent<ManageScene>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetEnemiesLeft()
    {
        enemiesLeft -= 1;
        if(enemiesLeft == 0)
        {
            ms.GameOverWin();
        }
    }

    public void ResetEnemies()
    {
        enemiesLeft = 27;
    }
}
