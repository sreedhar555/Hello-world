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
    
    public partial class KMS_tblInstanceSubClassification
    {
        public int InstanceSubClassificationId { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public Nullable<int> InstanceClassificationId { get; set; }
        public string SubClassificationName { get; set; }
        public string SubClassificationDescription { get; set; }
        public string SubClassificationDescriptionWords { get; set; }
        public Nullable<System.DateTime> AttendanceEffectiveDate { get; set; }
        public Nullable<System.DateTime> AttendanceEndDate { get; set; }
        public int ResultsModeId { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public Nullable<int> ClassTeacherId { get; set; }
        public Nullable<int> Co_ClassTeacherID { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<int> IsJuniorOrSenior { get; set; }
        public Nullable<int> GlobalSubClassificationId { get; set; }
        public Nullable<bool> IsWeigthage { get; set; }
    }
}
