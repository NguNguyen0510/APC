using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC
{
    class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
        }

        public Product(int productID, string productName, decimal Price)
        {
            this.productID = productID;
            this.productName = productName;
            this.Price = Price;
        }

    }
}
