using System;

namespace FlyweightPattern
{
    public class Point
    {
        private int x;
        private int y;
        private PointIcon pointIcon;
       

        public Point(int x, int y, PointIcon pointIcon)
        {
            this.x = x;
            this.y = y;
            this.pointIcon = pointIcon;
        }

        public void Draw()
        {
            Console.WriteLine($"{pointIcon.Type} at ({x}, {y}) {pointIcon.Icon.Length} bytes");
        }
    }

    public enum PointType
    {
        Coffee,
        Bank,
        Hotel
    }
}