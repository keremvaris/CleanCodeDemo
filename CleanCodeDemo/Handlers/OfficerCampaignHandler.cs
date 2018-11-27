namespace CleanCodeDemo
{
  public class OfficerCampaignHandler : IPersonCampaignHandler
  {
    public decimal Calculate(Product product)
    {
      return product.ProductPrice * (decimal)0.80;
    }
  }
}
