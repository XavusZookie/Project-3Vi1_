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
        StartCoroutine(Shooteverywhere());
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
  

        yield return new WaitForSeconds(2f);
        StartCoroutine(Shooteverywhere());
    }

}


