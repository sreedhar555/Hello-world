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
    
    public partial class tblPocketMoney
    {
        public int PocketMoneyId { get; set; }
        public Nullable<int> ReceiptNo { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<bool> PayType { get; set; }
        public string Comments { get; set; }
        public Nullable<int> PaymentModeId { get; set; }
        public Nullable<int> AccountNumberId { get; set; }
        public Nullable<int> AcademicYearId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
