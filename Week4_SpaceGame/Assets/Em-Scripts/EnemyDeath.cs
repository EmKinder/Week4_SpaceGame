using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    Animator anim;
    PlayerScore ps;
    public bool enemyDeathTest;
    EnemyCount ec;
  //  public int enemiesLeft;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        ps = GameObject.FindGameObjectWithTag("Manager").GetComponent<PlayerScore>();
        enemyDeathTest = false;
        ec = GameObject.FindGameObjectWithTag("Manager").GetComponent<EnemyCount>();
      //  enemiesLeft = 27;
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
            ec.SetEnemiesLeft();
            Destroy(this.gameObject.transform.parent.gameObject);
            Destroy(this.gameObject);
        }
    }


}
