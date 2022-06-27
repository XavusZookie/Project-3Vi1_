using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uicontroller : MonoBehaviour
{
    public Text text;
    public Text bosshealthtext;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (text != null)
        {
            text.text = GameManager.player_health.ToString();
        }

        if (bosshealthtext != null)
        {
            bosshealthtext.text = GameManager.boss_health.ToString();
        }
    }
}
