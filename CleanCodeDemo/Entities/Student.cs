using CleanCodeDemo.Handlers;
using CleanCodeDemo.Interfaces;

namespace CleanCodeDemo.Entities
{
    public class Student : IEntity, IPerson
    {
        public Student()
        {
            CampaignHandler = new StudentCampaignHandler();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public IPersonCampaignHandler CampaignHandler { get; set; }
    }
}
