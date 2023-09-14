namespace VisitorPattern
{
    public class TextBox : Control
    {
        public string Value { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

  

}
