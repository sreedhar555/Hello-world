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
    
    public partial class tblSalaryAdvanceRequest
    {
        public int AdvanceSalaryId { get; set; }
        public int InstanceId { get; set; }
        public int UserId { get; set; }
        public decimal AdvanceAmount { get; set; }
        public decimal InstallmentAmount { get; set; }
        public int NoOfMonths { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DateTime AdvanceReceiveDate { get; set; }
        public string EffectMonth { get; set; }
        public string RaisedBy { get; set; }
        public Nullable<int> LevelId { get; set; }
        public Nullable<int> Status { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
