using CleanCodeDemo.Entities;
using CleanCodeDemo.Interfaces;

namespace CleanCodeDemo.Handlers
{
  public class CustomerCampaignHandler : IPersonCampaignHandler
  {
    public decimal Calculate(Product product)
    {
      return product.ProductPrice;
    }
  }
}
