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
    
    public partial class tblUserOrganizationAdmission
    {
        public int UserOrganizationID { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string OrganizationName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public Nullable<int> DurationFromMonth { get; set; }
        public Nullable<int> DurationFromYear { get; set; }
        public Nullable<int> DurationToMonth { get; set; }
        public Nullable<int> DurationToYear { get; set; }
        public string AnnualSalary { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
