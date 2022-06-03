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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown("s"))
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
}
