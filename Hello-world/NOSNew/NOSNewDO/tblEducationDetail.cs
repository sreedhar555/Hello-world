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
    
    public partial class tblEducationDetail
    {
        public int EducationDetailsId { get; set; }
        public int UserId { get; set; }
        public int EducationLevelId { get; set; }
        public Nullable<int> SpecializationId { get; set; }
        public Nullable<int> UniversityId { get; set; }
        public string InstitutionName { get; set; }
        public Nullable<int> POYear { get; set; }
        public Nullable<int> StudyModeId { get; set; }
        public Nullable<int> PassStatusId { get; set; }
        public Nullable<double> Percentage { get; set; }
        public string Class { get; set; }
        public string Certificate { get; set; }
        public Nullable<int> Backlogscount { get; set; }
        public string BacklogsDesc { get; set; }
        public string GapsDesc { get; set; }
        public string AggregadeMarks { get; set; }
        public Nullable<double> Cutoffmarks { get; set; }
        public string MediumofInstruction { get; set; }
        public string RandomNumber { get; set; }
        public string OCRank { get; set; }
        public string CommunityRank { get; set; }
        public Nullable<int> MonthId { get; set; }
        public string OtherEducationDetails { get; set; }
        public string OtherSpecialization { get; set; }
        public string OtherUniversity { get; set; }
        public string Grade { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public Nullable<int> DocumentType { get; set; }
        public string DocumentName { get; set; }
        public string DocumentSize { get; set; }
        public string Place { get; set; }
        public string Stream { get; set; }
    }
}