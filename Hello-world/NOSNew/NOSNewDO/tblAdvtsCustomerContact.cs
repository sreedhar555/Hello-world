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
    
    public partial class tblAdvtsCustomerContact
    {
        public int AdvtsCustomerContactId { get; set; }
        public Nullable<int> AdvtsCustomerId { get; set; }
        public Nullable<int> ContactTypeId { get; set; }
        public string CustomerContactName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Nullable<int> StateId { get; set; }
        public string OtherState { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string Zip { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string HomePhoneExtension { get; set; }
        public string WorkPhone { get; set; }
        public string WorkPhoneExtension { get; set; }
        public string Fax { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    
        public virtual tblAdvtsContactType tblAdvtsContactType { get; set; }
        public virtual tblAdvtsCustomer tblAdvtsCustomer { get; set; }
    }
}