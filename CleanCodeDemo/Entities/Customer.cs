using System;

namespace CleanCodeDemo
{
  public class Customer : IEntity, IPerson
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price(Product product)
    {
      var result = product.ProductPrice;
      return result;
    }
  }
}
