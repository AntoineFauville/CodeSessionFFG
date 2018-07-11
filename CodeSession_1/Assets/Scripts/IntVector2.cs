namespace UnityEngine
{
    public struct IntVector2
    {
        public int x;
        public int y;

        public IntVector2 (int X, int Y)
        {
            y = Y;
            x = X;
        }

        public static IntVector2 Right
        {
            get
            {
                return new IntVector2(1, 0);
            }
            
        }
        public static IntVector2 Up
        {
            get
            {
                return new IntVector2(0, 1);
            }
        }
        public static IntVector2 Down
        {
            get
            {
                return new IntVector2(0, -1);
            }
        }
        public static IntVector2 Left
        {
            get
            {
                return new IntVector2(-1, 0);
            }
        }
    }
}