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
    
    public partial class tblUserWiseKRA
    {
        public int UserwiseKRAId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> KeyResponsibleAreaId { get; set; }
        public Nullable<int> UserWeightage { get; set; }
        public Nullable<int> ReportingManagerWeightage { get; set; }
        public Nullable<int> HRWeightage { get; set; }
        public Nullable<int> Is_UserUpdated { get; set; }
        public Nullable<int> IS_RMUpdated { get; set; }
        public Nullable<int> IS_HRUpdated { get; set; }
        public string Comments { get; set; }
        public string OverAllComments { get; set; }
        public Nullable<System.DateTime> ReleaseFromDate { get; set; }
        public Nullable<System.DateTime> ReleaseToDate { get; set; }
        public string QuarterName { get; set; }
        public Nullable<System.DateTime> AppraisalFromDate { get; set; }
        public Nullable<System.DateTime> AppraisalToDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}