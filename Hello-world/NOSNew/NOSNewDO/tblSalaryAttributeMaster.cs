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
    
    public partial class tblSalaryAttributeMaster
    {
        public int SalaryAttributeMasterId { get; set; }
        public int InstanceId { get; set; }
        public string SalaryAttributeMasterName { get; set; }
        public Nullable<bool> IsPercentage { get; set; }
        public string SalaryCode { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public Nullable<int> Order { get; set; }
        public string Section { get; set; }
    }
}
