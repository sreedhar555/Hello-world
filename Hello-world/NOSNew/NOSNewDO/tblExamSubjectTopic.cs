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
    
    public partial class tblExamSubjectTopic
    {
        public int ExamSubjectTopicsID { get; set; }
        public int AcademicYearID { get; set; }
        public int ExamID { get; set; }
        public Nullable<int> TermID { get; set; }
        public int SubjectID { get; set; }
        public int TopicID { get; set; }
        public Nullable<int> AssessmentTargetType { get; set; }
        public Nullable<int> pExamSubjectTopicsID { get; set; }
        public Nullable<int> LongTermTargetID { get; set; }
        public Nullable<int> SupportingTargetID { get; set; }
        public Nullable<int> MaxMarks { get; set; }
        public Nullable<double> PassMarks { get; set; }
        public System.DateTime DateConducted { get; set; }
        public Nullable<System.DateTime> ReTestDateConducted { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
