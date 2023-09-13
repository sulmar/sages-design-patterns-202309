namespace StrategyPattern
{
    public class OrderCalculator
    {
        private IDiscountStrategy discountStrategy;

        public OrderCalculator(IDiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }

        public decimal CalculateDiscount(Order order)
        {
            if (discountStrategy.CanDiscount(order))                // Warunek (Predicate)
            {
                return discountStrategy.GetDiscount(order);         // GetDiscount
            }
            else
                return discountStrategy.NoDiscount();               // NoDiscount
        }
    }
}
