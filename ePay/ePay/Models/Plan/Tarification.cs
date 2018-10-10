using System;

namespace ePay.Models.Plan
{
    public class Tarification
    {
        public DateTime CreatedDate { get; set; }
        public int TrialPeriodDays { get; set; }
        public CommonTarificationProprties CommonTarificationProprties { get; set; }
    }
}