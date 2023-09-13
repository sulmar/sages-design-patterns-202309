using System;

namespace TemplateMethodPattern
{
    public class SpecialDateOrderCalculator : PercentageOrderCalculator
    {
        private readonly DateTime when;

        public SpecialDateOrderCalculator(DateTime when, decimal percentage) : base(percentage)
        {
            this.when = when;
        }

        public override bool CanDiscount(Order order) => order.OrderDate == when;
    }
}
