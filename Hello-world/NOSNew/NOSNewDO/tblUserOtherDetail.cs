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
    
    public partial class tblUserOtherDetail
    {
        public int OtherDetailsId { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string OtherDetailsTypeId { get; set; }
        public string NameOfTheAward { get; set; }
        public Nullable<int> NatureOfAwardId { get; set; }
        public string NameAndAddress { get; set; }
        public string Title { get; set; }
        public Nullable<int> YearId { get; set; }
        public Nullable<int> NatureOfTheGuideShipId { get; set; }
        public string SactionNumber { get; set; }
        public Nullable<System.DateTime> SactionDate { get; set; }
        public string CertificateNumber { get; set; }
        public Nullable<System.DateTime> CertificateDate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}