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
    
    public partial class tblRegistrationUserDetails_RegistrationFeeDetails
    {
        public int RegistrationFeeId { get; set; }
        public Nullable<int> RegistrationUserId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> ModeOFPayment { get; set; }
        public string ChequeNo { get; set; }
        public Nullable<System.DateTime> ChequeDDDate { get; set; }
        public string ChequebankName { get; set; }
        public Nullable<int> PayableBranchID { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public string PaymentType { get; set; }
    }
}
