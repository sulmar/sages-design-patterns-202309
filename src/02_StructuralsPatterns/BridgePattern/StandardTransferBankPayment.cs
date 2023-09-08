using System;

namespace BridgePattern
{
    public class StandardTransferBankPayment
    {
        public decimal Amount { get; set; }

        public void MakeTransfer()
        {
            Console.WriteLine("Autoryzacja za pomocą login i hasła.");

            Console.WriteLine($"Przelew standardowy {Amount}");

        }
    }

}
