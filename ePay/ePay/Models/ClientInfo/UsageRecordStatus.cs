using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePay.Models.ClientInfo
{
    public enum UsageRecordStatus
    {
        Active = 0,
        RecycleBin = 1,
        DeletedFromRecycleBin = 2
    }
}
