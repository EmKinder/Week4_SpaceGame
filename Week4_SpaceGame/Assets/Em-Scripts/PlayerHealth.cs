using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    float startingHealth = 3;
    public float currentHealth;
    public Image leftHeart1;
    public Image rightHeart1;
    public Image leftHeart2;
    public Image rightHeart2;
    public Image leftHeart3;
    public Image rightHeart3;
    ManageScene ms;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
        ms = GameObject.FindGameObjectWithTag("Manager").GetComponent<ManageScene>();
    }

    // Update is called once per frame
    void Update()
    {
        ViewableLives();
    }

    public void BeenHit(float livesLost)
    {
        currentHealth -= livesLost;
        if(currentHealth <= 0)
        {
            //Game Over
            Debug.Log("Game Over");
            ms.GameOverLose();
        }
        else
        {
            //Update UI
            Debug.Log("Hit! Lives Remaining:" + currentHealth);
        }
    }

    void ViewableLives()
    {
        if (currentHealth == 3)
        {
            rightHeart3.enabled = true;
            leftHeart3.enabled = true;
            rightHeart2.enabled = true;
            leftHeart2.enabled = true;
            rightHeart1.enabled = true;
            leftHeart1.enabled = true;
        }

        if (currentHealth == 2.5)
        {
            rightHeart3.enabled = false;
            leftHeart3.enabled = true;
            rightHeart2.enabled = true;
            leftHeart2.enabled = true;
            rightHeart1.enabled = true;
            leftHeart1.enabled = true;
        }
        if (currentHealth == 2)
        {
            rightHeart3.enabled = false;
            leftHeart3.enabled = false;
            rightHeart2.enabled = true;
            leftHeart2.enabled = true;
            rightHeart1.enabled = true;
            leftHeart1.enabled = true;

        }
        if (currentHealth == 1.5)
        {
            rightHeart3.enabled = false;
            leftHeart3.enabled = false;
            rightHeart2.enabled = false;
            leftHeart2.enabled = true;
            rightHeart1.enabled = true;
            leftHeart1.enabled = true;

        }
        if (currentHealth == 1)
        {
            rightHeart3.enabled = false;
            leftHeart3.enabled = false;
            rightHeart2.enabled = false;
            leftHeart2.enabled = false;
            rightHeart1.enabled = true;
            leftHeart1.enabled = true;

        }
        if (currentHealth == 0.5)
        {
            rightHeart3.enabled = false;
            leftHeart3.enabled = false;
            rightHeart2.enabled = false;
            leftHeart2.enabled = false;
            rightHeart1.enabled = false;
            leftHeart1.enabled = true;

        }
        if (currentHealth <= 0)
        {
            rightHeart3.enabled = false;
            leftHeart3.enabled = false;
            rightHeart2.enabled = false;
            leftHeart2.enabled = false;
            rightHeart1.enabled = false;
            leftHeart1.enabled = false;

        }
    }
}
