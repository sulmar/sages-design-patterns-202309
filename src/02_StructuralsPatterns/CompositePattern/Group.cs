namespace CompositePattern;

// Abstract Component
public abstract class Component
{
    public string Name { get; set; }    
    public abstract void Render();    

    protected Component(string name)
    {
        Name = name;
    }
}

// Concrete Component B
// Composite
public class Group : Component
{
    private List<Component> components = new List<Component>();

    public Group(string name) : base(name)
    {
    }

    public void Add(Component shape)
    {
        components.Add(shape);
    }

    public override void Render()
    {
        Console.WriteLine($"Render group {Name}");

        foreach (var component in components)
        {
            Console.Write(">");
            component.Render();
        }
    }
}