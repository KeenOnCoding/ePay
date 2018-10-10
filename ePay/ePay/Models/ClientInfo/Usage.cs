using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePay.Models.ClientInfo
{
    public class Usage
    {
        public string Unit { get; set; }
        public object Item { get; set; }
        public string DataSource { get; set; }
    }
}
