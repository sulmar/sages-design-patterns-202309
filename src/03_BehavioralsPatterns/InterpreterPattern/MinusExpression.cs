namespace InterpreterPattern
{
    public class MinusExpression : IExpression
    {
        public void Interpret(Context context) => context.Push(-context.Pop() + context.Pop());
    }

}
