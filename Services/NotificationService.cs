using HomeWork.Models;

namespace HomeWork.Services
{
    public class NotificationService
    {
        private readonly SmsService _smsService;
        private readonly EmailService _emailService;

        public NotificationService()
        {
            _smsService = new SmsService();
            _emailService = new EmailService();
        }

        public void SendNotification(User user, Order order)
        {
            var message =
                $"Dear {user.Name}, your order #{order.Id} is ready. And its total sum is {order.TotalSum} {ConfigService.Instance.Config.CurrencyConfig.Current.ToString()}";

            if (user.Phone?.Length > 0)
            {
                _smsService.Send(message);
            }

            if (user.Email?.Length > 0)
            {
                _emailService.Send(message);
            }
        }
    }
}