using HomeWork.Models;

namespace HomeWork.Services
{
    public class ConfigService
    {
        static ConfigService()
        {
        }

        private ConfigService()
        {
            Init();
        }

        public static ConfigService Instance { get; } = new ConfigService();

        public Config Config { get; private set; }

        private void Init()
        {
            Config = new Config
            {
                BasketConfig = new BasketConfig { Limit = 10 },
                CurrencyConfig = new CurrencyConfig
                {
                    Current = Currency.Uah,
                    ExchangeRate = 27.2
                }
            };
        }
    }
}