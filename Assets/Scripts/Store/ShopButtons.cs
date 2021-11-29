using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButtons : MonoBehaviour
{
    private int buttonPressed = 0;
    public PlayerStats items;
    public PlayerController jumping;


  


    public Button potion;
    public Button catalizer;
    public Button poison;
    public Button antidote;
    public Button doubleJump;

    void Start()
    {
        jumping = FindObjectOfType<PlayerController>();
        items = FindObjectOfType<PlayerStats>();


        potion.gameObject.SetActive(false);
        catalizer.gameObject.SetActive(false);
        poison.gameObject.SetActive(false);
        antidote.gameObject.SetActive(false);
        doubleJump.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MyButtonFunction()
    {
        
        
            if (items.bloodGems >= 50)
            {
                items.potions += 1;
                Destroy(GameObject.FindWithTag("Potions"));
                items.bloodGems -= 50;
                potion.gameObject.SetActive(false);
            }
           

    }
    public void MyButtonFunction1()
    {


        if (items.bloodGems >= 50)
        {
            items.catalizer += 1;
            Destroy(GameObject.FindWithTag("Catalizer"));
            items.bloodGems -= 50;
            catalizer.gameObject.SetActive(false);
        }


    }

    public void MyButtonFunction2()
    {


        if (items.bloodGems >= 50)
        {
            items.poison += 1;
            Destroy(GameObject.FindWithTag("Poison"));
            items.bloodGems -= 50;
            poison.gameObject.SetActive(false);
        }


    }
    public void MyButtonFunction3()
    {


        if (items.bloodGems >= 50)
        {
            items.antidote += 1;
            Destroy(GameObject.FindWithTag("Antidote"));
            items.bloodGems -= 50;
            antidote.gameObject.SetActive(false);
        }


    }
    public void MyButtonFunctionJump()
    {

        if (items.bloodGems >= 15)
        {
            items.bloodGems -= 15;
            jumping.DoubJump = true;
            doubleJump.gameObject.SetActive(false);
        }
        
       



    }
    private void OnTriggerStay2D(Collider2D target)
    {
        if (target.tag == "Player" && items.potions != 1)
        {
            
            
                potion.gameObject.SetActive(true);
            
        }
        if (target.tag == "Player" && items.catalizer != 1)
        {


            catalizer.gameObject.SetActive(true);

        }
        if (target.tag == "Player" && items.poison != 1)
        {


            poison.gameObject.SetActive(true);

        }
        if (target.tag == "Player" && items.antidote != 1)
        {


            antidote.gameObject.SetActive(true);

        }
        if (target.tag == "Player" && !jumping.DoubJump == true)
        {


            doubleJump.gameObject.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            potion.gameObject.SetActive(false);
            catalizer.gameObject.SetActive(false);
            poison.gameObject.SetActive(false);
            antidote.gameObject.SetActive(false);
            doubleJump.gameObject.SetActive(false);
        }
    }
}
