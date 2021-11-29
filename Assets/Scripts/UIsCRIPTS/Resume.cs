using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resume : MonoBehaviour
{
    private int buttonPressed = 0;
    public Image pauseMenu;

    public Button resume;
    public Button mainMenu;
    public Button exit;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MyButtonFunction()
    {
       
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                pauseMenu.enabled = false;

                resume.gameObject.SetActive(false);
                mainMenu.gameObject.SetActive(false);
                exit.gameObject.SetActive(false);
            }
            
       



    }
}
