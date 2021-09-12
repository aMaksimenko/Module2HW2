using HomeWork.Models;

namespace HomeWork.Services
{
    public class ConfigService
    {
        public ConfigService()
        {
            Init();
        }

        public Config Config { get; private set; }

        private void Init()
        {
            Config = new Config
            {
                BasketConfig = 10,
                CurrencyConfig = Currency.Uah
            };
        }
    }
}