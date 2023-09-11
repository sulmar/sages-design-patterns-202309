namespace SimpleFactoryPattern.Models
{
    public class DarkModeConsoleColorFactory : ConsoleColorFactory
    {
        public override ConsoleColor Create(decimal totalAmount) => totalAmount switch
        {
            0 => ConsoleColor.DarkGreen,
            >= 200 => ConsoleColor.DarkRed,
            _ => ConsoleColor.Black,
        };
    }
}
