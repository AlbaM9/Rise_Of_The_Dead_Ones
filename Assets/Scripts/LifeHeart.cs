using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeHeart : MonoBehaviour
{
    
    public PlayerStats heart;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D target)

    {
        heart = FindObjectOfType<PlayerStats>();

        if (target.tag == "Player" && heart.life < 200)
        {
            AudioManager.instance.PlayAudio(AudioManager.instance.pick);
            heart.life += 20;
            Destroy(this.gameObject);
        }
        else if (target.tag == "Player" && heart.life >= 200)
        {
            AudioManager.instance.PlayAudio(AudioManager.instance.pick);
            Destroy(this.gameObject);
        }
    }
}
