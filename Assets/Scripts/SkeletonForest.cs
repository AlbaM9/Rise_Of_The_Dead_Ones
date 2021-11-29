using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonForest : MonoBehaviour
{

    Animator skeleton;
    public int life;
    public GameObject deathEffect;
    public GameObject bsFragments;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {
            //skeleton.SetBool("SkeletonDeath", true);
            AudioManager.instance.PlayAudio(AudioManager.instance.enemydeath);
            Destroy(this.gameObject);
            
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            
            Instantiate(bsFragments, transform.position, Quaternion.identity);
            

        }
        else
        {
           // skeleton.SetBool("SkeletonDeath", false);
        }
    }

    void OnTriggerEnter2D(Collider2D target)

    {

        if (target.tag == "Weapon")
        {
            AudioManager.instance.PlayAudio(AudioManager.instance.hurt);
            life -= 20;
        }


    }

}
