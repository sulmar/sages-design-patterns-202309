using System;

namespace PrototypePattern
{
    public class InvoiceDetail : ICloneable
    {
        public InvoiceDetail(Product product, int quantity = 1)
        {
            Product = product;
            Quantity = quantity;
            Amount = product.UnitPrice;
        }

        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }

        public override string ToString()
        {
            return $"- {Product} {Quantity} {Amount:C2}";
        }

        private InvoiceDetail Copy()
        {
            var invoiceDetailCopy = new InvoiceDetail(Product, Quantity);
            invoiceDetailCopy.Amount = Amount;

            return invoiceDetailCopy;
        }

        public object Clone()
        {
            return Copy();
        }
    }


}
