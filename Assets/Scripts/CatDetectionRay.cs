using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatDetectionRay : MonoBehaviour
{


    public EnemyMovement1 fliped;
    void Start()
    {
        fliped = FindObjectOfType<EnemyMovement1>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Ray ray = new Ray(transform.position,  transform.forward);
        //Length of the ray
        float laserLength = 50f;
       
        //Get the first object hit by the ray
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, laserLength);

        //If the collider of the object hit is not NUll
        if (hit.collider != null)
        {
            //Hit something, print the tag of the object
            Debug.Log("Hitting: " + hit.collider.tag);
        }

        //Method to draw the ray in scene for debug purpose
        Debug.DrawRay(transform.position, Vector2.right * laserLength, Color.blue);
    }
}
