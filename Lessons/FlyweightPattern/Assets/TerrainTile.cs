/// <summary>
/// Class that holds Terrain tile data for the flyweight pattern
/// </summary>
public class TerrainTile
{

    public TerrainTile(int _moveCost, bool _isWater, UnityEngine.Color _color, string _tileName)
    {
        moveCost = _moveCost;
        isWater = _isWater;
        color = _color;
        tileName = _tileName;
    }
    public readonly int moveCost;
    public readonly bool isWater;
    public readonly UnityEngine.Color color;
    public readonly string tileName;
}