namespace CleanCodeDemo.Interfaces
{
    public interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        IPersonCampaignHandler CampaignHandler { get; set; }
    }
}
