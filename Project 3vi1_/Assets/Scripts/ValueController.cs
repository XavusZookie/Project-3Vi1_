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
                case "bossattacktype":
                    GameManager.boss_attack_speed = temp;
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
