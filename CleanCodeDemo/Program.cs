using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanCodeDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      
      IProductService productService = new ProductManager(new IsBankServiceAdapter());
      productService.Sell(new Product { ProductId = 1, ProductName = "Laptop", ProductPrice = 1000 }, new Customer(){ Id = 1, Name = "Kerem" });
      Console.ReadLine();
    }
  }
}
