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
    
    public partial class tblAdvertisement
    {
        public int AdvertisementId { get; set; }
        public int InstanceId { get; set; }
        public Nullable<int> AdvtsCustomerId { get; set; }
        public string Image { get; set; }
        public string ImageURL { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public string Alignment { get; set; }
        public Nullable<int> RepeatInterval { get; set; }
        public Nullable<int> NumOfClicks { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    
        public virtual tblAdvtsCustomer tblAdvtsCustomer { get; set; }
    }
}
