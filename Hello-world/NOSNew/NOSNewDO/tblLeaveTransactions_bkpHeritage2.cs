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
    
    public partial class tblLeaveTransactions_bkpHeritage2
    {
        public int LeaveTransactionId { get; set; }
        public int BatchID { get; set; }
        public int SubmittedBy { get; set; }
        public Nullable<int> SubmittedTo { get; set; }
        public int ApprovalStatusID { get; set; }
        public Nullable<int> Level_Id { get; set; }
        public string Comments { get; set; }
        public Nullable<bool> ApprovalFlag { get; set; }
        public Nullable<bool> DelegationFlag { get; set; }
        public Nullable<int> DelegationFrom { get; set; }
        public Nullable<bool> LeaveCancelledFlag { get; set; }
        public string CancelComments { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
