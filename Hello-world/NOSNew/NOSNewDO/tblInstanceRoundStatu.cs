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
    
    public partial class tblInstanceRoundStatu
    {
        public int RoundStatusId { get; set; }
        public int RoundId { get; set; }
        public string RoundStatusName { get; set; }
        public string RoundStatusDescription { get; set; }
        public Nullable<int> StatusOrder { get; set; }
        public Nullable<bool> StatusType { get; set; }
        public Nullable<bool> IsInternal { get; set; }
        public string StatusShortName { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public Nullable<int> MasterRoundStatusId { get; set; }
    }
}
