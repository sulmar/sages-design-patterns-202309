namespace StrategyPattern
{
    public class FixedDiscountStrategy : ICalculateDiscountStrategy
    {
        private readonly decimal amount;

        protected FixedDiscountStrategy(decimal amount) => this.amount = amount;
        public decimal GetDiscount(Order order) => amount;
        public decimal NoDiscount() => 0;
    }


}
