using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossStats : MonoBehaviour
{
    public GameObject finalScene;
    public Image bossLIndicator;
    private float bosslife;
    public Animator anim;

    public BossRoomCanvas lifebar;

    // public Transform originRay;





    // Start is called before the first frame update
    void Start()
    {
        finalScene.SetActive(false);
        anim = GetComponent<Animator>();
        bosslife = 300f;
    }

    // Update is called once per frame
    void Update()
    {
        bossLIndicator.fillAmount =bosslife / 300;
        if (bosslife <= 0)
        {
           
            finalScene.SetActive(true) ;
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
