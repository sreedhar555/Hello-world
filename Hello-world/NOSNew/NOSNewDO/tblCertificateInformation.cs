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
    
    public partial class tblCertificateInformation
    {
        public int ID { get; set; }
        public int SLNO { get; set; }
        public int InstanceID { get; set; }
        public int UserID { get; set; }
        public string FromAcademicYear { get; set; }
        public string ToAcademicYear { get; set; }
        public Nullable<double> AttendancePercentage { get; set; }
        public string Conduct { get; set; }
        public int Is_Conduct { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}