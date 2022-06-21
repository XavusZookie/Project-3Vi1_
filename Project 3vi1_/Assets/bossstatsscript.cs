using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossstatsscript : MonoBehaviour
{
    public GameObject bulletprefab;
    public GameObject bossbulletprefab;

    public CharacterController2D controller;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Shoot()
    {
        GameObject currentbullet;

        if (controller.facing())
        {
            currentbullet = Instantiate(bulletprefab, this.transform.position + new Vector3(1, 0, 0), Quaternion.identity);
        }
        else
        {
            currentbullet = Instantiate(bulletprefab, this.transform.position + new Vector3(-1, .0f, 0), Quaternion.identity);
        }

        BulletMover movement = currentbullet.GetComponent<BulletMover>();
        movement.faceleft = controller.facing();
        yield return new WaitForSeconds(2f);
        StartCoroutine(Shoot());

    }

    public IEnumerator Shooteverywhere()
    {
        GameObject currentbullet;

        
        currentbullet = Instantiate(bossbulletprefab, this.transform.position + new Vector3(1, 0, 0), Quaternion.identity);
        

        bossbulletmover movement = currentbullet.GetComponent<bossbulletmover>();
        movement.faceleft = controller.facing();
        yield return new WaitForSeconds(2f);
        StartCoroutine(Shoot());


        for (int i = 1; i < 3; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                currentbullet = Instantiate(bulletprefab, this.transform.position + new Vector3(1, 0, 0), Quaternion.identity);
                 movement = currentbullet.GetComponent<bossbulletmover>();


            }
            }



        
            

        
    }

}

}
