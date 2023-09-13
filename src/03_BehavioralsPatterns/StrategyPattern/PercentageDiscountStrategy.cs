namespace StrategyPattern
{
    public abstract class PercentageDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal percentage;

        protected PercentageDiscountStrategy(decimal percentage)
        {
            this.percentage = percentage;
        }

        public abstract bool CanDiscount(Order order);

        public decimal GetDiscount(Order order)
        {
            return order.Amount * percentage;
        }

        public decimal NoDiscount()
        {
            return 0;
        }
    }


}
