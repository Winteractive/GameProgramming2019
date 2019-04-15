using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// static class holding all orthogonal directions as vector3int, how to access them and their mirror
/// </summary>
public static class Directions
{
    public enum Direction { Up, Down, Left, Right };
    public static Dictionary<Direction, Vector3Int> DirectionDictionary = new Dictionary<Direction, Vector3Int>()
    {
        {Direction.Up,Vector3Int.up },
        {Direction.Down,Vector3Int.down },
        {Direction.Left,Vector3Int.left },
        {Direction.Right,Vector3Int.right },
    };

    /// <summary>
    /// Fetches the corresponding dictionary value from the given key
    /// </summary>
    /// <param name="directionReference">the key (Direction enum) </param>
    /// <returns>Vector3int from the dictionary</returns>
    public static Vector3Int GetDirection(Direction directionReference)
    {
        return DirectionDictionary[directionReference];
    }

    /// <summary>
    /// Fetches the mirrored dictionary value from the given key
    /// </summary>
    /// <param name="directionReference">the key (Direction enum) </param>
    /// <returns>the corresponding vector3int *= -1</returns>
    public static Vector3Int GetMirroredDirection(Direction directionReference)
    {
        return DirectionDictionary[directionReference] * -1;
    }
}
