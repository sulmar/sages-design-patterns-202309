namespace VisitorPattern
{
    // Abstract Element
    public abstract class Control
    {
        public string Name { get; set; }
        public string Caption { get; set; }

        public abstract void Accept(IVisitor visitor);
    }

  

}
