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
    
    public partial class tblExamTiming
    {
        public int ExamTimeId { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public Nullable<int> ClassificationId { get; set; }
        public Nullable<int> SubClassificationId { get; set; }
        public Nullable<int> ExamId { get; set; }
        public Nullable<int> SubjectId { get; set; }
        public Nullable<System.DateTime> ExamDate { get; set; }
        public Nullable<int> InTimeHrs { get; set; }
        public Nullable<int> InTimeMins { get; set; }
        public Nullable<int> OutTimeHrs { get; set; }
        public Nullable<int> OutTimeMins { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
