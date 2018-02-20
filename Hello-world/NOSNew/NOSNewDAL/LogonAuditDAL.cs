using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NOSNewDO
{
   public  class LogonAuditDAL
    {
        OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();

        public int SaveLogonAudit(LogonAuditDO objNew)
        {
            tblLogonAudit obj = new tblLogonAudit();

            obj.InstanceId = objNew.InstanceId;
            obj.UserName = objNew.UserName;
            obj.IPAddress = objNew.IPAddress;
            obj.URL = objNew.URL;
            obj.LoginAttempt = objNew.LoginAttempt;
            obj.LoginStatus = objNew.LoginStatus;
            obj.CreatedBy = objNew.CreatedBy;
            obj.CreatedDate = DateTime.Now;
            obj.UpdatedBy = objNew.UpdatedBy;

            db.tblLogonAudits.Add(obj);

            if (db.SaveChanges() > 0)
            {
                return 1;
            }
           else
            {
                return 0;
            }
        }
    }
}
