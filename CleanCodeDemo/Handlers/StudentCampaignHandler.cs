namespace CleanCodeDemo
{
  public class StudentCampaignHandler : IPersonCampaignHandler
  {
    public decimal Calculate(Product product)
    {
      return product.ProductPrice * (decimal)0.50;
    }
  }
}
