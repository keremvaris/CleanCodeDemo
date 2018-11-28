using System;
using CleanCodeDemo.BankServices;
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

            Console.WriteLine(person.Name +" İsimli Müşterimiz için indirim Karşılığı:" + price.ToString("#.##"));
            Console.WriteLine("Ürünün Döviz Karşılığı:" + exchangePrice.ToString("#.##"));
          Console.WriteLine("#####################################################");
        }
      internal static void CustomerSell()
      {
        IProductService productService = new ProductManager(new CentralBankServiceAdapter());
        productService.Sell(
          new Product { ProductId = 1, ProductName = "Laptop", ProductPrice = 1000 },
          new Customer() { Id = 1, Name = "Kerem" }
        );
      }

      internal static void StudentSell()
      {
        IProductService productService = new ProductManager(new IsBankServiceAdapter());
        productService.Sell(
          new Product { ProductId = 1, ProductName = "Laptop", ProductPrice = 1000 },
          new Student() { Id = 1, Name = "Nesil" }
        );
      }
      internal static void OfficerSell()
      {
        IProductService productService = new ProductManager(new FakeBankService());
        productService.Sell(
          new Product { ProductId = 1, ProductName = "Laptop", ProductPrice = 1000 },
          new Officer() { Id = 1, Name = "Engin" }
        );
      }
  }
}
