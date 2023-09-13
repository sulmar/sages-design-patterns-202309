namespace StrategyPattern
{
    public class PercentageDiscountStrategy : ICalculateDiscountStrategy
    {
        private readonly decimal percentage;
        public PercentageDiscountStrategy(decimal percentage) => this.percentage = percentage;
        public decimal GetDiscount(Order order) => order.Amount * percentage;
        public decimal NoDiscount() => 0;
    }


}
