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
    
    public partial class tblBiometricEmpNIMRA
    {
        public int BioEmpPKId { get; set; }
        public int UserId { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string BioId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}