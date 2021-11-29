using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMOvement : MonoBehaviour
{
    Animator anim;
    public float speed;
    Rigidbody2D rb;
    public PlayerStats life;

    
    public GameObject bulletPrefab;

    public bool isStatic;
    public bool isWalker;
    public bool walksRight;
    public bool detectionON;

    public Transform wallcheck, pitCheck, groundCheck;
    public bool wallDetected, pitDetected, isGrounded;
    public float detectionRadius;
    public LayerMask whatIsGround;


    public Rigidbody2D redEnemyBullet;
    
    public float velDisparo;
    public float tiempoDisparo;
    private float insDisp;
    public Transform shootpoint2;
    public Transform rayPoint;

    public bool flipBalls;
    public int speedBalls;

    void Start()
    {
        life = FindObjectOfType<PlayerStats>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {

        pitDetected = !Physics2D.OverlapCircle(pitCheck.position, detectionRadius, whatIsGround);
        wallDetected = Physics2D.OverlapCircle(wallcheck.position, detectionRadius, whatIsGround);
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, detectionRadius, whatIsGround);

        if ((pitDetected == true || wallDetected == true) && isGrounded )
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
            if (!walksRight)
            {
                flipBalls = true;
                rb.velocity = new Vector2(-speed * Time.deltaTime, rb.velocity.y);
            }
            else
            {
                flipBalls = false;
                rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
            }
        }
        RaySensor();

    }

    public void Flip()
    {

        walksRight = !walksRight;
        // transform.localScale *= new Vector2(-1, transform.localScale.y);
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;



    }
    public void RaySensor()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        float laserLength = 5f;
        Debug.DrawRay(rayPoint.position, Vector2.left * laserLength, Color.blue);
        RaycastHit2D hit = Physics2D.Raycast(rayPoint.position, Vector2.left, laserLength);

        if (Physics2D.Raycast(rayPoint.position, Vector2.left, laserLength, LayerMask.GetMask("Player")))
        {


            detectionON = true;



        }
        else
        {
            detectionON = false;

        }

    }


}
