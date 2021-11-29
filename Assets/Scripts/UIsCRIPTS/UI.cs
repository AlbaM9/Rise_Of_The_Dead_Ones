using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public PlayerStats player;
    
    
    public Text nGems;
    public Text nPages;
    public Text nFragments;
    public Image iPotion;
    public Image iCatalizer;
    public Image iPoison;
    public Image iAntidote;
    public Image iLife;
    public Image iStamina;

    public Text txInitial;


    void Start()
    {
        player = FindObjectOfType<PlayerStats>();
       

        iPotion.enabled = false;
        iCatalizer.enabled = false;
        iPoison.enabled = false;
        iAntidote.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (player.potions >= 1)
        {
            iPotion.enabled = true;
        }
        if (player.catalizer >= 1)
        {
            iCatalizer.enabled = true;
        }
        if (player.poison >= 1)
        {
            iPoison.enabled = true;
        }
        if (player.antidote >= 1)
        {
            iAntidote.enabled = true;
        }

        nGems.text = player.bloodGems.ToString();
        nPages.text = player.necromiconPages.ToString() + (" / 10");
        nFragments.text = player.bgFragments.ToString();


        iLife.fillAmount = player.life / 200;
        iStamina.fillAmount = player.stamina / 50;
        
    }

    
}
