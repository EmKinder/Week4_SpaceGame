using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ThisEnemyDeath()
    {
        Debug.Log("Script Triggered");
        StartCoroutine(ThisEnemyDeathIEnumerator(5.0f));
    }

    private IEnumerator ThisEnemyDeathIEnumerator(float waitTime)
    {
        while (true)
        {
            Debug.Log("Coroutine Called");
            anim.SetTrigger("wobble");
            yield return new WaitForSeconds(waitTime);
            Destroy(this.gameObject);
        }
    }
}
