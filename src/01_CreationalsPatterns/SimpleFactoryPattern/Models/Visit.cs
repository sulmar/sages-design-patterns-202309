using System;

namespace SimpleFactoryPattern
{

    // Concrete Product A
    public class NfzVisit : Visit
    {
        public NfzVisit(TimeSpan duration, decimal pricePerHour) : base(duration, pricePerHour)
        {
        }

        public override decimal CalculateCost()
        {
            return decimal.Zero;
        }
    }

    // Concrete Product B
    public class PrivateVisit : Visit
    {
        public PrivateVisit(TimeSpan duration, decimal pricePerHour) : base(duration, pricePerHour)
        {
        }

        public override decimal CalculateCost()
        {
            return (decimal)Duration.TotalHours * PricePerHour;
        }
    }

    // Concrete Product C
    public class CompanyVisit : Visit
    {
        private const decimal companyDiscountPercentage = 0.9m;

        public CompanyVisit(TimeSpan duration, decimal pricePerHour) : base(duration, pricePerHour)
        {
        }

        public override decimal CalculateCost()
        {
            return (decimal)Duration.TotalHours * PricePerHour * companyDiscountPercentage;
        }
    }


    // Factory
    public class VisitFactory
    {
        public static Visit Create(string kind, TimeSpan duration, decimal pricePerHour)
        {
            if (kind == "N")
                return new NfzVisit(duration, pricePerHour);
            else if (kind == "P")
                return new PrivateVisit(duration, pricePerHour);
            else if (kind == "F")
                return new CompanyVisit(duration, pricePerHour);

            throw new NotSupportedException();
        }
    }

    // Abstract Product

    public abstract class Visit
    {
        public DateTime VisitDate { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal PricePerHour { get; set; }

        

        public Visit(TimeSpan duration, decimal pricePerHour)
        {
            VisitDate = DateTime.Now;
            Duration = duration;
            PricePerHour = pricePerHour;
        }

        public abstract decimal CalculateCost();        
    }
}
