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
    
    public partial class tblTransportForm
    {
        public int TransportFormId { get; set; }
        public int UserId { get; set; }
        public int InstanceId { get; set; }
        public Nullable<int> FormTypeId { get; set; }
        public Nullable<int> PickUpRouteId { get; set; }
        public Nullable<int> DropUpRouteId { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public Nullable<System.DateTime> EffectiveToDate { get; set; }
        public Nullable<int> WithdrawalFromRoute { get; set; }
        public Nullable<int> RouteChangePurpose { get; set; }
        public string OtherPurpose { get; set; }
        public string Reason { get; set; }
        public Nullable<bool> IsCancelled { get; set; }
        public Nullable<int> IsNecessaryDocumentSubmitted { get; set; }
        public string AddressChangeDocument { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> Deleteflag { get; set; }
    }
}
