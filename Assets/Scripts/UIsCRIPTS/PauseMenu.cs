using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public Image pauseMenu;
    public Button resume;
    public Button mainMenu;
    public Button exit;

    void Start()
    {
        pauseMenu.enabled = false;
      

        resume.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        enabledMainMenu();
    }

    void enabledMainMenu()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pauseMenu.enabled = true;


                resume.gameObject.SetActive(true);
                mainMenu.gameObject.SetActive(true);
                exit.gameObject.SetActive(true);
            }
            
        }
       
    }
}
