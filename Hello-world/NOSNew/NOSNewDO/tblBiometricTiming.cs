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
    
    public partial class tblBiometricTiming
    {
        public int TimingsPKId { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public string Role { get; set; }
        public Nullable<int> LateInHrs { get; set; }
        public Nullable<int> LateInMins { get; set; }
        public Nullable<int> EarlyOutHrs { get; set; }
        public Nullable<int> EarlyOutMins { get; set; }
        public Nullable<int> SessionTime { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
