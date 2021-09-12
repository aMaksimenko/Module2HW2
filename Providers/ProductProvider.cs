using System;
using HomeWork.Models;

namespace HomeWork.Providers
{
    public class ProductProvider
    {
        private const int AllProductsCount = 50;
        private readonly Random _random = new Random();

        public ProductProvider()
        {
            Init();
        }

        public Product[] Products { get; private set; }

        private void Init()
        {
            Products = CreateProducts();
        }

        private Product[] CreateProducts()
        {
            var result = new Product[AllProductsCount];

            for (var i = 0; i < AllProductsCount; i++)
            {
                result[i] = new Product()
                {
                    Id = i,
                    Title = $"Product with index {i}",
                    Price = _random.Next(i + 10) * 10,
                    Currency = Currency.Usd
                };
            }

            return result;
        }
    }
}