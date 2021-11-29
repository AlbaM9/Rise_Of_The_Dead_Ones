using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NewGame : MonoBehaviour
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
        buttonPressed++;
        if (buttonPressed == 1)
        {
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene("PreludeGame");
            
            
            Time.timeScale = 1;
        }
        
    
    
    }
}
