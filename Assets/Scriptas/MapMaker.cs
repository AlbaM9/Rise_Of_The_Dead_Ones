using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapMaker : MonoBehaviour
{
    public Tile floor;
   
    public Tilemap Level1;
   

    public int mapWidth;
    public int mapHeight;

    private int[,] mapData;

    public CelularData cell;

    void Start()
    {
        this.mapData = this.cell.GenerateData(this.mapWidth,this.mapHeight);

        this.GenerateTiles();
    }

    void GenerateTiles() 
    {
        for (int i = 0; i < this.mapWidth; i++)
        {
            for (int j = 0; j < this.mapHeight; j++)
            {
                if (this.mapData[i,j] == 1)
                {
                    this.Level1.SetTile(

                        new Vector3Int(i, j, 0),
                
                        this.floor

                    );


                }
               
            }
        }
    }
   
    void Update()
    {
       
    }
}
