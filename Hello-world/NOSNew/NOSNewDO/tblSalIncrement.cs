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
    
    public partial class tblSalIncrement
    {
        public int SalIncrementId { get; set; }
        public int UserId { get; set; }
        public Nullable<System.DateTime> LastIncMonth { get; set; }
        public Nullable<decimal> LastIncAmount { get; set; }
        public Nullable<decimal> PresentGross { get; set; }
        public decimal CurGross { get; set; }
        public System.DateTime Effectmonth { get; set; }
        public Nullable<decimal> PresentBasic { get; set; }
        public Nullable<decimal> CurrentBasic { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> Status { get; set; }
        public string Reason { get; set; }
        public Nullable<int> LevelId { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
