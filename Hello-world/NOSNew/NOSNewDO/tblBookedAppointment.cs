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
    
    public partial class tblBookedAppointment
    {
        public int BookedAppId { get; set; }
        public Nullable<int> AppointmentId { get; set; }
        public int BookedBy { get; set; }
        public System.DateTime AppointmentDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsRejected { get; set; }
        public string RejectedReason { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    
        public virtual tblEAppointment tblEAppointment { get; set; }
    }
}
