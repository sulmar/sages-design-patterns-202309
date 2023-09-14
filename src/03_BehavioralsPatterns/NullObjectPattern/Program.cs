using System;
using System.ComponentModel;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Null Object Pattern!");

            IProductRepository productRepository = new FakeProductRepository();

            ProductBase product = productRepository.Get(1);

            product.RateId(3);

        }
    }

    public interface IProductRepository
    {
        ProductBase Get(int id);
    }

    public class FakeProductRepository : IProductRepository
    {
        public ProductBase Get(int id)
        {
            if (id > 100)
            {
                return Product.NullObject;
            }
            else
                return new Product();
        }
    }


  
    // Abstract Object
    public abstract class ProductBase 
    {
        protected int rate;

        public abstract void RateId(int rate);

    }

    // Real Object
    public class Product : ProductBase
    {
        public override void RateId(int rate)
        {
            this.rate = rate;
        }

        public static ProductBase NullObject => new NullProduct();
    }

    // Null Object
    public class NullProduct : ProductBase
    {
        public override void RateId(int rate)
        {
            // nic nie rób
        }
    }
}
