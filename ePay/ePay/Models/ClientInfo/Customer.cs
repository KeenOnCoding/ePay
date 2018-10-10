using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePay.Models.ClientInfo
{
    public class Customer
    {
        public string Name { get; set; }
        public List<string> PreviousName { get; set; }
        public Address Address { get; set; }
        public Address PreviousAddress { get; set; }
        public int ExternalBilingSystemCustomerId { get; set; }
        public DateTime CreatiionDate { get; set; }
        public List<Account> Account { get; set; }
        public string TaxNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
