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
    
    public partial class KMS_tblinstanceclassification
    {
        public int InstanceClassificationId { get; set; }
        public int InstanceId { get; set; }
        public string ClassificationName { get; set; }
        public string ClassificationDescription { get; set; }
        public Nullable<System.DateTime> AttendanceEffectiveDate { get; set; }
        public Nullable<System.DateTime> AttendanceEndDate { get; set; }
        public Nullable<int> SubCategoryId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public Nullable<int> ProgramType { get; set; }
        public Nullable<short> AllowedDialougeCount { get; set; }
        public Nullable<int> IsGroup { get; set; }
        public Nullable<int> GlobalClassificationId { get; set; }
        public string CourceCode { get; set; }
        public Nullable<int> DisplayinAdmission { get; set; }
        public Nullable<int> NCVTChargesApplicable { get; set; }
        public Nullable<int> instancetype { get; set; }
        public Nullable<int> AdmissionTypeApplicable { get; set; }
        public Nullable<int> GenderApplicable { get; set; }
    }
}
