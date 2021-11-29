using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDestroyed : MonoBehaviour
{
    public PlayerStats playerlife;
    void Start()
    {
        playerlife = FindObjectOfType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
      
       
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
           
            playerlife.life -= 20;
           // Destroy(this.gameObject);

        }
        else
        {
            Destroy(this.gameObject, 0.1f);
        }
    }
}
