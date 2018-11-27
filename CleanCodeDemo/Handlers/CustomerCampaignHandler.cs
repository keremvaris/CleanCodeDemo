namespace CleanCodeDemo
{
  public class CustomerCampaignHandler : IPersonCampaignHandler
  {
    public decimal Calculate(Product product)
    {
      return product.ProductPrice;
    }
  }
}
