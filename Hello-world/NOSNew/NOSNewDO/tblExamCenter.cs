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
    
    public partial class tblExamCenter
    {
        public int ExamCentreId { get; set; }
        public int InstanceId { get; set; }
        public string ExamCenterName { get; set; }
        public string ExamCenterCode { get; set; }
        public string ExamCentreAddress1 { get; set; }
        public string ExamCentreAddress2 { get; set; }
        public string ExamcentreLandmark { get; set; }
        public string ExamCentreCity { get; set; }
        public Nullable<int> ExamCentreState { get; set; }
        public string ExamcentrePhone { get; set; }
        public string ExamcentreLandLine { get; set; }
        public Nullable<int> SystemsCount { get; set; }
        public Nullable<int> ExamOpenTimeHours { get; set; }
        public Nullable<int> ExamOpenTimeMins { get; set; }
        public Nullable<int> ExamCloseTimeHours { get; set; }
        public Nullable<int> ExamCloseTimeMins { get; set; }
        public string ExamCentreContactPerson { get; set; }
        public string Exam10Instructions { get; set; }
        public Nullable<int> ExamCentreCountry { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
