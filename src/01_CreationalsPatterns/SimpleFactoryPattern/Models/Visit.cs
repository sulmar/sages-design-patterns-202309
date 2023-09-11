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


    public class TeleVisit : Visit
    {
        public TeleVisit(TimeSpan duration, decimal pricePerHour) : base(duration, pricePerHour)
        {
        }

        public override decimal CalculateCost()
        {
            return 10;
        }
    }


    // Factory
    public class VisitFactory
    {
        public static Visit Create(string kind, TimeSpan duration, decimal pricePerHour)
        {
            switch (kind)
            {
                case "N":
                    return new NfzVisit(duration, pricePerHour);
                case "P":
                    return new PrivateVisit(duration, pricePerHour);
                case "F":
                    return new CompanyVisit(duration, pricePerHour);
                case "T":
                    return new TeleVisit(duration, pricePerHour);

                default:
                    throw new NotSupportedException();
            }
            
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
