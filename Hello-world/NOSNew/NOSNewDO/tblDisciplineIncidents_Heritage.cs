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
    
    public partial class tblDisciplineIncidents_Heritage
    {
        public int IncidentId { get; set; }
        public int InstanceId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> InstanceClassificationId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> ReportedByID { get; set; }
        public Nullable<int> SubjectId { get; set; }
        public Nullable<System.DateTime> IncidentDate { get; set; }
        public string Remark { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> ShowToParent { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public string IncidentTime { get; set; }
        public string IncidentPlace { get; set; }
        public Nullable<bool> IsOthersInvolved { get; set; }
        public string OtherInvolvedUserId { get; set; }
        public Nullable<bool> ParentViewed { get; set; }
    }
}
