using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossStats : MonoBehaviour
{
   
    
    private float bosslife;
    public Animator anim;

    public BossRoomCanvas lifebar;
    public PlayerController pla;

    // public Transform originRay;

    public BossRoomCanvas room;



    // Start is called before the first frame update
    void Start()
    {
        
        room = FindObjectOfType<BossRoomCanvas>();
        room. canvasBossy.SetActive(true);
        room.bossLIndicator.enabled = true;
        pla = FindObjectOfType<PlayerController>();

        
        anim = GetComponent<Animator>();
        bosslife = 300f;
    }

    // Update is called once per frame
    void Update()
    {
        room.bossLIndicator.fillAmount =bosslife / 300;

        if (bosslife <= 0)
        {
           
            pla.finalScene.SetActive(true) ;
            anim.SetBool("Death", true);
            Time.timeScale = 0;





        }


    }


    void OnTriggerEnter2D(Collider2D target)

    {

        if (target.tag == "Weapon")
        {
            anim.SetBool("Getdamaged", true);
            bosslife -= 5;
        }


    }
    void OnTriggerExit2D(Collider2D target)

    {

        if (target.tag == "Weapon")
        {
            anim.SetBool("Getdamaged", false);
            
        }


    }
}
