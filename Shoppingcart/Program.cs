using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();

            product.Add(new Product { Milk = " Milk 1.40" });
            product.Add(new Product { Beer = " Beer 0.95" });

            
            foreach (Product products in product)
            {
                Console.WriteLine(products.ToString());
            }
        }
    }
}
