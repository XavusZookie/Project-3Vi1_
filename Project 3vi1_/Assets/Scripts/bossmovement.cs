using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossmovement : MonoBehaviour
{
    public Transform target;
    public CharacterController2D controller;
  
    
    private GameObject currentonewayplatform;
    [SerializeField] private CircleCollider2D playercollider;
    

    public float runSpeed = 40f;
    public bool jump = true;
    public float jumpdelay = 1;
    public bool fall = true;
    public float falldelay = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    
  

    void FixedUpdate()
    {

        


        if (target.position.x - this.transform.position.x > 0)
        {

            if (target.position.y - this.transform.position.y > 1 && jump)
            {


                controller.Move(1* GameManager.boss_move_speed * Time.deltaTime, false, true);
                StartCoroutine(Timerforjump());




            }
            else if (target.position.y - this.transform.position.y < -1)
            {

                
                if (currentonewayplatform != null && fall)
                {

                    StartCoroutine(DisableCollision());
                    StartCoroutine(Timer());
                    
                }
                controller.Move(1* GameManager.boss_move_speed * Time.deltaTime, false, false);


                

            }
            else
            {
                controller.Move(1 * GameManager.boss_move_speed * Time.deltaTime, false, false);
            }




            

        }
        else if (target.position.x - this.transform.position.x < 0)
        {

            if (target.position.y - this.transform.position.y > 1 && jump)
            {


                controller.Move(-1 * GameManager.boss_move_speed * Time.deltaTime, false, true);
                StartCoroutine(Timerforjump());




            }
            else if (target.position.y - this.transform.position.y < -1)
            {

                    if (currentonewayplatform != null && fall)
                    {

                        StartCoroutine(DisableCollision());
                    StartCoroutine(Timer());
                }
                controller.Move(-1 * GameManager.boss_move_speed * Time.deltaTime, false, false);

                
                    
                

                

            }
            else
            {
                controller.Move(-1 * GameManager.boss_move_speed * Time.deltaTime, false, false);
            }

            


            

        }

        
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
        Physics2D.IgnoreCollision(playercollider, platformCollider, false);

    }

    public IEnumerator Timer()
    {
        fall = false;
        yield return new WaitForSeconds(falldelay);
        fall = true;


    }

    public IEnumerator Timerforjump()
    {
        jump = false;
        yield return new WaitForSeconds(jumpdelay);
        jump = true;


    }
}
