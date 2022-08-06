using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;


public class volumehandler : MonoBehaviour
{
    public Slider slider;
    public AudioSource noise;

    void Awake()
    {
        noise.volume = GameManager.volume;


        slider.onValueChanged.AddListener((h) =>
        {
            float temp = (float)h;

            noise.volume = temp;

            GameManager.volume = temp;
        });
} 
}
