using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject Credits;



    public void Awake()
    {
        pauseMenuUI.SetActive(GameIsPaused);

    }

    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        GameIsPaused = false;
        pauseMenuUI.SetActive(GameIsPaused);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        GameIsPaused = true;
        pauseMenuUI.SetActive(GameIsPaused);
        Time.timeScale = 0f;
    }

    public void Menu()
    {
        GameIsPaused = false;
        pauseMenuUI.SetActive(GameIsPaused);
        Time.timeScale = 1f;
        GameManager.boss_health = 100;
        GameManager.player_health = 100;
        GameManager.boss_attack_type = 1;//
        GameManager.boss_attack_delay = 2;//
        GameManager.boss_attack_speed = 10;//
        GameManager.boss_attack_damage = 20;//
        GameManager.boss_move_speed = 40;//
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void credits()
    {
        
        Credits.SetActive(true);
        pauseMenuUI.SetActive(false);

    }

    public void creditsback()
    {
        pauseMenuUI.SetActive(true);
        Credits.SetActive(false);
        


    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
