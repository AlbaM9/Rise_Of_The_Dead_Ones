using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoMainMenu : MonoBehaviour
{

    private int buttonPressed = 0;

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
        }
        
            
            SceneManager.LoadScene("Inicio");
            
        



    }
}
