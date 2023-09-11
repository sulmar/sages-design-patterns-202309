namespace SimpleFactoryPattern
{
    // Concrete Product B
    public class PrivateVisit : Visit
    {
        public override decimal CalculateCost()
        {
            return (decimal)Duration.TotalHours * PricePerHour;
        }
    }
}
