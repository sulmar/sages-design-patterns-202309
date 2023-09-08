using System;

namespace BridgePattern
{
    public class StandardTransferCreditCard
    {
        public decimal Amount { get; set; }

        public void MakeTransfer()
        {
            Console.WriteLine("Autoryzacja za pomocą PIN");

            Console.WriteLine($"Przelew standardowy {Amount}");
        }
    }

}
