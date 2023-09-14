using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorPattern
{
    // Abstract Visitor
    public interface IVisitor
    {
        void Visit(Form control);
        void Visit(Label control);
        void Visit(BlinkLabel control);
        void Visit(TextBox control);
        void Visit(Checkbox control);
        void Visit(Button control);

        string Output { get; }
    }
}
