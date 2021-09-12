using System;
using HomeWork.Models;

namespace HomeWork.Services
{
    public class NotificationService
    {
        public void SendNotification(User user, Order order, Currency currency)
        {
            var totalSum = order.TotalSum * (int)currency;
            var message = $"Dear {user.FullName}, your order #{order.Id} is ready. And its total sum is {totalSum} {currency.ToString()}";

            if (user.Phone?.Length > 0)
            {
                SendBySms(message);
            }

            if (user.Email?.Length > 0)
            {
                SendByEmail(message);
            }
        }

        private void SendBySms(string message)
        {
            Console.WriteLine("sent by SMS:");
            Console.WriteLine(message);
        }

        private void SendByEmail(string message)
        {
            Console.WriteLine("sent by email:");
            Console.WriteLine(message);
        }
    }
}