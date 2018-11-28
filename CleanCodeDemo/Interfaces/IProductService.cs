using CleanCodeDemo.Entities;

namespace CleanCodeDemo.Interfaces
{
  public interface IProductService
  {
    void Sell(Product product,IPerson person);
  }
}
