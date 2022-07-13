using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public GameObject Credits;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextbutton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void credits()
    {
        Credits.SetActive(true);

    }
    public void back()
    {
        Credits.SetActive(false);

    }

    public void quit()
    {
        Application.Quit();

    }

    public void mainmenu()
    {
        
        GameManager.boss_health = 100;
        GameManager.player_health = 100;
        GameManager.boss_attack_type = 1;//
        GameManager.boss_attack_delay = 2;//
        GameManager.boss_attack_speed = 10;//
        GameManager.boss_attack_damage = 20;//
        GameManager.boss_move_speed = 40;//


    SceneManager.LoadScene(0);
    }
}
