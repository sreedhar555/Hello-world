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
    
    public partial class tblBulkAttendanceValidation
    {
        public int AttendanceValidationId { get; set; }
        public Nullable<int> InstanceID { get; set; }
        public Nullable<System.DateTime> AttendanceDate { get; set; }
        public string EmployeeId { get; set; }
        public string Reason { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> Deleteflag { get; set; }
        public string Sheetname { get; set; }
    }
}
