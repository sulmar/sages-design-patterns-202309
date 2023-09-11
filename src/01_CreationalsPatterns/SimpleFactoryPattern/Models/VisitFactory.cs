namespace SimpleFactoryPattern
{
    // Factory
    public class VisitFactory
    {
        public static Visit Create(string kind, TimeSpan duration, decimal pricePerHour) 
            => kind switch // Match Patterns
        {
            "N" => new NfzVisit(duration, pricePerHour),
            "P" => new PrivateVisit(duration, pricePerHour),
            "F" => new CompanyVisit(duration, pricePerHour),
            "T" => new TeleVisit(duration, pricePerHour),
            _ => throw new NotSupportedException(),
        };
    }
}
