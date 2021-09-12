using System;
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

        public void FormOrder(Product[] products)
        {
            Order.Products = products;
            foreach (var product in products)
            {
                Order.TotalSum += product.Price;
            }
        }

        private void Init()
        {
            var random = new Random();

            Order = new Order
            {
                Id = random.Next(9999)
            };
        }
    }
}