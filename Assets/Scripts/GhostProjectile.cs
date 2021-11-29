using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostProjectile : MonoBehaviour
{
    public GameObject projectile;
    public Transform shootPoint;
    

    Animator anim;
    public GhostMOvement detection;

    public float timeToShoot;
    public float shootCooldown;

    void Start()
    {
        anim = GetComponent<Animator>();
        detection = FindObjectOfType<GhostMOvement>();
        shootCooldown = timeToShoot;
    }

    // Update is called once per frame
    void Update()
    {

        shootCooldown -= Time.deltaTime;


        if (detection.detectionON == true)
        {
            anim.SetBool("Attack", true);

            if (shootCooldown < 0)
            {
                GameObject cross = Instantiate(projectile, shootPoint.position, Quaternion.identity);


                if (detection.flipBalls == true)
                {

                    cross.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f, 0f), ForceMode2D.Force);
                }
                else
                {

                    cross.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f, 0f), ForceMode2D.Force);
                }

                shootCooldown = timeToShoot;
            }
            
        }
        else
        {
            anim.SetBool("Attack", false);
        }
    }
}
