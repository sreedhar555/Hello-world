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
    
    public partial class tblSubjectsHandled
    {
        public int SubjectHandledId { get; set; }
        public int InstanceId { get; set; }
        public int FacultyId { get; set; }
        public int AcademicYearId { get; set; }
        public int InstanceClassificationId { get; set; }
        public string OtherClassificationName { get; set; }
        public Nullable<int> InstanceSubClassificationId { get; set; }
        public string OtherSubClassificationName { get; set; }
        public int InstanceSubjectId { get; set; }
        public string OtherSubjectName { get; set; }
        public Nullable<System.DateTime> MonthandYear { get; set; }
        public Nullable<int> NoofStudentsAppeared { get; set; }
        public Nullable<int> NoofStudentsPassed { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
