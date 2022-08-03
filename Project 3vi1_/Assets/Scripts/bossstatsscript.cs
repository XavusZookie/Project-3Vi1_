using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossstatsscript : MonoBehaviour
{

    public Transform target;

    public GameObject bulletprefab;
    public GameObject bossbulletprefab;

    public CharacterController2D controller;
    // Start is called before the first frame update
    void Start()
    {
        switch (GameManager.boss_attack_directions)
        {
            case 1:

                StartCoroutine(Shooteverywhere());

                break;
            case 2:
                StartCoroutine(Shoot());


                break;
            case 3:
                StartCoroutine(Shoottracker());


                break;
            default:
                StartCoroutine(Shooteverywhere());
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Shoot()
    {
        GameObject currentbullet;
        bossbulletmover movement;

        if (controller.facing())
        {
            currentbullet = Instantiate(bossbulletprefab, this.transform.position + new Vector3(-0.0500137396f + 0.3072967f, -0.0351952314f, 0), Quaternion.identity);
            movement = currentbullet.GetComponent<bossbulletmover>();
            movement.anglemaker(new Vector3(1, 0, 0));
            
        }
        else
        {
            currentbullet = Instantiate(bossbulletprefab, this.transform.position + new Vector3(-0.0500137396f - 0.3072967f, -0.0351952314f, 0), Quaternion.identity);
            movement = currentbullet.GetComponent<bossbulletmover>();
            movement.anglemaker(new Vector3(-1, 0, 0)); 
            
        }
        FindObjectOfType<AudioManager>().Play("Bossshoot");

        yield return new WaitForSeconds(GameManager.boss_attack_delay);
        StartCoroutine(Shoot());

    }

     IEnumerator Shooteverywhere()
    {
        GameObject currentbullet;

        currentbullet = Instantiate(bossbulletprefab, this.transform.position + new Vector3(-0.0500137396f+ 0.3072967f, -0.0351952314f - 0.3072967f, 0), Quaternion.identity);
        bossbulletmover movement = currentbullet.GetComponent<bossbulletmover>();
        movement.anglemaker(new Vector3(1, -1, 0));
        

        currentbullet = Instantiate(bossbulletprefab, this.transform.position + new Vector3(-0.0500137396f+ 0.3072967f, -0.0351952314f, 0), Quaternion.identity);
        movement = currentbullet.GetComponent<bossbulletmover>();
        movement.anglemaker(new Vector3(1, 0, 0));
        

        currentbullet = Instantiate(bossbulletprefab, this.transform.position + new Vector3(-0.0500137396f+ 0.3072967f, -0.0351952314f+ 0.3072967f, 0), Quaternion.identity);
        movement = currentbullet.GetComponent<bossbulletmover>();
        movement.anglemaker(new Vector3(1, 1, 0));
        

        currentbullet = Instantiate(bossbulletprefab, this.transform.position + new Vector3(-0.0500137396f, -0.0351952314f+ 0.3072967f, 0), Quaternion.identity);
        movement = currentbullet.GetComponent<bossbulletmover>();
        movement.anglemaker(new Vector3(0, 1, 0));
      

        currentbullet = Instantiate(bossbulletprefab, this.transform.position + new Vector3(-0.0500137396f- 0.3072967f, -0.0351952314f+ 0.3072967f, 0), Quaternion.identity);
        movement = currentbullet.GetComponent<bossbulletmover>();
        movement.anglemaker(new Vector3(-1, 1, 0));
       

        currentbullet = Instantiate(bossbulletprefab, this.transform.position + new Vector3(-0.0500137396f- 0.3072967f, -0.0351952314f, 0), Quaternion.identity);
        movement = currentbullet.GetComponent<bossbulletmover>();
        movement.anglemaker(new Vector3(-1, 0, 0));
       

        currentbullet = Instantiate(bossbulletprefab, this.transform.position + new Vector3(-0.0500137396f- 0.3072967f, -0.0351952314f- 0.3072967f, 0), Quaternion.identity);
        movement = currentbullet.GetComponent<bossbulletmover>();
        movement.anglemaker(new Vector3(-1, -1, 0));
       

        currentbullet = Instantiate(bossbulletprefab, this.transform.position + new Vector3(-0.0500137396f, -0.0351952314f- 0.3072967f, 0), Quaternion.identity);
        movement = currentbullet.GetComponent<bossbulletmover>();
        movement.anglemaker(new Vector3(0, -1, 0));

        FindObjectOfType<AudioManager>().Play("Bossshoot");
        yield return new WaitForSeconds(GameManager.boss_attack_delay);
        StartCoroutine(Shooteverywhere());
    }


     IEnumerator Shoottracker()
    {
        GameObject currentbullet;

        if (controller.facing())
        {
            currentbullet = Instantiate(bossbulletprefab, this.transform.position + new Vector3(1, 0, 0), Quaternion.identity);
        }
        else
        {
            currentbullet = Instantiate(bossbulletprefab, this.transform.position + new Vector3(-1, .0f, 0), Quaternion.identity);
        }

        Vector3 targetvector = target.position;
        Vector3 bossvector = this.gameObject.transform.position;
        Vector3 angletowardsplayer = new Vector3(0, 0, 0);
        float x,y, hyp;
        x = targetvector.x - bossvector.x;
        y = targetvector.y - bossvector.y;
        hyp = Mathf.Sqrt((x*x) + (y*y));


        FindObjectOfType<AudioManager>().Play("Bossshoot");
        bossbulletmover movement = currentbullet.GetComponent<bossbulletmover>();
        movement.anglemaker(new Vector3(x/hyp, y/hyp, 0));
        yield return new WaitForSeconds(GameManager.boss_attack_delay);
        StartCoroutine(Shoottracker());

    }
}