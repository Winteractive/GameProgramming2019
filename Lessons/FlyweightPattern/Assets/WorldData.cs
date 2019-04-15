using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that creates and holds the references to the terrainTiles the flyweight pattern uses
/// </summary>
public class WorldData : MonoBehaviour
{

    public static TerrainTile grass;
    public static TerrainTile water;
    public static TerrainTile dirt;

    void Awake()
    {
        grass = new TerrainTile(2, false, new Color(0.05f, 1, 0.15f), "Grass");
        water = new TerrainTile(4, true, new Color(0.1f, 0.05f, 1), "Water");
        dirt = new TerrainTile(2, false, new Color(0.8f, 0.25f, 0.25f), "Dirt");
    }


}
