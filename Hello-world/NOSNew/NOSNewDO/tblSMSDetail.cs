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
    
    public partial class tblSMSDetail
    {
        public int SmsDetailsId { get; set; }
        public int SmsLogId { get; set; }
        public string GUID { get; set; }
        public Nullable<int> SeqId { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> DeliveredDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
