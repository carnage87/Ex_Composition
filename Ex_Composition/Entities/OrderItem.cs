using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_Composition.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }


        public OrderItem()
        {
        }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Product.Price;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Product.Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + Quantity + ", Subtotal: $" +
                SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
