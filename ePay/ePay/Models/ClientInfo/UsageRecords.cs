using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePay.Models.ClientInfo
{
    public class UsageRecords
    {
        public List<Admin> Admins { get; set; }
        public string ChargeBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ProjectName { get; set; }
        public Status Status { get; set; }
        public UsageRecordStatus UsageRecordStatus { get; set; }
        public List<Usage> Usage { get; set; }
    }
}
