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
                BuildTile(positionIndexer, x, y);
                positionIndexer.x += _tileOffset.x;
            }
            positionIndexer.x = _initialPosition.x;
            positionIndexer.y += _tileOffset.y;
        }
    }

    private void BuildTile(Vector2 instantiatePosition, int x, int y)
    {
        var tile = Instantiate(_tilePrefab, instantiatePosition, Quaternion.identity);
        string _naming = "[" + x + "]_[" + y + "]";
        tile.name = _naming;
        tile.Text.text = _naming;
        tile.Node = AddNode(x, y);
    }

    private Node AddNode(int x, int y)
    {
        var node = new Node(x, y);
        Map.AddNode(node);
        return node;
    }
}
