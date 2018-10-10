using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePay.Models.ClientInfo
{
    public class Account
    {
        public int ExternalAccountId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public Status Status { get; set; }
        public List<Project> Project { get; set; }
        public AccountManager AccountManager { get; set; }
        public int CustomerId { get; set; }
        public List<PreviousAccountManager> PreviousAccountManagers { get; set; }
    }
}
