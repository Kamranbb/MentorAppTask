namespace MentorAppTask.Models
{
    public class Service:BaseEntity
    {
        public string Name { get; set; }
        public List<PricingService> PricingServices { get; set; }
    }
}
