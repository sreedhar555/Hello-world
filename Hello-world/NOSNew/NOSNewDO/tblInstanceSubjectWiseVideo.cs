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
    
    public partial class tblInstanceSubjectWiseVideo
    {
        public int SubjectVideoId { get; set; }
        public int InstanceId { get; set; }
        public string ClassificationId { get; set; }
        public string SubClassificationId { get; set; }
        public string SubjectId { get; set; }
        public string SubjectToolId { get; set; }
        public string VideoPath { get; set; }
        public Nullable<bool> IsRestriction { get; set; }
        public Nullable<int> Duration { get; set; }
        public string DisplayName { get; set; }
        public Nullable<int> Points { get; set; }
        public Nullable<int> IsSubjectWiseVodeo { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> TimeHours { get; set; }
        public Nullable<int> TimeMinutes { get; set; }
        public Nullable<int> TimeSeconds { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public Nullable<int> OnlineTestID { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
        public string FileName { get; set; }
        public Nullable<bool> VideoUploaded { get; set; }
    }
}
