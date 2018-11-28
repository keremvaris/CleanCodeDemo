using System;
using CleanCodeDemo.Entities;
using CleanCodeDemo.Interfaces;

namespace CleanCodeDemo.Business
{
  public class ProductManager : IProductService
    {
        private readonly IBankService _bankService;

        public ProductManager(IBankService bankService)
        {
            _bankService = bankService;
        }

        public void Sell(Product product, IPerson person)
        {
            var price = person.CampaignHandler.Calculate(product);
            var exchangePrice = _bankService.ConvertRate(new CurrencyRate { Currency = 1, Price = price });

            Console.WriteLine("Müşteri Tipi İndirim Karşılığı:" + price.ToString("#.##"));
            Console.WriteLine("Döviz Karşılığı:" + exchangePrice.ToString("#.##"));
        }
    }
}
