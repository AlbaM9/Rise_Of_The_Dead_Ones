using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEnemyDEstroy : MonoBehaviour
{

    public float secondsToDestroy;
    
    void Start()
    {
        secondsToDestroy = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, secondsToDestroy);
    }
}
