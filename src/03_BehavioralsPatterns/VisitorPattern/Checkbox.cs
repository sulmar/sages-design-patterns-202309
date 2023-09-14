namespace VisitorPattern
{
    public class Checkbox : Control
    {
        public bool Value { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

  

}
