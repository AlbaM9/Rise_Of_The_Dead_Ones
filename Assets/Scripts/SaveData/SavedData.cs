using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class SavedData : MonoBehaviour
{


    public PlayerStats items;
    public PlayerController dJumpSave;

    public Text savedText;

    public bool savedDataON = false;
    public Transform playerPos;

    public NecromPages necrom;



    private void Awake()
    {
        necrom = FindObjectOfType<NecromPages>();
        
        items = FindObjectOfType<PlayerStats>();
        dJumpSave = FindObjectOfType<PlayerController>();

    }
    void Start()
    {
        
        savedText.enabled = false;


        LoadNecromPages();

        items.potions = PlayerPrefs.GetInt("Potion");
        items.catalizer = PlayerPrefs.GetInt("catalizer");
        items.poison = PlayerPrefs.GetInt("poison");
        items.antidote = PlayerPrefs.GetInt("antidote");
        items.bloodGems = PlayerPrefs.GetInt("bg");
        items.bgFragments = PlayerPrefs.GetInt("bfFragments");
        items.necromiconPages = PlayerPrefs.GetInt("pages");
        items.life = PlayerPrefs.GetFloat("life", 200f);
        dJumpSave.DoubJump = PlayerPrefs.GetInt("DoubJump") == 1;


        LoadPosition();

        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerPrefs.DeleteAll();
        }
    }






    // Update is called once per frame
    void Update()
    {




    }
    private void OnTriggerStay2D(Collider2D target)
    {
        if (target.tag == "Player")
        {

            PlayerPrefs.SetInt("Potion", items.potions);
            PlayerPrefs.SetInt("catalizer", items.catalizer);
            PlayerPrefs.SetInt("poison", items.poison);
            PlayerPrefs.SetInt("antidote", items.antidote);
            PlayerPrefs.SetInt("bg", items.bloodGems);
            PlayerPrefs.SetInt("bfFragments", items.bgFragments);
            PlayerPrefs.SetInt("pages", items.necromiconPages);
            PlayerPrefs.SetFloat("life", items.life);
            PlayerPrefs.SetInt("DoubJump", dJumpSave.DoubJump ? 1 : 0);

            SaveNecromPages();
            SavePosition();
            savedDataON = true;



            savedText.enabled = true;

            

        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            savedText.enabled = false;
        }


    }

    public void SavePosition()
    {
        PlayerPrefs.SetFloat("X", playerPos.position.x);
        PlayerPrefs.SetFloat("y", playerPos.position.y);
    }
    public void LoadPosition()
    {
        Vector2 position;
        position.x = PlayerPrefs.GetFloat("X", -0.27f);
        position.y = PlayerPrefs.GetFloat("y", -7.5f);

        playerPos.position = new Vector2(position.x, position.y);
    }
     
   public void SaveNecromPages() 
    {

        PlayerPrefs.SetInt("NPag1", items.have1);
        PlayerPrefs.SetInt("NPag2", items.have2);
        PlayerPrefs.SetInt("NPag3", items.have3);
        PlayerPrefs.SetInt("NPag4", items.have4);
        PlayerPrefs.SetInt("NPag5", items.have5);
        PlayerPrefs.SetInt("NPag6", items.have6);
        PlayerPrefs.SetInt("NPag7", items.have7);
        PlayerPrefs.SetInt("NPag8", items.have8);
        PlayerPrefs.SetInt("NPag9", items.have9);
        PlayerPrefs.SetInt("NPag10", items.have10);
    
    }
    public void LoadNecromPages()
    {

        items.have1 = PlayerPrefs.GetInt("NPag1", 0);
        items.have2 = PlayerPrefs.GetInt("NPag2", 0);
        items.have3 = PlayerPrefs.GetInt("NPag3", 0);
        items.have4 = PlayerPrefs.GetInt("NPag4", 0);
        items.have5 = PlayerPrefs.GetInt("NPag5", 0);
        items.have6 = PlayerPrefs.GetInt("NPag6", 0);
        items.have7 = PlayerPrefs.GetInt("NPag7", 0);
        items.have8 = PlayerPrefs.GetInt("NPag8", 0);
        items.have9 = PlayerPrefs.GetInt("NPag9", 0);
        items.have10 = PlayerPrefs.GetInt("NPag10", 0);

    }

}
