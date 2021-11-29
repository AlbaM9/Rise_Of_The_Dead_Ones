using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecromPages : MonoBehaviour
{
    
    public PlayerStats necro;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D target)

    {
        necro = FindObjectOfType<PlayerStats>();

        if (target.tag == "Player")
        {
            necro.necromiconPages += 1;
            Destroy(this.gameObject);
        }
    }

}
