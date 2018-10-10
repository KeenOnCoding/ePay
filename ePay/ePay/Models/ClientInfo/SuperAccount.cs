using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePay.Models.ClientInfo
{
    public class SuperAccount
    {
        public int Name { get; set; }
        public DateTime CreationDate { get; set; }
        public List<string> Previousname { get; set; }
        public Customer Customer { get; set; }
    }
}
