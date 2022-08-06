using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class effectsvolumehandler : MonoBehaviour
{
    public Slider slider;
    

    // Start is called before the first frame update
    void Start()
    {
        


        slider.onValueChanged.AddListener((h) =>
        {
            float temp = (float)h;

         

            GameManager.effectsvolume = temp;
        });
    }

    
}
