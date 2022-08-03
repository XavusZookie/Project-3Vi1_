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
        speed = GameManager.boss_attack_speed;
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

   


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "outerwalls")
        {


            GameManager.boss_hit = true;

            if (collision.tag == "Player" )
            {
                GameManager.player_health = GameManager.player_health - GameManager.boss_attack_damage;
                FindObjectOfType<AudioManager>().Play("Playerhit");
            }

            Destroy(gameObject);
        }


    }

}
