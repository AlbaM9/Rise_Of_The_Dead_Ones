using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadButton : MonoBehaviour
{
    
    public Letter letter;
    private int buttonPressed = 0;
  

    void Start()
    {
        letter = FindObjectOfType<Letter>();
      
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
            
            Destroy(this.gameObject);
            letter.LetterAnim();
            
        }
    }
    
}
