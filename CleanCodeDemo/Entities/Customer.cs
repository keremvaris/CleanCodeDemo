using System;

namespace CleanCodeDemo
{
  public class Customer : IEntity, IPerson
  {
    public Customer()
    {
      CampaignHandler = new CustomerCampaignHandler();
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public IPersonCampaignHandler CampaignHandler { get; set; }
  }
}
