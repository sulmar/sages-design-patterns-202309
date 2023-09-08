using System;

namespace BridgePattern
{
    public class TaxTransferBlik
    {
        public decimal Amount { get; set; }

        public void MakeTransfer()
        {
            Console.WriteLine("Autoryzacja za pomocą kodu BLIK");

            Console.WriteLine($"Przelew podatkowy {Amount}");
        }
    }

}
