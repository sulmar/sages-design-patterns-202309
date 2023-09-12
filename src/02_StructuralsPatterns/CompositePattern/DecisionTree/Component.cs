using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.DecisionTree
{
    // Abstract Component
    public abstract class Node
    {
        public string Content {  get; set; }

        protected Node(string content)
        {
            Content = content;
        }

        public abstract void Operation();
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

        public static bool Response => Console.ReadKey().Key == ConsoleKey.Y;
    }

    // Leaf
    public class Decision : Node
    {
        public Decision(string content) : base(content)
        {
        }

        public override void Operation()
        {
            Console.WriteLine(Content);
        }
    }


}
