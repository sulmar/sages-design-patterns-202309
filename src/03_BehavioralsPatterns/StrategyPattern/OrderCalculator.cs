namespace StrategyPattern
{

  
    public class OrderCalculator
    {
        private ICanDiscountStrategy canDiscountStrategy;
        private ICalculateDiscountStrategy calculateDiscountStrategy;

        public OrderCalculator(
            ICanDiscountStrategy canDiscountStategy, 
            ICalculateDiscountStrategy calculateDiscountStrategy)
        {
            this.canDiscountStrategy = canDiscountStategy;
            this.calculateDiscountStrategy = calculateDiscountStrategy;
        }

        public decimal CalculateDiscount(Order order)
        {
            if (canDiscountStrategy.CanDiscount(order))                // Warunek (Predicate)
            {
                return calculateDiscountStrategy.GetDiscount(order);         // GetDiscount
            }
            else
                return calculateDiscountStrategy.NoDiscount();               // NoDiscount
        }
    }
}
