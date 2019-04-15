using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// basic player character class that traverses the world grid
/// </summary>
public class Player : MonoBehaviour
{
    public bool hasBoat;
    public int movementPoints;
    public int x;
    public int y;

    private void Start()
    {
        movementPoints = 100;
        x = 0;
        y = 0;
        transform.position = Vector3Int.right * x + Vector3Int.up * y;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            TryMove(x, y + 1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            TryMove(x - 1, y);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            TryMove(x, y - 1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            TryMove(x + 1, y);
        }
    }

    /// <summary>
    /// Checks if the player has enough movement points and then moves to the selected tile.
    /// </summary>
    /// <param name="_x">x position on grid to walk to</param>
    /// <param name="_y">y position on grid to walk to</param>
    private void TryMove(int _x, int _y)
    {
        TerrainTile moveToTile = WorldHolder.INSTANCE.world[_x, _y];
        if (moveToTile == null)
        {
            return;
        }
        if (moveToTile.isWater && !hasBoat)
        {
            return;
        }
        if (movementPoints - moveToTile.moveCost >= 0)
        {
            x = _x;
            y = _y;
            movementPoints -= moveToTile.moveCost;
            transform.position = Vector3Int.right * x + Vector3Int.up * y;
            Debug.Log("Stepped onto: " + moveToTile.tileName);
        }
    }









}
