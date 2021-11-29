using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Transform room;

    public static CameraController instance;

    [Range(-5, 5)]
    public float minModX, maxModX, minModY, maxModY;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        Time.timeScale = 1;
    }

  
    void Update()
    {
        var minPosY = room.GetComponent<BoxCollider2D>().bounds.min.y + minModY;
        var maxPosY = room.GetComponent<BoxCollider2D>().bounds.max.y + maxModY;
        var minPosX = room.GetComponent<BoxCollider2D>().bounds.min.x + minModX;
        var maxPosX = room.GetComponent<BoxCollider2D>().bounds.max.x + maxModX;

        Vector3 clampPos = new Vector3(
            Mathf.Clamp(player.position.x, minPosX, maxPosX),
            Mathf.Clamp(player.position.y, minPosY, maxPosY),
            Mathf.Clamp(player.position.z, -64f,-64f)
            );


        transform.position = new Vector3(clampPos.x, clampPos.y, clampPos.z);
    }
}
