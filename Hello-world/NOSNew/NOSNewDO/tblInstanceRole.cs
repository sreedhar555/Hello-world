//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NOSNewDO
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblInstanceRole
    {
        public int InstanceRoleId { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public string FolderMemorySize { get; set; }
        public string InboxMemorySize { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> Level { get; set; }
        public Nullable<int> BookingLimit { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public Nullable<byte> RoleType { get; set; }
        public Nullable<int> No_ofLogins { get; set; }
    }
}