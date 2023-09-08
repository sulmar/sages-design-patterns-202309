using System;
using System.Collections.Generic;

Console.WriteLine("Hello Flyweight Pattern!");

PointService pointService = new PointService();

var points = pointService.GetAll();

foreach (var point in points)
{
    point.Draw();
}

public class Point
{
    public int X { get; } // 4 bytes
    public int Y { get; } // 4 bytes
    public PointIcon Icon { get; }

    public Point(int x, int y, PointIcon icon)
    {
        this.X = x;
        this.Y = y;
        this.Icon = icon;
    }

    public void Draw() => Console.WriteLine($"{Icon.Type} at ({X},{Y}) {Icon.Icon.Length} bytes");
}

public class PointService
{
    private readonly IEnumerable<Point> points;

    public PointService()
    {
        points = new List<Point>
         {
            new Point(10, 20, new PointIcon(PointType.Cafe, File.ReadAllBytes("cafe.png"))),
            new Point(20, 40, new PointIcon(PointType.Cafe, File.ReadAllBytes("cafe.png"))),
            new Point(25, 35, new PointIcon(PointType.Hotel, File.ReadAllBytes("hotel.png"))),
         };
    }

    public IEnumerable<Point> GetAll()
    {
        return points;
    }
}

public class PointIcon
{
    public PointType Type { get; } // 4 bytes
    public byte[] Icon { get; }  // 2 kb

    public PointIcon(PointType type, byte[] icon)
    {
        this.Type = type;
        this.Icon = icon;
    }
}

public enum PointType
{
    Cafe,
    Hotel
}

