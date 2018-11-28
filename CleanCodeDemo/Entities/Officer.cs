using System;

namespace CleanCodeDemo
{
  public class Officer : IEntity, IPerson
  {
    public Officer()
    {
      CampaignHandler = new OfficerCampaignHandler();
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public IPersonCampaignHandler CampaignHandler { get; set; }
  }
}
