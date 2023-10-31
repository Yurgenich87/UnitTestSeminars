using System;

namespace UnitTest.Seminar2
{

    public class Product
    {
        public int Id { get; private set; } // У продукта есть порядковый номер
        public string Name { get; private set; } // У продукта есть порядковый имя
        public double Price { get; private set; } // У продукта есть цена
        public int Quantity { get; set; } // У продукта есть переменная, которая хранит его количество в магазине

        // При создании продукта мы должны указать все, объявленные выше, поля
        public Product(int id, string name, double price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Product()
        {

        }

        // Служебные методы для сравнения продуктов между собой
        public override int GetHashCode()
        {
            int hash = 7;
            hash = 29 * hash + Id.GetHashCode();
            hash = 29 * hash + (Name != null ? Name.GetHashCode() : 0);
            hash = 29 * hash + Price.GetHashCode();
            hash = 29 * hash + Quantity.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (GetType() != obj.GetType())
            {
                return false;
            }
            Product other = (Product)obj;
            if (!Equals(Name, other.Name))
            {
                return false;
            }
            if (!Equals(Id, other.Id))
            {
                return false;
            }
            if (!Equals(Price, other.Price))
            {
                return false;
            }
            return Equals(Quantity, other.Quantity);
        }

        public int GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetPrice()
        {
            return Price;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }
}