namespace StrategyPattern
{
    public class GenderPercentageDiscountStrategy : PercentageDiscountStrategy, IDiscountStrategy
    {
        private readonly Gender gender;

        public GenderPercentageDiscountStrategy(Gender gender, decimal percentage) : base(percentage)
        {
            this.gender = gender;
        }

        public override bool CanDiscount(Order order)
        {
            return order.Customer.Gender == gender;
        }
    }
}
