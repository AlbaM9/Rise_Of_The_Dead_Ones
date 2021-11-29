using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WoodsEnter : MonoBehaviour
{
    public Image woodsTx;
    // Start is called before the first frame update
    void Start()
    {
      woodsTx .enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D target)
    {
        if (target.tag == "Player")
        {


           woodsTx.enabled = true;


        }
    }
    private void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Player")
        {


            woodsTx.enabled = false;
            Destroy(GameObject.FindWithTag("WoodsEnter"));

        }
    }
}
