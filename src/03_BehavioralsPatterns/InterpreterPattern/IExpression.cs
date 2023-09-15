namespace InterpreterPattern
{
    // Abstract Expression
    public interface IExpression
    {
        void Interpret(Context context);
    }

}
