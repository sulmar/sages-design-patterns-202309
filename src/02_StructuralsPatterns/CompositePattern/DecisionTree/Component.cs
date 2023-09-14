using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.DecisionTree
{
    public interface IVisitor
    {
        void Visit(Question question);
        void Visit(Decision decision);
    }

    public class TextVisitor : IVisitor
    {
        public void Visit(Question question)
        {
            throw new NotImplementedException();
        }

        public void Visit(Decision decision)
        {
            throw new NotImplementedException();
        }
    }

    // Abstract Component
    public abstract class Node
    {
        public string Content {  get; set; }

        protected Node(string content)
        {
            Content = content;
        }

        public abstract void Operation();

        public abstract void Accept(IVisitor visitor);
        
    }

    // Concrete Component
    // Composite
    public class Question : Node
    {
        public Node PositiveResponse { get; set; }
        public Node NegativeResponse { get; set; } 

        public Question(string content, Node positiveResponse, Node negativeResponse) : base(content)
        {
            PositiveResponse = positiveResponse;
            NegativeResponse = negativeResponse;
        }

        public override void Operation()
        {
            Console.Write(Content);

            if (Response)
            {
                PositiveResponse.Operation();
            }
            else
            {
                NegativeResponse.Operation();
            }
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public static bool Response => Console.ReadKey().Key == ConsoleKey.Y;
    }

    // Leaf
    public class Decision : Node
    {
        public Decision(string content) : base(content)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Operation()
        {
            Console.WriteLine(Content);
        }
    }


}
