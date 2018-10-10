using System.Collections.Generic;

namespace ePay.Models.Plan
{
    public class Plan
    {
        public int Id { get; set; }
        public int ExternalStripeId { get; set; }

        public string Name { get; set; }
        public bool Active { get; set; }
        public List<PlanVersion> Versions { get; set; }
        public List<Product> Product { get; set; }
        public Currency Currency { get; set; }
    }
}