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
    
    public partial class tblReservationInstalment
    {
        public int ReservationInstalmentId { get; set; }
        public Nullable<int> ReservationId { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public Nullable<int> ReservationAt { get; set; }
        public Nullable<int> ReceiptNo { get; set; }
        public Nullable<int> PaymentModeId { get; set; }
        public string ChequeDDNo { get; set; }
        public Nullable<System.DateTime> ChequeDDDate { get; set; }
        public string ChequeDDBank { get; set; }
        public string ChequeDDBranch { get; set; }
        public Nullable<decimal> PayingAmount { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
