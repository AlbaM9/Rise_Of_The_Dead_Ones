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
    public Vector2[] spawnPoints;
    public int currentPoint;
    public FireBossStatus fBStatus;
    public float statCh;

    public bool flip;
    public bool statusOn;
    
    public Transform player;

    public float dist;
    public float time;

    public bool instanceB;
    public enum FireBossStatus
    {
        TELEPORT,
        IDLE,
        ATTACK_1,



    }
    void Start()
    {
        instanceB = false;
        
        rb = GetComponent<Rigidbody2D>();
        attack = FindObjectOfType<BossRoomCanvas>();
        animator = GetComponent<Animator>();
        detection = FindObjectOfType<GhostMOvement>();
        shootCooldown = timeToShoot;

        
        StartCoroutine(WaitAttack());

        animator.SetBool("Attack", false);

        statusOn = false;

        flip = false;

      

       
            
        


    }
    private void Update()
    {
        time += Time.deltaTime;

        if (instanceB == true)
        {
            if (time >= 0.5f)
            {
                GameObject cross = Instantiate(projectile, shootPoint.position, Quaternion.identity);


                if (flip == false)
                {
                    cross.GetComponent<Rigidbody2D>().AddForce(transform.right * -1000, ForceMode2D.Force);
                }
                else
                {
                    cross.GetComponent<Rigidbody2D>().AddForce(transform.right * 1000, ForceMode2D.Force);
                }

                time = 0;
            }


           



        }
    }
    IEnumerator WaitAttack()
    {
        fBStatus = FireBossStatus.IDLE;
        yield return new WaitForSeconds(5);
        transform.position = new Vector2(254.61f, 1.03f);
        StartCoroutine(Statuses());

      

        
    }
    IEnumerator Statuses()
    {
        // añadir aqui el tiempo de espera antes de atacar
        
        var randomAttack = Random.Range(1, 5);

        yield return new WaitForSeconds(statCh);

        switch (randomAttack)
        {
            case 1:
                fBStatus = FireBossStatus.IDLE;
                break;
            case 2:
                fBStatus = FireBossStatus.TELEPORT;
                break;
            case 3:
                fBStatus = FireBossStatus.ATTACK_1;
                break;


        }
        StatusChanger();
    }

    public void StatusChanger()
    {
        switch (fBStatus)
        {
            case FireBossStatus.TELEPORT:

                Teleport();
                StartCoroutine(Statuses());
                break;
            case FireBossStatus.IDLE:
                StartCoroutine(Statuses());
                break;
            case FireBossStatus.ATTACK_1:
                Attack();
               // InvokeRepeating("Attack", 0.01f, 0.005f);
                
                StartCoroutine(Statuses());
               
                CancelInvoke();
                break;

        }
    }
    public void Teleport()
    {
        animator.SetBool("Attack", false);
        currentPoint = Random.Range(0, 6);

        Vector2 posi1 = new Vector2(254.61f, 1.03f);
        Vector2 posi2 = new Vector2(239.95f, -0.3f);
        Vector2 posi3 = new Vector2(239.84f, 2.68f);

        spawnPoints[0] = posi1;
        spawnPoints[1] = posi2;
        spawnPoints[2] = posi3;
        spawnPoints[3] = posi1;
        spawnPoints[4] = posi2;
        spawnPoints[5] = posi3;

        var teleport = spawnPoints[currentPoint];
        transform.position = teleport;
        if (teleport == posi2 || teleport == posi3)
        {
            flip = true;
            transform.localScale = new Vector3(-2f, 2f, 2);

        }
        else
        {
            flip = false;
            transform.localScale = new Vector3(2f, 2f, 2);
        }

    }
  

    public void Attack()
    {
        
        animator.SetBool("Attack", true);
        instanceB = true;
       
        /*
             GameObject cross = Instantiate(projectile, shootPoint.position, Quaternion.identity);
             if (flip == false)
             {
                 cross.GetComponent<Rigidbody2D>().AddForce(transform.right * -1000, ForceMode2D.Force);
             }
             else
             {
                 cross.GetComponent<Rigidbody2D>().AddForce(transform.right * 1000, ForceMode2D.Force);
             }

             */









    }

    
   
}
