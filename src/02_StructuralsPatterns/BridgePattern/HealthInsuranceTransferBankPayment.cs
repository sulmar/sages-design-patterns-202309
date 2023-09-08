using System;

namespace BridgePattern
{
    public class HealthInsuranceTransferBankPayment
    {
        public decimal Amount { get; set; }

        public void MakeTransfer()
        {
            Console.WriteLine("Autoryzacja za pomocą loginu i hasła.");

            Console.WriteLine($"Przelew składki zdrowotnej {Amount}");
        }
    }

}
