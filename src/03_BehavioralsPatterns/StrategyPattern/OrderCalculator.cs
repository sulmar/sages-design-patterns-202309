namespace StrategyPattern
{

  
    public class OrderCalculator
    {
        private ICanDiscountStrategy canDiscountStategy;
        private ICalculateDiscountStrategy calculateDiscountStrategy;

        public OrderCalculator(
            ICanDiscountStrategy canDiscountStategy, 
            ICalculateDiscountStrategy calculateDiscountStrategy)
        {
            this.canDiscountStategy = canDiscountStategy;
            this.calculateDiscountStrategy = calculateDiscountStrategy;
        }

        public decimal CalculateDiscount(Order order)
        {
            if (canDiscountStategy.CanDiscount(order))                // Warunek (Predicate)
            {
                return calculateDiscountStrategy.GetDiscount(order);         // GetDiscount
            }
            else
                return calculateDiscountStrategy.NoDiscount();               // NoDiscount
        }
    }
}
