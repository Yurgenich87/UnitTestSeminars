using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar2
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }


        public Product(int id, string name, double price, int quantity)
        {
            this.Id = id;
            this.Name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public int GetQuantity()
        {
            return this.quantity;
        }
    }
}
