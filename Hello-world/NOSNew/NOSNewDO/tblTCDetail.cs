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
    
    public partial class tblTCDetail
    {
        public int TCDetailsId { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public int UserId { get; set; }
        public Nullable<int> InstanceClassificationId { get; set; }
        public Nullable<int> InstanceSubClassificationId { get; set; }
        public Nullable<int> ConductId { get; set; }
        public Nullable<int> ClassificationId { get; set; }
        public Nullable<System.DateTime> DateOfIssueOfTC { get; set; }
        public string TCNumber { get; set; }
        public string Comments { get; set; }
        public string ClassStudied { get; set; }
        public string AnnualExamResult { get; set; }
        public string PromotionToHigherGrade { get; set; }
        public string ManualSerialNumber { get; set; }
        public string BonafiedSerialNumber { get; set; }
        public string BonafiedClass { get; set; }
        public string BonafiedYear { get; set; }
        public Nullable<int> WorkingDays { get; set; }
        public Nullable<int> PresentDays { get; set; }
        public Nullable<bool> FeePaid { get; set; }
        public string DateofBirthInWords { get; set; }
        public string CalssStudiedInwords { get; set; }
        public string FailedTimes { get; set; }
        public string WhetherPromotedtoHigherClass { get; set; }
        public string PromotedtoHigherClassInWords { get; set; }
        public string PaidSchoolDuesUptoMonth { get; set; }
        public string PaidSchoolDuesUptoYear { get; set; }
        public string AnyFeeConcession { get; set; }
        public string NCCCadet { get; set; }
        public string GamesPupilAchievementLevel { get; set; }
        public string Subject1 { get; set; }
        public string Subject2 { get; set; }
        public string Subject3 { get; set; }
        public string Subject4 { get; set; }
        public string Subject5 { get; set; }
        public string Subject6 { get; set; }
        public Nullable<System.DateTime> TCGenerationDate { get; set; }
        public string TCAutoGeneratedNumber { get; set; }
        public string ParentName { get; set; }
        public string GeneralConduct { get; set; }
        public string StudentCast { get; set; }
        public string ReasonLeavingSchool { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
