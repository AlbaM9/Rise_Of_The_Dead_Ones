using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NecromPages : MonoBehaviour
{
    
    public PlayerStats necro;
    
    
    

    void Start()
    {
        necro = FindObjectOfType<PlayerStats>();

        
       // ElimPages();

    }
   
   // Update is called once per frame
   void Update()
    {


       
        
    }
    public void ElimPages() 
    {

        if (necro.have1 == 1)
        {
            Destroy(GameObject.FindWithTag("1"));
        }
        if (necro.have2 == 1)
        {
            Destroy(GameObject.FindWithTag("2"));
        }
        if (necro.have3 == 1)
        {
            Destroy(GameObject.FindWithTag("3"));
        }
        if (necro.have4 == 1)
        {
            Destroy(GameObject.FindWithTag("4"));
        }
        if (necro.have5 == 1)
        {
            Destroy(GameObject.FindWithTag("5"));
        }
        if (necro.have6 == 1)
        {
            Destroy(GameObject.FindWithTag("6"));
        }
        if (necro.have7 == 1)
        {
            Destroy(GameObject.FindWithTag("7"));
        }
        if (necro.have8 == 1)
        {
            Destroy(GameObject.FindWithTag("8"));
        }
        if (necro.have9 == 1)
        {
            Destroy(GameObject.FindWithTag("9"));
        }
        if (necro.have10 == 1)
        {
            Destroy(GameObject.FindWithTag("10"));
        }


    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Player"))
        {
            entryPages();
        }
    }
    public void entryPages() 
    {

        if (CompareTag ("1"))
        {

            Destroy(this.gameObject);
            necro.have1 = 1;
            

        }
        if (CompareTag("2"))
        {
            necro.have2 = 1;
            Destroy(this.gameObject);


        }
        if (CompareTag("3"))
        {

            Destroy(this.gameObject);
            necro.have3 = 1;
        }
        if (CompareTag("4"))
        {


            Destroy(this.gameObject);
            necro.have4 = 1;
        }
        if (CompareTag("5"))
        {


            Destroy(this.gameObject);
            necro.have5 = 1;
        }
        if (CompareTag("6"))
        {


            Destroy(this.gameObject);
            necro.have6= 1;
        }
        if (CompareTag("7"))
        {


            Destroy(this.gameObject);
            necro. have7 = 1;
        }
        if (CompareTag("8"))
        {


            Destroy(this.gameObject);
            necro.have8 = 1;
        }
        if (CompareTag("9"))
        {


            Destroy(this.gameObject);
            necro.have9 = 1;
        }
        if (CompareTag("10"))
        {


            Destroy(this.gameObject);
            necro.have10 = 1;
        }

        necro.necromiconPages += 1;
    }

}


