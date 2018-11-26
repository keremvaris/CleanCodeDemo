using System;

namespace CleanCodeDemo
{
  public class Student : IEntity, IPerson
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price(Product product)
    {
      var result = product.ProductPrice * (decimal)0.90;
      return result;
    }
  }
}
