using System;

namespace BridgePattern
{
    public class HealthInsuranceTransferCreditCard
    {
        public decimal Amount { get; set; }

        public void MakeTransfer()
        {
            Console.WriteLine("Autoryzacja za pomocą PIN");

            Console.WriteLine($"Przelew składki zdrowotnej {Amount}");
        }
    }

}
