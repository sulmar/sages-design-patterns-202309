namespace SimpleFactoryPattern
{
    // Factory
    public class VisitFactory
    {
        public static Visit Create(string kind) 
            => kind switch // Match Patterns
        {
            "N" => new NfzVisit(),
            "P" => new PrivateVisit(),
            "F" => new CompanyVisit(),
            "T" => new TeleVisit(),
            _ => throw new NotSupportedException(),
        };
    }
}
