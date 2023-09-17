using System;

namespace HW10
{
    public struct Point
    {
        public int x, y;
        public Point(int x, int y)
        { this.x = x; this.y = y; }
        public override string ToString() => $"({x},{y})";
        public double Distance(Point p) => Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
    }
}