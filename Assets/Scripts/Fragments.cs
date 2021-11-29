using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragments : MonoBehaviour
{
    
    public PlayerStats frag;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D target) 
    
    {
        frag = FindObjectOfType<PlayerStats>();

        if (target.tag == "Player")
        {
            AudioManager.instance.PlayAudio(AudioManager.instance.pick);
            frag.bgFragments += 1;
            Destroy(this.gameObject);
        }
    }


}
