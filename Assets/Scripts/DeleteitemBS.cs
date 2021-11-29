using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteitemBS : MonoBehaviour
{
    
    public PlayerStats gems;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D target)
    {

        gems =FindObjectOfType<PlayerStats>();
        if (target.tag == "Player")
        {
            AudioManager.instance.PlayAudio(AudioManager.instance.pick);
            gems.bloodGems += 1;
           
            Destroy(this.gameObject);
        }


    }

}
