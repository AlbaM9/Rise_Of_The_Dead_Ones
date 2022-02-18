using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossRoomCanvas : MonoBehaviour
{
    public BossProjectile attack;
    public BossStats lifebar;
    public GameObject walls;

    public GameObject canvasBossy;

    public Image bossLIndicator;

    void Start()
    {
        walls.SetActive(false);
        bossLIndicator.enabled = false;
        canvasBossy.SetActive(false);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            walls.SetActive(true);
            
            
            
           
            Destroy(this.gameObject);
        }
    }

   
}
