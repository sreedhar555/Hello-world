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
    
    public partial class tblStudentAttendanceMonthlyWise
    {
        public int AttendanceMonthly { get; set; }
        public Nullable<int> userid { get; set; }
        public Nullable<int> instanceid { get; set; }
        public Nullable<int> monthNo { get; set; }
        public Nullable<int> yearNo { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> Workingdays { get; set; }
        public Nullable<double> Presentdays { get; set; }
        public Nullable<double> NumberOfLeaves { get; set; }
        public Nullable<double> LossOfPayDays { get; set; }
        public Nullable<int> LateComing { get; set; }
        public Nullable<int> EarlyGoing { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public Nullable<int> ConfirmedWorkingdays { get; set; }
        public Nullable<double> ConfirmedPresentdays { get; set; }
        public Nullable<double> ConfirmedNumberOfLeaves { get; set; }
        public Nullable<double> ConfirmedLossOfPayDays { get; set; }
        public Nullable<int> ConfirmedLateComing { get; set; }
        public Nullable<int> ConfirmedEarlyGoing { get; set; }
        public Nullable<int> ConfirmedCategory { get; set; }
        public Nullable<int> ConfirmedSubCategory { get; set; }
        public Nullable<double> CL { get; set; }
        public Nullable<double> OD { get; set; }
        public Nullable<double> ConfirmedCL { get; set; }
        public Nullable<double> ConfirmedOD { get; set; }
        public Nullable<bool> IsOnHold { get; set; }
        public Nullable<int> OnHoldBy { get; set; }
        public Nullable<System.DateTime> OnHoldDate { get; set; }
        public Nullable<int> OnHoldRemovedBy { get; set; }
        public Nullable<System.DateTime> OnHoldRemovedDate { get; set; }
    }
}
