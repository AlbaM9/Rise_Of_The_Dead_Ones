using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipScene : MonoBehaviour
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
            SceneManager.LoadScene("SampleScene");
        }



    }
}
