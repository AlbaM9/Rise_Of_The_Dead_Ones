using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatStats : MonoBehaviour
{
    

    
    Animator anim;
    public int life;
    public GameObject deathEffect;
    public GameObject bsFragments;
    public GameObject bsFragments2;

    

   // public Transform originRay;

    

    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
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
