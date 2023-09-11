namespace SimpleFactoryPattern
{
    // Concrete Product A
    public class NfzVisit : Visit
    {
        public override decimal CalculateCost()
        {
            return decimal.Zero;
        }
    }
}
