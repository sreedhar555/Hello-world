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
    
    public partial class tblStudentLeaveDetail
    {
        public int StudentLeaveDetailsID { get; set; }
        public Nullable<int> AcademicYearId { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> AttendanceTypeId { get; set; }
        public string Comments { get; set; }
        public string FileAttached { get; set; }
        public Nullable<bool> IsHalfDay { get; set; }
        public Nullable<int> StudentLeaveDelegationID { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<bool> IsDelegated { get; set; }
        public string ApplyRejectDelegatedComment { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public Nullable<int> Sanction { get; set; }
        public string LeaveGUID { get; set; }
        public string OtherReason { get; set; }
        public Nullable<bool> AssessmentsExists { get; set; }
        public Nullable<bool> ClassTeacherForward { get; set; }
        public Nullable<bool> PrincipalForward { get; set; }
        public string PrinicipalRemarks { get; set; }
        public Nullable<int> MailSentCount { get; set; }
        public Nullable<System.DateTime> MailSentDate { get; set; }
        public Nullable<int> LeaveTypeApplied { get; set; }
    }
}
