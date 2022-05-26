using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public Transform leftdoor;
    public Transform rightdoor;
    public float speed = 3f;
    public bool clicked = false;
    public CanvasGroup fader;
    public GameObject butt;
    public GameObject panel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {

        if (clicked == true)
        {
            leftdoor.Translate(Vector3.up * Time.deltaTime * speed);

            rightdoor.Translate(Vector3.down * Time.deltaTime * speed);

            fader.alpha = (fader.alpha -.3f * Time.deltaTime);

        }

        if (rightdoor.position.x >= 2500f )
        {
            clicked = false;
            Destroy(butt);
        }

    }

    public void enterbutton()
    {
        clicked = true;
    }

    public void clickaway()
    {
        clicked = false;
        leftdoor.position = new Vector3(-2500f,0,0);
        rightdoor.position = new Vector3(2500f, 0, 0);
        fader.alpha = 0;
        Destroy(butt);
        Destroy(panel);

    }

}
