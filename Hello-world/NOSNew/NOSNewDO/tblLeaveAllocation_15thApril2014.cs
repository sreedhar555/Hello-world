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
    
    public partial class tblLeaveAllocation_15thApril2014
    {
        public int LeaveAllocationId { get; set; }
        public int AcademicYearId { get; set; }
        public int InstanceId { get; set; }
        public int UserId { get; set; }
        public int LeaveTypeId { get; set; }
        public Nullable<double> NoofLeaves { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
