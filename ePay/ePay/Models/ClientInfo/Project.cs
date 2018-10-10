using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePay.Models.ClientInfo
{
    public class Project
    {
        public List<Admin> Admins { get; set; }
        public int ExternalProjectId { get; set; }
        public DateTime CreationDate { get; set; }
        public string ChargeBy { get; set; }
        public List<ProjectEvent> ProjectEvents { get; set; }
        public List<UsageRecords> UsageRecords { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Status Status { get; set; }
    }
}
