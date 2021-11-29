using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CementeryEnter : MonoBehaviour
{
    public Image CementeryTX;
    // Start is called before the first frame update
    void Start()
    {
        CementeryTX.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D target)
    {
        if (target.tag == "Player")
        {

             
            CementeryTX.enabled = true;


        }
    }
    private void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Player")
        {


            CementeryTX.enabled = false;

            Destroy(GameObject.FindWithTag("Cementery"));

        }
    }
}