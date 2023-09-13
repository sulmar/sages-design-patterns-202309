using System.Collections.Generic;

namespace ProxyPattern
{
    // Pośrednik (Proxy) - wariant klasowy
    public class CacheProductRepositoryClass : DbProductRepository,  IProductRepository
    {
        private IDictionary<int, Product> products;

        public CacheProductRepositoryClass()
            : base()
        {
            products = new Dictionary<int, Product>();
        }

        public void Add(Product product)
        {
            products.Add(product.Id, product);
        }

        public override Product Get(int id)
        {
            if (products.TryGetValue(id, out Product product))
            {
                product.CacheHit++;
            }
            else
            {
                // Real Subject
                product = base.Get(id);

                if (product != null)
                {
                    Add(product);
                }
            }

            return product;
           
        }
    }

}
