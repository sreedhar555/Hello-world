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
    
    public partial class tblLeaveType
    {
        public int LeaveTypeId { get; set; }
        public int InstanceId { get; set; }
        public string LeaveType { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public Nullable<bool> CarryForward { get; set; }
        public Nullable<bool> ApplicableFor { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public Nullable<bool> AllowPastDates { get; set; }
        public Nullable<bool> IsApplicableforConverting { get; set; }
        public Nullable<bool> IsEncashable { get; set; }
    }
}