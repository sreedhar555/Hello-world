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
    
    public partial class tblBatchDetail
    {
        public int BatchId { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public Nullable<int> ClassificationId { get; set; }
        public Nullable<int> SubClassificationId { get; set; }
        public string BatchName { get; set; }
        public Nullable<System.DateTime> BatchStartDate { get; set; }
        public Nullable<System.DateTime> BatchEndDate { get; set; }
        public Nullable<int> BatchStartTimeHours { get; set; }
        public Nullable<int> BatchStartTimeMins { get; set; }
        public Nullable<int> BatchEndTimeHours { get; set; }
        public Nullable<int> BatchEndTimeMins { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}