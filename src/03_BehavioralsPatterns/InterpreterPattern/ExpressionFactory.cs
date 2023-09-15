namespace InterpreterPattern
{
    public class ExpressionFactory
    {
        public IExpression Create(string token) =>
            token switch
            {
                "+" => new PlusExpression(),
                "-" => new MinusExpression(),
                "*" => new MultiplyExpression(),
                _ => new NumberExpression(int.Parse(token))
            };
    }

}
