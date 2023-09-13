using System;

namespace StrategyPattern
{
    public class HappyHoursPercentageDiscountStrategy : PercentageDiscountStrategy, IDiscountStrategy
    {
        private readonly TimeSpan from;
        private readonly TimeSpan to;

        public HappyHoursPercentageDiscountStrategy(TimeSpan from, TimeSpan to, decimal percentage)
            : base(percentage) 
        {
            this.from = from;
            this.to = to;            
        }

        public override bool CanDiscount(Order order)
        {
            return order.OrderDate.TimeOfDay >= from && order.OrderDate.TimeOfDay <= to;
        }      
    }

   
}
