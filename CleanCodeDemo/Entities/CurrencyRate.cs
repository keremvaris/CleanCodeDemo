using CleanCodeDemo.Interfaces;

namespace CleanCodeDemo.Entities
{
  public class CurrencyRate:IEntity
  {
    public decimal Price { get; set; }
    public int Currency { get; set; }
  }
}
