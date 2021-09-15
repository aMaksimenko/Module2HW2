using HomeWork.Models;
using HomeWork.Services;

namespace HomeWork
{
    public class Basket
    {
        static Basket()
        {
        }

        private Basket()
        {
        }

        public static Basket Instance { get; } = new Basket();

        public Product[] Products { get; private set; } =
            new Product[ConfigService.Instance.Config.BasketConfig.Limit];

        private int CurrentIndex { get; set; }

        public void Add(Product product)
        {
            Products[CurrentIndex] = product;
            CurrentIndex++;
        }

        public void Clear()
        {
            Products = new Product[ConfigService.Instance.Config.BasketConfig.Limit];
        }
    }
}