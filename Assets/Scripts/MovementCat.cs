using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCat : MonoBehaviour
{
    Animator anim;
    public float speed;
    Rigidbody2D rb;
    public float jumpHeight;


    public bool isWalker;
    public bool walksRight;
  
    public bool detectionON;

    public Transform wallcheck, pitCheck, groundCheck;
    public bool wallDetected, pitDetected, isGrounded;
    public float detectionRadius;
    public LayerMask whatIsGround;

    void Start()
    {

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        pitDetected = !Physics2D.OverlapCircle(pitCheck.position, detectionRadius, whatIsGround);
        wallDetected = Physics2D.OverlapCircle(wallcheck.position, detectionRadius, whatIsGround);
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, detectionRadius, whatIsGround);

        if ((pitDetected == true || wallDetected == true) && isGrounded == true)
        {
            Flip();
        }

    }
    private void FixedUpdate()
    {
        


        if (isWalker == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            if (!walksRight)
            {
                rb.velocity = new Vector2(-speed * Time.deltaTime, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
            }
        }

        RaySensor();
        if (detectionON == true )
        {
            rb.AddForce(rb.velocity * rb.mass, ForceMode2D.Impulse);
            anim.SetBool("Attack", true);


        }
        else
        {
            anim.SetBool("Attack", false);
        }
    }

    public void Flip()
    {
        
        walksRight = !walksRight;
        
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
       
        


    }
    public void RaySensor() 
    {
        Ray ray = new Ray(transform.position, transform.forward);
        
        float laserLength = 5f;
        Debug.DrawRay(transform.position, rb.velocity * laserLength, Color.blue);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, rb.velocity, laserLength);

        if (Physics2D.Raycast(transform.position, rb.velocity, laserLength, LayerMask.GetMask("Player")))
        {


            detectionON = true;



        }
        else
        {
            detectionON = false;

        }

    }
}
