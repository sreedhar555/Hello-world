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
    
    public partial class tblEnquirySalesCallDetail
    {
        public int EnquirySalesCallDetailsID { get; set; }
        public int EnquirySalesCallID { get; set; }
        public int UserId { get; set; }
        public string CalledBy { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<System.DateTime> CallDate { get; set; }
        public Nullable<int> StHRS { get; set; }
        public Nullable<int> StMNS { get; set; }
        public string StAMPM { get; set; }
        public Nullable<int> EndHRS { get; set; }
        public Nullable<int> EndMNS { get; set; }
        public string EndAMPM { get; set; }
        public Nullable<int> CallDuration { get; set; }
        public Nullable<System.DateTime> CallBackDate { get; set; }
        public Nullable<int> CBHRS { get; set; }
        public Nullable<int> CBMNS { get; set; }
        public string CBAMPM { get; set; }
        public Nullable<int> RejectedRemarksID { get; set; }
        public string RejectedComments { get; set; }
        public Nullable<decimal> DiscountRequested { get; set; }
        public Nullable<decimal> ApprovedDiscount { get; set; }
        public Nullable<bool> IsDiscountApproved { get; set; }
        public Nullable<int> ApproveStatusID { get; set; }
        public Nullable<int> DiscountApprovedBy { get; set; }
        public Nullable<System.DateTime> DiscountApprovedDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public string FeeDiscountRemarks { get; set; }
        public Nullable<short> MailSendingStatus { get; set; }
    }
}