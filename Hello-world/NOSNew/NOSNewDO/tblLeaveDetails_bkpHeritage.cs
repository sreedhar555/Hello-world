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
    
    public partial class tblLeaveDetails_bkpHeritage
    {
        public int LeaveApplicationId { get; set; }
        public int AcademicYearId { get; set; }
        public int InstanceId { get; set; }
        public int UserId { get; set; }
        public int LeaveTypeId { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public Nullable<int> Day { get; set; }
        public string Reason { get; set; }
        public int BatchID { get; set; }
        public string RequestStatus { get; set; }
        public string Comments { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public string FileAttached { get; set; }
        public Nullable<bool> AppliedForMarriage { get; set; }
        public Nullable<bool> ConvertedSLtoL { get; set; }
    }
}
