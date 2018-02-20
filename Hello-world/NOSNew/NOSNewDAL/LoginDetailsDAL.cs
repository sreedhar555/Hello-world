
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOSNewDO;

namespace NOSNewDAL
{
   public class LoginDetailsDAL
    {
        OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();

        public LoginDetailsDO GetLoginDetails(string UserName, string Password)
        {
            LoginDetailsDO obj = new LoginDetailsDO();

            var result = db.stpGetLoginDetails(UserName, Password);

            foreach (var item in result)
            {
                obj.UserId = item.UserId;
                obj.RoleId = item.RoleId;
                obj.InstanceId = item.InstanceId;
                obj.RoleName = item.RoleName;
                obj.UserName = item.UserName;
                obj.FirstName = item.FirstName;
                obj.LastName = item.LastName;
                obj.UniversityId = item.UniversityId;
                obj.Password = item.Password;
                obj.PortalEmail = item.PortalEmail;
                obj.Gender = item.Gender;
                obj.FolderMemorySize = item.FolderMemorySize;
                obj.InboxMemorySize = item.InboxMemorySize;
                obj.InstanceRoleId = item.InstanceRoleId;
                obj.IsUserActive = item.IsUserActive;
                obj.IsRoleActive = item.IsRoleActive;
                obj.IsInstanceActive = item.IsInstanceActive;
                obj.ClassificationName = item.ClassificationName;
                obj.SubClassificationName = item.SubClassificationName;
                obj.InstanceClassificationId = item.InstanceClassificationId;
                obj.InstanceSubClassificationId = item.InstanceSubClassificationId;
                obj.InstanceType = item.InstanceType;
                obj.AttendanceMode = item.AttendanceMode;
                obj.ChangePWOnLogin = item.ChangePWOnLogin;
                obj.ParentRoleId = item.ParentRoleId;
                obj.ChildId = item.ChildId;
                obj.DOB = item.DOB;
                obj.ThemeName = item.ThemeName;
                obj.Quote = item.Quote;
                obj.Address = item.Address;
                obj.PhoneNumber = item.PhoneNumber;
                obj.PhoneExtension = item.PhoneExtension;
                obj.Fax = item.Fax;
                obj.ContactUs = item.ContactUs;
                obj.BookingLimit = item.BookingLimit;
                obj.EntityId = item.EntityId;
                obj.SubEntityId = item.SubEntityId;
                obj.InstanceName = item.InstanceName;
                obj.InstancePeriodsCount = item.InstancePeriodsCount;
                obj.SubDomineName = item.SubDomineName;
                obj.RoleType = item.RoleType;
                obj.RoleTypeBatch = item.RoleTypeBatch;
                obj.LMSCategoryName = item.LMSCategoryName;
                obj.EmployeeTypeValue = item.EmployeeTypeValue;
                obj.DateOfJoining = item.DateOfJoining;
                obj.IS_ReportingManager = item.IS_ReportingManager;
                obj.ProjectHead = item.ProjectHead;
                obj.KRAName = item.KRAName;
                obj.KPIName = item.KPIName;
                obj.Photo = item.Photo;
                obj.No_ofLogins = item.No_ofLogins;
                obj.SuccessfulLogins = item.SuccessfulLogins;
                obj.TestAttempt = item.TestAttempt;
                obj.DontAllowLogin = item.DontAllowLogin;
                obj.LoginStatusCheck = item.LoginStatusCheck;
            }

            return obj;
        }
    }
}
