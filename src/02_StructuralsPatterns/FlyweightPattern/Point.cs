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

    // Flyweight
    public class PointIcon
    {
        public PointType Type { get; set; }
        public byte[] Icon { get; set; }

        public PointIcon(PointType type, byte[] icon)
        {
            this.Type = type;
            this.Icon = icon;
        }
    }

    public enum PointType
    {
        Coffee,
        Bank,
        Hotel
    }
}