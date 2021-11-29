using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
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

       
        
            Time.timeScale = 1;
            
        
        SceneManager.LoadScene("SampleScene");





    }
}
