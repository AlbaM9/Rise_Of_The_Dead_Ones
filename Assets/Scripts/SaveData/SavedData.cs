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




    private void Awake()
    {
        items = FindObjectOfType<PlayerStats>();
        dJumpSave = FindObjectOfType<PlayerController>();

    }
    void Start()
    {
        
        savedText.enabled = false;



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
     
   


}
