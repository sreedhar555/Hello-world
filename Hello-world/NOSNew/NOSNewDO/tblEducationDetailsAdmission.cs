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
    
    public partial class tblEducationDetailsAdmission
    {
        public int EducationDetailsId { get; set; }
        public int UserId { get; set; }
        public int InstanceId { get; set; }
        public string InstitutionName { get; set; }
        public string UniversityName { get; set; }
        public string Stream { get; set; }
        public string YearofPass { get; set; }
        public string Percentage { get; set; }
        public int QualificationId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public Nullable<int> RegularorCorrespondence { get; set; }
        public Nullable<int> ArtsorComorSci { get; set; }
        public string Place { get; set; }
        public string PassStatus { get; set; }
        public Nullable<int> DocumentType { get; set; }
        public string DocumentName { get; set; }
        public string DocumentSize { get; set; }
        public Nullable<int> UniversityId { get; set; }
    }
}
