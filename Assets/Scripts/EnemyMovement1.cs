using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement1 : MonoBehaviour
{
    Animator anim;
    public float speed;
    Rigidbody2D rb;

    public bool isStatic;
    public bool isWalker;
    public bool walksRight;

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

        if ( (pitDetected == true || wallDetected == true) && isGrounded)
        {
            Flip();
        }

    }
    private void FixedUpdate()
    {
        if (isStatic == true)
        {
            anim.SetBool("Idle", true);
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else
        {
            anim.SetBool("Idle", false);
        }


        if (isWalker == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            if(!walksRight)
            {
                rb.velocity = new Vector2(-speed * Time.deltaTime, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
            }
        }
    }

    public void Flip() 
    {

        walksRight = !walksRight;
        // transform.localScale *= new Vector2(-1, transform.localScale.y);
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

        

    }
}
