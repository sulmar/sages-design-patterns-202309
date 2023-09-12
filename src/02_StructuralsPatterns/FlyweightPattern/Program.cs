using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Flyweight Pattern!");

            PointFactory pointFactory = new PointFactory(new PointIconFactory());

            var points = pointFactory.Create();

            foreach (var point in points)
            {
                point.Draw();
            }

            // Game game = new Game(TreeFactory.Create());
            //
            // game.Play();
        }
    }

    public class PointIconFactory
    {
        private IDictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();

        public PointIcon Create(PointType pointType)
        {
            if (!icons.ContainsKey(pointType))
            {
                byte[] icon = Get(pointType);

                icons.Add(pointType, new PointIcon(pointType, icon));
            }

            return icons[pointType];

        }
       
        private static byte[] Get(PointType pointType)
        {
            string filename = $"Assets/{pointType.ToString().ToLower()}.png";
            byte[] icon = File.ReadAllBytes(filename);
            return icon;
        }
    }

    public class PointFactory
    {
        private PointIconFactory iconFactory;

        public PointFactory(PointIconFactory iconFactory)
        {
            this.iconFactory = iconFactory;
        }

        public ICollection<Point> Create()
        {           
            var points = new List<Point>
            {
                new Point(1, 2, iconFactory.Create(PointType.Coffee)),
                new Point(10, 20, iconFactory.Create(PointType.Coffee)),
                new Point(15, 25,iconFactory.Create(PointType.Hotel)),
            };

            return points;
        }
    }

    public class TreeFactory
    {
        public static ICollection<Tree> Create()
        {
            ICollection<Tree> trees = new Collection<Tree>
            {
                new Tree(new Mesh(10), new Texture("###"), new Texture("==="), new Vector(10, 30), 30, 1, new Color(200, 100, 50), new Color(100, 100, 100)),
                new Tree(new Mesh(10), new Texture("###"), new Texture("==="), new Vector(20, 15), 30, 1, new Color(200, 100, 50), new Color(100, 100, 100)),
                new Tree(new Mesh(10), new Texture("###"), new Texture("==="), new Vector(40, 30), 30, 1, new Color(200, 100, 50), new Color(100, 100, 100)),
                new Tree(new Mesh(10), new Texture("###"), new Texture("==="), new Vector(60, 30), 30, 1, new Color(200, 100, 50), new Color(100, 100, 100)),
                new Tree(new Mesh(5), new Texture(">>>"), new Texture("<<<"), new Vector(40, 30), 30, 1, new Color(200, 100, 50), new Color(100, 100, 100)),
                new Tree(new Mesh(5), new Texture(">>>"), new Texture("<<<"), new Vector(60, 30), 30, 1, new Color(200, 100, 50), new Color(100, 100, 100)),
            };

            return trees;
        }
    }


    public class Game
    {
        private ICollection<Tree> trees { get; set; }

        public Game(ICollection<Tree> trees)
        {
            this.trees = trees;
        }

        public void Play()
        {
            foreach (var tree in trees)
            {
                tree.Draw();
            }
        }
    }


    public class Tree
    {
        private Mesh mesh;
        private Texture bark;
        private Texture leaves;
        private Vector position;
        private double height;
        private double thickness;
        private Color barkTint;
        private Color leafTint;

        public Tree(Mesh mesh, Texture bark, Texture leaves, Vector position, double height, double thickness, Color barkTint, Color leafTint)
        {
            this.mesh = mesh;
            this.bark = bark;
            this.leaves = leaves;
            this.position = position;
            this.height = height;
            this.thickness = thickness;
            this.barkTint = barkTint;
            this.leafTint = leafTint;
        }

        public void Draw()
        {
            Console.WriteLine($"Tree: mesh: {mesh} bark: {bark} leaves: {leaves} ({position.X}:{position.Y}) leafColor={leafTint}");
        }
    }

    public class Vector
    {
        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Mesh
    {
        public Mesh(int size)
        {
            Size = size;
        }

        public int Size { get; set; }

        public override string ToString() => Size.ToString();
    }

    public class Texture
    {
        public Texture(string content)
        {
            Content = content;
        }

        public string Content { get; set; }

        public override string ToString() => Content;
    }

    public struct Color
    {
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public override string ToString() => $"(R={Red}, G={Green}, B={Blue})";

        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
    }
}
