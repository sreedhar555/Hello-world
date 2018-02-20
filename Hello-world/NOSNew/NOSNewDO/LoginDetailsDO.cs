using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewDO
{

    public partial class LoginDetailsDO
    {
        public int UserId { get; set; }
        public int InstanceId { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UniversityId { get; set; }
        public string Password { get; set; }
        public string PortalEmail { get; set; }
        public string Gender { get; set; }
        public string FolderMemorySize { get; set; }
        public string InboxMemorySize { get; set; }
        public int InstanceRoleId { get; set; }
        public bool IsUserActive { get; set; }
        public bool IsRoleActive { get; set; }
        public bool IsInstanceActive { get; set; }
        public string ClassificationName { get; set; }
        public string SubClassificationName { get; set; }
        public int InstanceClassificationId { get; set; }
        public int InstanceSubClassificationId { get; set; }
        public string InstanceType { get; set; }
        public byte AttendanceMode { get; set; }
        public bool ChangePWOnLogin { get; set; }
        public Nullable<int> ParentRoleId { get; set; }
        public Nullable<int> ChildId { get; set; }
        public string DOB { get; set; }
        public string ThemeName { get; set; }
        public string Quote { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneExtension { get; set; }
        public string Fax { get; set; }
        public string ContactUs { get; set; }
        public Nullable<int> BookingLimit { get; set; }
        public int EntityId { get; set; }
        public int SubEntityId { get; set; }
        public string InstanceName { get; set; }
        public Nullable<int> InstancePeriodsCount { get; set; }
        public string SubDomineName { get; set; }
        public byte RoleType { get; set; }
        public int RoleTypeBatch { get; set; }
        public string LMSCategoryName { get; set; }
        public int EmployeeTypeValue { get; set; }
        public Nullable<System.DateTime> DateOfJoining { get; set; }
        public Nullable<bool> IS_ReportingManager { get; set; }
        public int ProjectHead { get; set; }
        public string KRAName { get; set; }
        public string KPIName { get; set; }
        public string Photo { get; set; }
        public Nullable<int> No_ofLogins { get; set; }
        public int SuccessfulLogins { get; set; }
        public Nullable<int> TestAttempt { get; set; }
        public Nullable<int> DontAllowLogin { get; set; }
        public bool LoginStatusCheck { get; set; }
    }
}

