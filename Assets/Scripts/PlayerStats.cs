using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    public NecromPages necrom;
    public float life;
    public float maxLife = 200f;
    
    public int necromiconPages;
    public int potions;
    public int catalizer;
    public int poison;
    public int antidote;
    public int bloodGems;
    public int bgFragments;
    public int elixir;
    public float stamina;
   
    public bool getDamaged;

    public Text initialTX;


    public Image background;
    public Image gameOver;
    public Image theWoods;
    

    public Button mainMenu;
    public Button continueGame;

    public int have1;
    public int have2;
    public int have3;
    public int have4;
    public int have5;
    public int have6;
    public int have7;
    public int have8;
    public int have9;
    public int have10;

    void Start()
    {
        necrom = FindObjectOfType<NecromPages>();
        necrom.ElimPages();

        life = maxLife;
        
        getDamaged = false;
        background.enabled = false;
        gameOver.enabled = false;
        mainMenu.gameObject.SetActive(false);
        continueGame.gameObject.SetActive(false);
        initialTX.enabled = true;


        if (potions == 1)
        {
            Destroy(GameObject.FindWithTag("Potions"));
        }
        if (catalizer == 1)
        {
            Destroy(GameObject.FindWithTag("Catalizer"));
        }
        if (poison == 1)
        {
            Destroy(GameObject.FindWithTag("Poison"));
        }
        if (antidote == 1)
        {
            Destroy(GameObject.FindWithTag("Antidote"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        PassZone();

        if (bgFragments >= 5)
        {
            bloodGems += 1;
            bgFragments -= 5;
        }
        

        if (life <= 0)
        {
            Time.timeScale = 0;
            background.enabled = true;
            gameOver.enabled = true;
            mainMenu.gameObject.SetActive(true);
            continueGame.gameObject.SetActive(true);

            
        }

       
    }


   void OnTriggerEnter2D (Collider2D target)
    {
        if (target.tag == "Potions")
        {
            AudioManager.instance.PlayAudio(AudioManager.instance.pick);
            potions += 1;
            Destroy(GameObject.FindWithTag("Potions"));
        }
        if (target.tag == "Catalizer")
        {
            AudioManager.instance.PlayAudio(AudioManager.instance.pick);
            catalizer += 1;
            Destroy(GameObject.FindWithTag("Catalizer"));
        }
        if (target.tag == "Poison")
        {
            AudioManager.instance.PlayAudio(AudioManager.instance.pick);
            poison += 1;
            Destroy(GameObject.FindWithTag("Poison"));
        }
        if (target.tag == "Antidote")
        {
            AudioManager.instance.PlayAudio(AudioManager.instance.pick);
            antidote += 1;
            Destroy(GameObject.FindWithTag("Antidote"));
        }

        
        if (target.tag == "LimitZone")
        {
            Debug.Log("Aun no debes pasar");
        }

       
        

    }
    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "SkeletonWeak")
        {
            getDamaged = true;
            life -= 20;

        }

        if (target.gameObject.tag == "CatDmg")
        {
            getDamaged = true;
            life -= 40;

        }
    }

    void OnTriggerExit2D(Collider2D target)
    {

        if (target.tag == "SkeletonWeak")
        {

            getDamaged = false;

        }
        if (target.gameObject.tag == "CatDmg")
        {
            getDamaged = false;
            life -= 40;

        }

        if (target.gameObject.tag == "BossDamage")
        {
            getDamaged = false;
            life -= 20;

        }
    }
    void PassZone()
    {
        if (potions == 1 && catalizer ==1 && poison == 1 && antidote == 1)
        {
            elixir = 1;
            Debug.Log("has obtenido el elixir");
            Destroy(GameObject.FindWithTag("LimitZone"));
        }
        if (elixir == 1)
        {
            initialTX.enabled = false;
        }
      


    }
}

