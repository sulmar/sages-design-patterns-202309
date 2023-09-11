using System;

namespace SimpleFactoryPattern
{

    // Abstract Product
    public abstract class Visit
    {
        public DateTime VisitDate { get; private set; }
        public TimeSpan Duration { get; set; }
        public decimal PricePerHour { get; set; }

        public Visit()
        {
            VisitDate = DateTime.Now;
        }

        public abstract decimal CalculateCost();
    }
}
