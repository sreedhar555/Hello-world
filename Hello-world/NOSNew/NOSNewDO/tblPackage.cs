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
    
    public partial class tblPackage
    {
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public decimal PackageAmount { get; set; }
        public int InstanceId { get; set; }
        public int InstanceClassificationId { get; set; }
        public int InstanceSubClassificationId { get; set; }
        public int AcademicYearId { get; set; }
        public int StudentTypeId { get; set; }
        public int MediumId { get; set; }
        public int FeeTermId { get; set; }
        public int FeeTypeId { get; set; }
        public bool IsBlockingAmount { get; set; }
        public Nullable<decimal> BlockingAmount { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
