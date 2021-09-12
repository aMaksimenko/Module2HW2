using HomeWork.Models;

namespace HomeWork
{
    public class Basket
    {
        private static readonly Basket InstanceValue = new Basket();

        static Basket()
        {
        }

        private Basket()
        {
        }

        public static Basket Instance => InstanceValue;
        public Product[] Products { get; private set; }

        public void AddProducts(Product[] products)
        {
            Products = products;
        }
    }
}