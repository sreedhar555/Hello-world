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
    
    public partial class tblStudentLeaveApprover
    {
        public int ApproverPKId { get; set; }
        public int InstanceId { get; set; }
        public Nullable<int> ApproverId { get; set; }
        public Nullable<int> LevelId { get; set; }
        public Nullable<int> ApplyingUser { get; set; }
        public Nullable<int> SubClassificationId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> Updatedby { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
