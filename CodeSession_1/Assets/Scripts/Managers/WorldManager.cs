using UnityEngine;

public class WorldManager : MonoBehaviour
{

    [SerializeField] private int _rows;
    [SerializeField] private int _columns;

    [SerializeField] private Vector2 _tileOffset;
    [SerializeField] private Vector2 _initialPosition;

    [SerializeField] private Tile _tilePrefab;

    public Map Map;

    public void BuildWorld()
    {
        Map = new Map();
        PopulateMap();
    }

    private void PopulateMap()
    {
        Vector2 positionIndexer = _initialPosition;

        for (int y = 0; y < _rows; y++)
        {
            for (int x = 0; x < _columns; x++)
            {
                Coordinates coordinates = new Coordinates(x,y);

                BuildTile(positionIndexer, coordinates);
                positionIndexer.x += _tileOffset.x;
            }
            positionIndexer.x = _initialPosition.x;
            positionIndexer.y += _tileOffset.y;
        }
    }

    private void BuildTile(Vector2 instantiatePosition, Coordinates coordinates)
    {
        var tile = Instantiate(_tilePrefab, instantiatePosition, Quaternion.identity);
        string _naming = "[" + coordinates.X + "]_[" + coordinates.Y + "]";
        tile.name = _naming;
        tile.Text.text = _naming;
        tile.Node = AddNode(coordinates);
    }

    private Node AddNode(Coordinates coordinates)
    {
        var node = new Node(coordinates);
        Map.AddNode(node);
        return node;
    }
}
