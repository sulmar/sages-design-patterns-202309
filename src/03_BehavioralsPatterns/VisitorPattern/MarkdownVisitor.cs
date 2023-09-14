namespace VisitorPattern
{
    public class MarkdownVisitor : IVisitor
    {
        public string Output => throw new System.NotImplementedException();

        public void Visit(Form control)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(Label control)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(TextBox control)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(Checkbox control)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(Button control)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(BlinkLabel control)
        {
            throw new System.NotImplementedException();
        }
    }
}
