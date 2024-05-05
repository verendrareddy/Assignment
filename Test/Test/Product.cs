using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Product
    {
       public int ProductId;
       public string ProductName;
     public   double Price;

        public Product()
        {
            ProductId = 1;
            Price = 25.5;
            ProductName = "pencil";
        }

        public Product(int productId, double price, string productName)
        {
            ProductId = productId;
            Price = price;
            ProductName = productName;
        }

        public void DisplatData()
        {
            Console.WriteLine("productId:{0}", ProductId);
            Console.WriteLine("ProductName{0}", ProductName);
            Console.WriteLine("ProductPrice{0}",Price);
        }
    }
}
