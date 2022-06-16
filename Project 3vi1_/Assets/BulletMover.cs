using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    public float speed = 10;
    public bool faceleft;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!faceleft)
        {
        transform.position = transform.position + (Vector3.left * (speed * Time.deltaTime));

        }
        else
        {
        transform.position = transform.position + (Vector3.right * (speed * Time.deltaTime));

        }

       
            //transform.position = transform.position + (new Vector3(-1,-1,0) * (speed * Time.deltaTime));

        
    }

    

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "nojump")
        {
            GameManager.boss_hit = true;
            Destroy(gameObject);
        }
        Destroy(gameObject);
        
    }
}
