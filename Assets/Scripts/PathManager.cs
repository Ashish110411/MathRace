using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PathManager : MonoBehaviour
{
    public GameObject[] Path;
    public float zSpawn = 0;
    public float TileLength = 21;
    public int numberOfTiles = 1;
    public Transform Player;
    private List<GameObject> ActiveTiles = new List<GameObject>();

    void Start()
    {
        for(int i=0; i<numberOfTiles; i++)
        {
            if(i == 0)
            {
                SpawnTile(0);
            }
            else
                SpawnTile(Random.Range(0, Path.Length));
        }
    }


    void Update()
    {
        if(Player.transform.position.z - 24 > zSpawn - (numberOfTiles * TileLength))
        {
            SpawnTile(Random.Range(0, Path.Length));
            DeleteTile();
        }

    }
    public void SpawnTile(int tileIndex)
    {
        GameObject tile =  Instantiate(Path[tileIndex], transform.forward * zSpawn, transform.rotation,transform);
        ActiveTiles.Add(tile);
        zSpawn += TileLength;
    }
    private void DeleteTile()
    {
        Destroy(ActiveTiles[0]);
        ActiveTiles.RemoveAt(0);
    }
}

