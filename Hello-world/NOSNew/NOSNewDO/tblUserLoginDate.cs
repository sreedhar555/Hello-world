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
    
    public partial class tblUserLoginDate
    {
        public int Pk_Id { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string UserName { get; set; }
        public string PageUrl { get; set; }
        public string IpAddress { get; set; }
        public string BrowserVersion { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> Deleteflag { get; set; }
    }
}
