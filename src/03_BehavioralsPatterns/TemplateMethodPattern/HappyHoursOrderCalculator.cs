using System;

namespace TemplateMethodPattern
{


    // Happy Hours - 10% upustu w godzinach od 9 do 15
    public class HappyHoursPercentageOrderCalculator : PercentageOrderCalculator
    {
        private readonly TimeSpan from;
        private readonly TimeSpan to;

        public HappyHoursPercentageOrderCalculator(TimeSpan from, TimeSpan to, decimal percentage)
                : base(percentage)
        {
            this.from = from;
            this.to = to;
        }

        public override bool CanDiscount(Order order) => order.OrderDate.TimeOfDay >= from && order.OrderDate.TimeOfDay < to;
        
    }

    public class HappyHoursFixedOrderCalculator : FixedOrderCalculator
    {
        private readonly TimeSpan from;
        private readonly TimeSpan to;

        public HappyHoursFixedOrderCalculator(TimeSpan from, TimeSpan to, decimal amount) : base(amount)
        {
            this.from = from;
            this.to = to;
        }

        public override bool CanDiscount(Order order) => order.OrderDate.TimeOfDay >= from && order.OrderDate.TimeOfDay < to;
    }
}
