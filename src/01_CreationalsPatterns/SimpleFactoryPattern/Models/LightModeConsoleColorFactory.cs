namespace SimpleFactoryPattern.Models
{
    public class LightModeConsoleColorFactory : ConsoleColorFactory
    {
        public override ConsoleColor Create(decimal totalAmount) => totalAmount switch
        {
            0 => ConsoleColor.Green,
            >= 200 => ConsoleColor.Red,
            _ => ConsoleColor.White,
        };
    }
}
