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
    
    public partial class tblInstanceExcessAmountBak
    {
        public int ExcessAmountID { get; set; }
        public Nullable<int> UserReceiptGenerationID { get; set; }
        public string UserReceiptCode { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public Nullable<int> userfeeid { get; set; }
        public Nullable<int> FeeTermId { get; set; }
        public Nullable<int> FeeTypeId { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<decimal> FeeAmount { get; set; }
        public Nullable<decimal> concedingAmount { get; set; }
        public Nullable<decimal> Amounttopay { get; set; }
        public Nullable<decimal> PaidAmount { get; set; }
        public Nullable<short> ReceiptStatus { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
