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
    
    public partial class tblSlot
    {
        public int SlotID { get; set; }
        public int InstanceID { get; set; }
        public Nullable<int> MasterSlotId { get; set; }
        public string SlotName { get; set; }
        public Nullable<bool> ConsiderInAnnual { get; set; }
        public Nullable<byte> AttendanceRequired { get; set; }
        public Nullable<int> DisplayFor { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    }
}
