namespace InterpreterPattern
{
    public class MultiplyExpression : IExpression
    {
        public void Interpret(Context context) => context.Push(context.Pop() * context.Pop());
    }

}
