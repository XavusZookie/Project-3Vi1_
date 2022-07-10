using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    float horizontalMove = 0f;

    public float runSpeed = 40f;
    bool jump = false;
    private GameObject currentonewayplatform;
    [SerializeField] private BoxCollider2D playercollider;
    public bool canshoot = true;
    public GameObject bulletprefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("space")&& canshoot)
        {
           

                StartCoroutine(Shoot());
            
        }

        if (Input.GetKeyDown("s"))
        {
            if(currentonewayplatform != null)
            {
                
                StartCoroutine(DisableCollision());
            }
        }

        horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

    }
        // Update is called once per frame
        void FixedUpdate()
    {

        controller.Move(horizontalMove * Time.deltaTime, false, jump);
        jump = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("onewayplatform"))
        {
            currentonewayplatform = collision.gameObject;
            
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("onewayplatform"))
        {
            
            currentonewayplatform = null;
        }
    }

    public IEnumerator DisableCollision()
    {
        
        Collider2D platformCollider = currentonewayplatform.GetComponent<Collider2D>();

        Physics2D.IgnoreCollision(playercollider, platformCollider);
        yield return new WaitForSeconds(.25f);
        Physics2D.IgnoreCollision(playercollider,platformCollider, false);

    }

    public IEnumerator Shoot()
    {

        canshoot = false;
        GameObject currentbullet;

        if(controller.facing())
        {
             currentbullet = Instantiate(bulletprefab, this.transform.position + new Vector3(1, .20f, 0), Quaternion.identity);
        }
        else
        {
             currentbullet = Instantiate(bulletprefab, this.transform.position + new Vector3(-1, .2f, 0), Quaternion.identity);
        }

        BulletMover movement = currentbullet.GetComponent<BulletMover>();
        movement.faceleft = controller.facing();
        yield return new WaitForSeconds(.75f);
        canshoot = true;

    }
}
