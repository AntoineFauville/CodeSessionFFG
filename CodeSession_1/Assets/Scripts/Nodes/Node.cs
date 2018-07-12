public class Node
{
    private Coordinates _coordinates;

    public int X
    {
        get { return _coordinates.X; }
    }

    public int Y
    {
        get { return _coordinates.Y; }
    }

    public Node(Coordinates coordinates)
    {
        coordinates = _coordinates;
    }
}
