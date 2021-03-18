using System;

namespace Maze
{
    public enum Direction
    {
        UP = 1,
        DOWN = 2,
        LEFT = 3,
        RIGHT = 4
    }

    public struct ColorRGB
    {
        public byte r { get; }
        public byte g { get; }
        public byte b { get; }
        public ColorRGB(byte red, byte green, byte blue)
        {
            r = red;
            g = green;
            b = blue;
        }

        public override string ToString()
        {
            byte[] arr = {r, g, b};
            return $"#{Convert.ToHexString(arr)}";
        }
    }

    public struct GridPoint
    {
        public int x { get; }
        public int y { get; }

        public GridPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return($"({x}, {y})");
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            GridPoint g = (GridPoint)(obj);

            if (this.x == g.x && this.y == g.y)
                return true;
            else
                return false;
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
