using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Class that holds the 2d array of the world and instantiates it.
/// </summary>
public class WorldHolder : MonoBehaviour
{

    public TerrainTile[,] world;
    public GameObject tile_prefab;

    public static WorldHolder INSTANCE;

    private void Awake()
    {
        INSTANCE = this;
    }

    void Start()
    {

        world = new TerrainTile[50, 50];
        for (int x = 0; x < world.GetLength(0); x++)
        {
            for (int y = 0; y < world.GetLength(1); y++)
            {
                float randVal = Random.value;
                if (randVal < 0.33f)
                {
                    world[x, y] = WorldData.grass;
                }
                else if (randVal < 0.66f)
                {
                    world[x, y] = WorldData.water;
                }
                else
                {
                    world[x, y] = WorldData.dirt;
                }

                GameObject newTile = Instantiate(tile_prefab);
                newTile.GetComponent<SpriteRenderer>().color = world[x, y].color;
                newTile.transform.position = Vector3Int.right * x + Vector3Int.up * y;
                newTile.transform.SetParent(this.transform, true);
            }
        }
    }
}
