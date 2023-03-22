using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class ManageScene : MonoBehaviour
{
    bool gamePaused;
    AudioSource backgroundMusic;
    public Canvas canvas;
    PlayerScore ps;
    public AudioClip gameOverSound;
    public AudioClip backgroundSound;
    EnemyCount es;

    // Start is called before the first frame update

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        backgroundMusic = GameObject.FindGameObjectWithTag("Manager").GetComponent<AudioSource>();
        es = gameObject.GetComponent<EnemyCount>();
    }
    void Start()
    {
        gamePaused = false;
        canvas.enabled = false;
        backgroundMusic.clip = backgroundSound;
        backgroundMusic.loop = true;
        backgroundMusic.Play();
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
        ps.ResetScore();
        es.ResetEnemies();
        backgroundMusic.clip = backgroundSound;
        backgroundMusic.loop = true;
        backgroundMusic.Play();
        SceneManager.LoadScene(0);
    }

    public void GameOverLose()
    {
       // backgroundMusic.Stop();
        backgroundMusic.clip = gameOverSound;
        backgroundMusic.loop = false;
        backgroundMusic.Play();
        SceneManager.LoadScene(1);


    }

    public void GameOverWin()
    {
        SceneManager.LoadScene(2);
    }
}
