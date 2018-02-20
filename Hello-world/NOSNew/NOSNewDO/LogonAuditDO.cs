using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewDO
{
    public class LogonAuditDO
    {
        public int LogonAuditId { get; set; }
        public int InstanceId { get; set; }
        public string UserName { get; set; }
        public string IPAddress { get; set; }
        public string URL { get; set; }
        public int LoginAttempt { get; set; }
        public bool LoginStatus { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
