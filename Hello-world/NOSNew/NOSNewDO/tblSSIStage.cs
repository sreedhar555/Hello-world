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
    
    public partial class tblSSIStage
    {
        public int SSIID { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public string SSIName { get; set; }
        public string SendEmailSMS { get; set; }
        public Nullable<bool> IsActiveMeeting { get; set; }
        public string WhomToShow { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public Nullable<int> LevelID { get; set; }
        public Nullable<bool> IsProgramLeader { get; set; }
        public Nullable<bool> IsClassTeacher { get; set; }
        public Nullable<bool> ISCounsellor { get; set; }
        public Nullable<bool> IsAdmin { get; set; }
    }
}
