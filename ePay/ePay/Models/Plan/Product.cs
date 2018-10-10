using System;
using System.Collections.Generic;

namespace ePay.Models.Plan
{
    public class Product
    {
        public int Id { get; set; }
        public int PalnId { get; set; }

        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public List<PlanItem> PlanItems { get; set; }
    }
}