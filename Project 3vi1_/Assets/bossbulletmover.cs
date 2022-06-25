using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossbulletmover : MonoBehaviour
{
    Vector3 angle = new Vector3(1, 0, 0);
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + (angle * (speed * Time.deltaTime));


    }

    public void anglemaker(Vector3 givenangle)
    {
        angle = givenangle;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player" || collision.collider.tag == "outerwalls")
        {
            GameManager.boss_hit = true;
            Destroy(gameObject);
        }
        

    }

}
