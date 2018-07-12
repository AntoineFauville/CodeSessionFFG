public struct Coordinates
{
    public int X;
    public int Y;

    public Coordinates(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Coordinates North
    {
        get
        {
            return new Coordinates(0, 1);
        }
    }

    public static Coordinates South
    {
        get
        {
            return new Coordinates(0, -1);
        }
    }

    public static Coordinates East
    {
        get
        {
            return new Coordinates(1, 0);
        }
    }

    public static Coordinates West
    {
        get
        {
            return new Coordinates(-1, 0);
        }
    }
}
