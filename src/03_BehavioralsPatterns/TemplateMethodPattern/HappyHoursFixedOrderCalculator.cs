using System;

namespace TemplateMethodPattern
{
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
