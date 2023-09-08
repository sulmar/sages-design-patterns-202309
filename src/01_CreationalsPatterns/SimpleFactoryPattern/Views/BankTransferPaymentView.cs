using System;

namespace SimpleFactoryPattern
{
    public class BankTransferPaymentView : PaymentView
    {
        public override void Show(Payment payment)
        {
            Console.WriteLine($"Dane do przelewu {payment.TotalAmount}");
        }
    }


}
