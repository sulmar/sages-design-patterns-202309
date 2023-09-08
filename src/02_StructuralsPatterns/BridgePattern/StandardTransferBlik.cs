using System;

namespace BridgePattern
{
    public class StandardTransferBlik
    {
        public decimal Amount { get; set; }

        public void MakeTransfer()
        {
            Console.WriteLine("Autoryzacja za pomocą kodu BLIK");

            Console.WriteLine($"Przelew standardowy {Amount}");
        }

    }

}
