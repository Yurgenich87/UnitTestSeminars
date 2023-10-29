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
        public double Price { get; set; }
        public int Quantity { get; set; }


        public Product(int id, string name, double price, int quantity)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string GetName()
        {
            return this.Name;
        }
        public double GetPrice()
        {
            return this.Price;
        }

        public int GetQuantity()
        {
            return this.Quantity;
        }
    }
}
