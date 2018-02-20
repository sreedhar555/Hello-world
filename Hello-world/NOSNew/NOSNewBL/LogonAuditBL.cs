using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NOSNewDO
{
    public class LogonAuditBL
    {
        public int SaveLogonAudit(LogonAuditDO objNew)
        {
            LogonAuditDAL objDAL = new LogonAuditDAL();
            return objDAL.SaveLogonAudit(objNew);
        }
    }
}
