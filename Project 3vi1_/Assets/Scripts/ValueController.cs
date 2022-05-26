using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ValueController : MonoBehaviour
{
    public Slider healthslider;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        healthslider.onValueChanged.AddListener((v) =>
        {
            int temp = (int)v;
            GameManager.boss_health = temp;
        });
    }

    // Update is called once per frame
    void Update()
    {
        text.text = GameManager.boss_health.ToString();
    }

    


}
