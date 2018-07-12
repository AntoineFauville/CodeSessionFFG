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

    private static Dictionary<CardinalDirection, Coordinates> _directions = new Dictionary<CardinalDirection, Coordinates>()
    {
        { CardinalDirection.North, Coordinates.North},
        { CardinalDirection.East, Coordinates.East },
        { CardinalDirection.South, Coordinates.South },
        { CardinalDirection.West, Coordinates.West }
    };

    public List<Node> GetNeighbours(Node node)
    {
        List<Node> neighbours = new List<Node>();

        foreach (var direction in _directions.Values)
        {
            int neighbourX = node.X + direction.X;
            int neighbourY = node.Y + direction.Y;
            Node neighbour = GetNodeByCoordinates(neighbourX, neighbourY);

            if (neighbour != null)
            {
                neighbours.Add(neighbour);
                Debug.Log("Neighbour " + neighbour.X + " " + neighbour.Y + " Has been added");
            }
        }

        return neighbours;
    }

    public Node GetNodeByCoordinates(int x, int y)
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