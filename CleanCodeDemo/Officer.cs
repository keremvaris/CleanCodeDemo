using System;

namespace CleanCodeDemo
{
  public class Officer : IEntity, IPerson
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price(Product product)
    {
      var result = product.ProductPrice * (decimal)0.80;
      return result;
    }
  }
}
