using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed, jumpHeight;
    float velX, velY;
    Rigidbody2D rb;
    public Transform groundCheck;
    public bool isGrounded;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    public bool DoubJump = false;
    private bool jump = true;
    private int CountJump = 1;
    public int siDoubJumpEnabled = 0;

    
    

    Animator anim;
    public PlayerStats stats;

    
    void Start()
    {

        
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        stats = FindObjectOfType<PlayerStats>();
    }

    
    void Update()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
 

        if (isGrounded )
        {
          anim.SetBool("Jump", false);

        }
        else
        {
            anim.SetBool("Jump", true);
        }


        Flip();
        Attack();
        Jump();


       /* if (stats.getDamaged == true)
        {
            anim.SetBool("Hurt", true);
        }
        else
        {
            anim.SetBool("Hurt", false);
        }*/
    }

    private void FixedUpdate()

    {
        Movement();
       
    }

    public void Attack()
    {
       

        if (Input.GetButton("Fire1"))
        {
            AudioManager.instance.PlayAudio(AudioManager.instance.attack);
            anim.SetBool("Attack", true);
            


        }
        else
        {
            anim.SetBool("Attack", false);
        }
       
    }
    public void Movement()
    {

        velX = Input.GetAxisRaw("Horizontal");
        velY = rb.velocity.y;


        rb.velocity = new Vector2(velX * speed, velY);
        if (rb.velocity.x != 0)
        {
            
            anim.SetBool("Run", true);

        }
        else
        {
            anim.SetBool("Run", false);
           
        }
    }
    public void Flip()
    {
       if (velX /* rb.velocity.x */> 0)
       {
            transform.localScale = new Vector3(2, 2, 2);
       }
       else if (velX /* rb.velocity.x */< 0)  //voltea al player
       {
            transform.localScale = new Vector3(-2, 2, 2);
       }
       
    }

    public void Jump()
    {
        

        if (DoubJump == false)
        {
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
               
                rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
                


                anim.SetBool("Jump", false);
                AudioManager.instance.PlayAudio(AudioManager.instance.jump);

            }
        } else
        {
            if (Input.GetButtonDown("Jump") && jump == true)
            {
                
                rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
               

                anim.SetBool("Jump", false);
                AudioManager.instance.PlayAudio(AudioManager.instance.jump);


                CountJump ++;
                if (CountJump == 1)
                {
                    jump = false;
                }
            }
           
        }

        if(isGrounded)
        {
            CountJump = 0;
            jump = true;
        }
        
            
    }
}
