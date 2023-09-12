namespace CompositePattern;

// Concrete Component A
// Leaf
public class Shape : Component
{
    public Shape(string name) : base(name)
    {
    }

    public override void Render()
    {
        Console.WriteLine($"Render shape {Name}");
    }
}