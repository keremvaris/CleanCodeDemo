using System;

namespace CleanCodeDemo
{
  class Program
  {
    protected Program()
    {
    }
    static void Main(string[] args)
    {
      IProductService productService = new ProductManager(new IsBankServiceAdapter());
      productService.Sell(
        new Product { ProductId = 1, ProductName = "Laptop", ProductPrice = 1000 },
        new Officer { Id = 1, Name = "Kerem" }
        );
      Console.ReadLine();
    }
  }
}
