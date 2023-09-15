using System;
using System.Collections;
using System.Collections.Generic;

namespace InterpreterPattern
{
    public class Parser
    {
        private IList<IExpression> parseTree = new List<IExpression>();


        private string[] Tokenize(string s) => s.Split(' ');

        // 2 * (3 + 1)

        private void Parse(string s)
        {
            var tokens = Tokenize(s);
            var factory = new ExpressionFactory();

            foreach (var token in tokens)
            {
                parseTree.Add(factory.Create(token));
            }
        }

        // 2 3 1 + *
        public int Evaluate(string s)
        {
            Parse(s);

            var context = new Context();
            

            foreach (var expression in parseTree)
            {
                expression.Interpret(context);
            }

            return context.Pop();
        }
    }

}
