using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Letter : MonoBehaviour
    
    
{

    public Image letterTx;
    Animator anim;
    
    public GameObject bottomLetter;
    public Button skip;

    // Start is called before the first frame update
    void Start()
    {
       
        anim = GetComponent<Animator>();
        letterTx.enabled = false;
        skip.interactable = false;

    }

    // Update is called once per frame
    void Update()
    {
        
        



    }
    public void LetterAnim() 
    {

        skip.interactable = true;
        letterTx.enabled = true;
        Destroy(this.gameObject);
        Instantiate(bottomLetter, transform.position, Quaternion.identity);
        




    }
}
