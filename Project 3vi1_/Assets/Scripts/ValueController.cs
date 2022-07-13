using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ValueController : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI text;

   

    public string stat = "bosshealth";

    // Start is called before the first frame update
    void Start()
    {
        
        slider.onValueChanged.AddListener((h) =>
        {
            int temp = (int)h;

            switch (stat)
            {
                case "bosshealth":
                    GameManager.boss_health = temp;
                    text.text = GameManager.boss_health.ToString();
                    break;
                case "bossdamage":
                    GameManager.boss_attack_damage = temp;
                    text.text = GameManager.boss_attack_damage.ToString();
                    break;
                case "bossattackspeed":
                    GameManager.boss_attack_speed = temp;
                    text.text = GameManager.boss_attack_speed.ToString();
                    break;
                case "bossattackdelay":
                    GameManager.boss_attack_delay = temp;
                    text.text = GameManager.boss_attack_delay.ToString();
                    break;
                case "bossattacktype":
                    GameManager.boss_attack_type = temp;
                    switch (temp)
                    {
                        case 1:
                            
                            text.text ="Straight";
                            break;
                        case 2:
                            
                            text.text = "Tracking";
                            break;
                        case 3:
                            
                            text.text = "Straight and Tracking";
                            break;
                        default:
                            // code block
                            break;
                    }
                    
                    break;
                case "bossattackdirection":
                    GameManager.boss_attack_directions = temp;
                    switch (temp)
                    {
                        case 1:

                            text.text = "Everywhere";
                            break;
                        case 2:

                            text.text = "Horizontal";
                            break;
                        case 3:

                            text.text = "Towards You";
                            break;
                        default:
                            // code block
                            break;
                    }

                    break;
                case "bossmovespeed":
                    GameManager.boss_move_speed = temp;
                    text.text = GameManager.boss_move_speed.ToString();
                    break;
                case "bossmovepattern":
                    GameManager.boss_move_pattern = temp;
                    switch (temp)
                    {
                        case 1:

                            text.text = "Stationary";
                            break;
                        case 2:

                            text.text = "Random";
                            break;
                        case 3:

                            text.text = "Follows You";
                            break;
                        default:
                            // code block
                            break;
                    }

                    break;
                case "trackingstrength":
                    GameManager.boss_tracking_strength = temp;
                    text.text = GameManager.boss_tracking_strength.ToString();
                    break;
                case "trackingspeed":
                    GameManager.boss_tracking_speed = temp;
                    text.text = GameManager.boss_tracking_speed.ToString();
                    break;
                default:
                    // code block
                    break;
            }


            
        });
        

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


}
