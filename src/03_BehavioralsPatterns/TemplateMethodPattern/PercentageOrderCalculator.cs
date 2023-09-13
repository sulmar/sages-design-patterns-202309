namespace TemplateMethodPattern
{

    public abstract class OrderCalculator
    {
        public abstract bool CanDiscount(Order order);
        public abstract decimal GetDiscount(Order order);

        public virtual decimal GetNoDiscount()
        {
            return decimal.Zero;
        }

        public decimal CalculateDiscount(Order order)                       // Template Method
        {
            if (CanDiscount(order))                    // Warunek (Predykat)    
            {
                return GetDiscount(order);             // Zniżka (Discount)
            }
            else
                return GetNoDiscount();             // Brak zniżki (NoDiscount)
        }
    }

    public abstract class PercentageOrderCalculator : OrderCalculator
    {
        protected readonly decimal percentage;

        protected PercentageOrderCalculator(decimal percentage)
        {
            this.percentage = percentage;
        }
       
        public override decimal GetDiscount(Order order)
        {
            return order.Amount * percentage;
        }
    }

    public abstract class FixedOrderCalculator : OrderCalculator
    {
        protected readonly decimal amount;

        protected FixedOrderCalculator(decimal amount)
        {
            this.amount = amount;
        }

        public override decimal GetDiscount(Order order)
        {
            return amount;
        }
    }



    

}
