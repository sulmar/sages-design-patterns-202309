using System.Text;

namespace VisitorPattern
{


    // Concrete Visitor
    public class HtmlVisitor : IVisitor
    {
        private readonly StringBuilder builder = new StringBuilder();

        public void Visit(Label control)
        {
            builder.AppendLine($"<span>{control.Caption}</span>");
        }

        public void Visit(TextBox control)
        {
            builder.AppendLine($"<span>{control.Caption}</span><input type='text' value='{control.Value}'></input>");
        }

        public void Visit(Checkbox control)
        {
            builder.AppendLine($"<span>{control.Caption}</span><input type='checkbox' value='{control.Value}'></input>");
        }

        public void Visit(Button control)
        {
            builder.AppendLine($"<button><img src='{control.ImageSource}'/>{control.Caption}</button>");
        }

        public void Visit(Form control)
        {
            builder.AppendLine("<html>");
            builder.AppendLine($"<title>{control.Title}</title>");
            builder.AppendLine("<body>");

            foreach (Control child in control.Body)
            {
                child.Accept(this);
            }

            builder.AppendLine("</body>");
            builder.AppendLine("</html>");



        }

        public void Visit(BlinkLabel control)
        {
            builder.AppendLine($"<span class='blink'>{control.Caption}</span>");
        }

        public string Output => builder.ToString();
    }
}
