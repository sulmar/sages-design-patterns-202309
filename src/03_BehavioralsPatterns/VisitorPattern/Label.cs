namespace VisitorPattern
{
    // Concrete Element
    public class Label : Control
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }


    public class BlinkLabel : Label
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

  

}
