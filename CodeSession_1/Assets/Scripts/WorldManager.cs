using UnityEngine;

public class WorldManager : MonoBehaviour {

    [SerializeField] private int _rows;
    [SerializeField] private int _colomns;

    [SerializeField] private Vector2 _initialPosition;
    [SerializeField] private Vector2 _offSetTile;

    [SerializeField] private GameObject _PrefabTile;
    [SerializeField] private GameObject _TileParent;

    public void BuildWorld()
    {
        Vector2 _positionTile = _initialPosition;

        for (int y = 0; y < _colomns; y++)
        {
            for (int x = 0; x < _rows; x++)
            {
                InstantiateTile(_positionTile,x,y);
                _positionTile.x += _offSetTile.x;
            }
            _positionTile.x = _initialPosition.x;
            _positionTile.y += _offSetTile.y;
        }
	}

    private void InstantiateTile(Vector2 instantiatedTilePosition, int row, int colomn)
    {
        GameObject _tile;
        _tile = Instantiate(_PrefabTile, instantiatedTilePosition, Quaternion.Euler(0, 0, 0));
        _tile.transform.SetParent(_TileParent.transform);
        _tile.name = "_Tile_" + row + "_" + colomn;
    }
}
