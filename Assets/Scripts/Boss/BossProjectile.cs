using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjectile : MonoBehaviour
{
    Rigidbody2D rb;

    public GameObject projectile;
    public Transform shootPoint;
    public Transform shootRay;

    Animator animator;
    public GhostMOvement detection;

    public float timeToShoot;
    public float shootCooldown;

    public BossRoomCanvas attack;
    public bool detectionON = false;

    //public bool attackmode;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        attack = FindObjectOfType<BossRoomCanvas>();
        animator = GetComponent<Animator>();
        detection = FindObjectOfType<GhostMOvement>();
        shootCooldown = timeToShoot;
    }

    // Update is called once per frame
    void Update()
    {
        RaySensor();

        if (detectionON == true)
        {
            StartCoroutine(WaitAndAttack());

            shootCooldown -= Time.deltaTime;




            animator.SetBool("Attack", true);

            if (shootCooldown < 0)
            {
                GameObject cross = Instantiate(projectile, shootPoint.position, Quaternion.identity);





                cross.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f, 0f), ForceMode2D.Force);



                shootCooldown = timeToShoot;
            }


            else
            {
                animator.SetBool("Attack", false);
            }
        }

       
    }

    private IEnumerator WaitAndAttack()
    {


        yield return new WaitForSeconds(5);
        detectionON = true;
        Debug.LogWarning("BU");
        

    }

    public void RaySensor()
    {
        Ray ray = new Ray(shootRay.position, transform.forward);

        float laserLength = 10f;
        Debug.DrawRay(shootRay.position, Vector2.left * laserLength, Color.blue);
        RaycastHit2D hit = Physics2D.Raycast(shootRay.position, Vector2.left, laserLength);

        if (Physics2D.Raycast(shootRay.position, Vector2.left, laserLength, LayerMask.GetMask("Player")))
        {


            detectionON = true;



        }
        else
        {
            detectionON = false;

        }

    }

}
