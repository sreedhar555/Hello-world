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
    
    public partial class tblProbationAssessment
    {
        public int ProbationId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public Nullable<int> HrId { get; set; }
        public Nullable<int> QualityofWork { get; set; }
        public Nullable<int> Efficiency { get; set; }
        public Nullable<int> Attendence { get; set; }
        public Nullable<int> TimeKeeping { get; set; }
        public Nullable<int> TeamPerformance { get; set; }
        public Nullable<int> CompetencyintheRole { get; set; }
        public string ImprovementRequired { get; set; }
        public string ExtensionRequired { get; set; }
        public string EmployeePerformance { get; set; }
        public Nullable<int> ObjectivesIdentified { get; set; }
        public string FurtherAction { get; set; }
        public Nullable<System.DateTime> ReviewDate { get; set; }
        public Nullable<int> DevelopmentNeeds { get; set; }
        public string FurtherActionNeeds { get; set; }
        public Nullable<System.DateTime> ReviewDateNeeds { get; set; }
        public Nullable<bool> Is_HrUpdated { get; set; }
        public Nullable<int> Is_Extended { get; set; }
        public Nullable<System.DateTime> ExtendedDurationDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> DeleteFlag { get; set; }
    }
}
