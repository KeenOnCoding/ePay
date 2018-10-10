using System.Collections.Generic;

namespace ePay.Models.Plan
{
    public class Currency
    {
        public string Name { get; set; }
        public float Value { get; set; }
        public List<PlanVersion> Version { get; set; }
    }
}