namespace SimpleFactoryPattern
{
    // Concrete Product C
    public class CompanyVisit : Visit
    {
        private const decimal companyDiscountPercentage = 0.9m;

        public override decimal CalculateCost()
        {
            return (decimal)Duration.TotalHours * PricePerHour * companyDiscountPercentage;
        }
    }
}
