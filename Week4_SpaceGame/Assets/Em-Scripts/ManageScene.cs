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
    private static GameObject instance;

    // Start is called before the first frame update

    private void Awake()
    {


if (instance == null)
        {
            instance = this.gameObject;
            DontDestroyOnLoad(gameObject);
        }
       // DontDestroyOnLoad(this.gameObject);
        backgroundMusic = gameObject.GetComponent<AudioSource>();
        es = gameObject.GetComponent<EnemyCount>();
        ps = gameObject.GetComponent<PlayerScore>();

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
        backgroundMusic.Stop();
        ps.ResetScore();
        es.ResetEnemies();
       // backgroundMusic.loop = true;
        SceneManager.LoadScene(0);
      //  backgroundMusic.clip = backgroundSound;
      //  backgroundMusic.Play();


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
