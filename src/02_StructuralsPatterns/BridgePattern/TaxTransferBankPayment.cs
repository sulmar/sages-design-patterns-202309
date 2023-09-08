using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{

    public class TaxTransferBankPayment
    {
        public decimal Amount { get; set; }

        public void MakeTransfer()
        {
            Console.WriteLine("Autoryzacja za pomocą loginu i hasła.");

            Console.WriteLine($"Przelew podatkowy {Amount}");
        }
    }

}
