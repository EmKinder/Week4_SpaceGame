using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    Animator anim;
    PlayerScore ps;
    public bool enemyDeathTest;
    public int enemiesLeft;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        ps = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScore>();
        enemyDeathTest = false;
        enemiesLeft = 27;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyDeathTest)
        {
            ThisEnemyDeath();
            enemyDeathTest = false;
        }
    }

    public void ThisEnemyDeath()
    {
        Debug.Log("Script Triggered");
        ps.SetScore(100);
        StartCoroutine(ThisEnemyDeathIEnumerator(3.0f));
    }

    private IEnumerator ThisEnemyDeathIEnumerator(float waitTime)
    {
        while (true)
        {
            Debug.Log("Coroutine Called");
            anim.SetTrigger("wobble");
            yield return new WaitForSeconds(waitTime);
            SetEnemiesLeftInScene();
            Destroy(this.gameObject.transform.parent.gameObject);
            Destroy(this.gameObject);
        }
    }
    
    void SetEnemiesLeftInScene()
    {
        enemiesLeft -= 1;
        if(enemiesLeft == 0)
        {
            Debug.Log("You Win!");
        }
    }
}
