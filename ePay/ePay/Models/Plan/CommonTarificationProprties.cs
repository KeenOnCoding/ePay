using System.Collections.Generic;

namespace ePay.Models.Plan
{
    public class CommonTarificationProprties
    {
        public string UsageType { get; set; }
        public string BillingScheme { get; set; }
        public string TiersMode { get; set; }
        public List<Tier> Tiers { get; set; }
        public string AggregateUsage { get; set; }
        public string Interval { get; set; }
        public int IntervalCount { get; set; }
    }
}