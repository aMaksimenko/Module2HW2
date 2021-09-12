using System;
using HomeWork.Models;
using HomeWork.Providers;
using HomeWork.Services;

namespace HomeWork
{
    public class Starter
    {
        public void Run()
        {
            var productProvider = new ProductProvider();
            var configService = new ConfigService();
            var userService = new UserService();
            var orderService = new OrderService();
            var notificationService = new NotificationService();
            var randomProducts = PickRandomProducts(configService.Config.BasketConfig, productProvider.Products);

            Basket.Instance.AddProducts(randomProducts);
            orderService.FormOrder(Basket.Instance.Products);
            notificationService.SendNotification(
                userService.User,
                orderService.Order,
                configService.Config.CurrencyConfig);
        }

        private Product[] PickRandomProducts(int count, Product[] products)
        {
            var result = new Product[count];
            var random = new Random();

            for (var i = 0; i < count; i++)
            {
                var randomNumber = random.Next(0, products.Length);

                result[i] = products[randomNumber];
            }

            return result;
        }
    }
}