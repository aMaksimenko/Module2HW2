using HomeWork.Models;

namespace HomeWork.Services
{
    public class OrderService
    {
        public OrderService()
        {
            Init();
        }

        public Order Order { get; private set; }

        public void Form(Product[] products)
        {
            foreach (var product in products)
            {
                Order.TotalSum += product.Price;
            }

            Order.TotalSum *= ConfigService.Instance.Config.CurrencyConfig.ExchangeRate;
        }

        private void Init()
        {
            Order = new Order { Id = 1 };
        }
    }
}