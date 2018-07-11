using System.Collections.Generic;
using UnityEngine;

public class Map
{
    private readonly List<Node> _grid = new List<Node>();

    public List<Node> Grid
    {
        get { return _grid; }
    }

    public void AddNode(Node node)
    {
        _grid.Add(node);
    }

    private static Dictionary<CardinalDirection, IntVector2> _directions = new Dictionary<CardinalDirection, IntVector2>()
    {
        { CardinalDirection.North, IntVector2.Up },
        { CardinalDirection.East, IntVector2.Right },
        { CardinalDirection.South, IntVector2.Down },
        { CardinalDirection.West, IntVector2.Left }
    };

    public List<Node> GetNeighbours(Node node)
    {
        List<Node> neighbours = new List<Node>();

        foreach (var direction in _directions.Values)
        {
            int neighbourX = node.X + direction.x;
            int neighbourY = node.Y + direction.y;
            Node neighbour = GetNode(neighbourX, neighbourY);

            if (neighbour != null)
            {
                neighbours.Add(neighbour);
                Debug.Log("Neighbour " + neighbour.X + " " + neighbour.Y + " Has been added");
            }
        }

        return neighbours;
    }

    public Node GetNode(int x, int y)
    {
        foreach (Node node in _grid)
        {
            if (node.X == x && node.Y == y)
            {
                return node;
            }
        }

        return null;
    }
}