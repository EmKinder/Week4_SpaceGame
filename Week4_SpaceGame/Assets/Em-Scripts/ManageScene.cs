using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class ManageScene : MonoBehaviour
{
    bool gamePaused;
    public AudioSource backgroundMusic;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        gamePaused = false;
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame(bool ifGamePaused)
    {
        if (!gamePaused)
        {
            backgroundMusic.Pause();
            Time.timeScale = 0.0f;
            gamePaused = true;
            canvas.enabled = true;
        }
        else
        {
            Time.timeScale = 1.0f;
            backgroundMusic.Play();
            gamePaused = false;
            canvas.enabled = false;

        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
