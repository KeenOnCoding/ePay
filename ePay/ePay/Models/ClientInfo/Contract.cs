using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePay.Models.ClientInfo
{
    public class Contract
    {
        public string ContractName { get; set; }
        public int ContractNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public UsageDelitionOptions UsageDelitionOptions { get; set; }
        public Organization Organization { get; set; }
        public Metadata Metadata { get; set; }
    }
}
