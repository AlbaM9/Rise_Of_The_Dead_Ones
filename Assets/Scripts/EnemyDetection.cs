using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            anim.SetBool("EnemyDetection", true);
        }
    }
    private void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            anim.SetBool("EnemyDetection", false);
        }
    }
}
