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
    
    public partial class tblRequestRequisitionsList
    {
        public int RequistionsListID { get; set; }
        public int RequestID { get; set; }
        public int ProvisionTypeID { get; set; }
        public string ItemName { get; set; }
        public string Quantity { get; set; }
        public string ItemDescription { get; set; }
        public Nullable<bool> IsTransport { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
