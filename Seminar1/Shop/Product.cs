

namespace Seminar1.Shop
{
    public class Product
    {
        private int cost; // Стоимость продукта
        private string title; // Название

        // Геттеры, сеттеры:
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}
