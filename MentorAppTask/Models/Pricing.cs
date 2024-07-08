namespace MentorAppTask.Models
{
    public class Pricing:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsFeautured { get; set; }
        public bool IsAdvanced { get; set; }
        public List<PricingService> PricingServices { get; set; }
    }
}
