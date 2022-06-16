using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossstatsscript : MonoBehaviour
{
    public GameObject bulletprefab;
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
            currentbullet = Instantiate(bulletprefab, this.transform.position + new Vector3(1, .63f, 0), Quaternion.identity);
        }
        else
        {
            currentbullet = Instantiate(bulletprefab, this.transform.position + new Vector3(-1, .63f, 0), Quaternion.identity);
        }

        BulletMover movement = currentbullet.GetComponent<BulletMover>();
        movement.faceleft = controller.facing();
        yield return new WaitForSeconds(2f);
        StartCoroutine(Shoot());

    }

    public IEnumerator Shooteverywhere()
    {
        GameObject currentbullet;

        if (controller.facing())
        {
            currentbullet = Instantiate(bulletprefab, this.transform.position + new Vector3(1, .63f, 0), Quaternion.identity);
        }
        else
        {
            currentbullet = Instantiate(bulletprefab, this.transform.position + new Vector3(-1, .63f, 0), Quaternion.identity);
        }

        BulletMover movement = currentbullet.GetComponent<BulletMover>();
        movement.faceleft = controller.facing();
        yield return new WaitForSeconds(2f);
        StartCoroutine(Shoot());

    }

}
