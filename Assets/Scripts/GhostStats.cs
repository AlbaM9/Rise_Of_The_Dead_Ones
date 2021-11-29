using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostStats : MonoBehaviour
{

    
    public int life;
    public GameObject deathEffect;
    public GameObject bsFragments;
    public GameObject bsFragments2;
    public GameObject bsFragments3;



    // public Transform originRay;





    // Start is called before the first frame update
    void Start()
    {
        life = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {



            Destroy(this.gameObject);
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Instantiate(bsFragments, transform.position, Quaternion.identity);
            Instantiate(bsFragments2, transform.position, Quaternion.identity);
            Instantiate(bsFragments3, transform.position, Quaternion.identity);




        }


    }


    void OnTriggerEnter2D(Collider2D target)

    {

        if (target.tag == "Weapon")
        {
            life -= 20;
        }


    }
}
