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
    
    public partial class tblUserStatu
    {
        public int StatusId { get; set; }
        public int UserId { get; set; }
        public int InstanceId { get; set; }
        public Nullable<byte> FeeStatus { get; set; }
        public Nullable<byte> SlotStatus { get; set; }
        public string AptechUserName { get; set; }
        public string AptechPassword { get; set; }
        public int CreatedBY { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
