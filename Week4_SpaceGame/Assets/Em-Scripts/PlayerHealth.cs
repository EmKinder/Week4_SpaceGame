using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    float startingHealth = 3;
    public float currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BeenHit(int livesLost)
    {
        currentHealth -= livesLost;
        if(currentHealth <= 0)
        {
            //Game Over
            Debug.Log("Game Over");
        }
        else
        {
            //Update UI
            Debug.Log("Hit! Lives Remaining:" + currentHealth);
        }
    }
}
