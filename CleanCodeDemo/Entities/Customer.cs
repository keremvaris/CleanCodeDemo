using CleanCodeDemo.Handlers;
using CleanCodeDemo.Interfaces;

namespace CleanCodeDemo.Entities
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
