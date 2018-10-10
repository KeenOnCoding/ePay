using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePay.Models.ClientInfo
{
    public class Address
    {
        public string Region { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public int Index { get; set; }
    }
}
