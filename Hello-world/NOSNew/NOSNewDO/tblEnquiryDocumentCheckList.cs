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
    
    public partial class tblEnquiryDocumentCheckList
    {
        public int EnquiryDocumentCheckListID { get; set; }
        public Nullable<int> InstanceID { get; set; }
        public int InstanceClassificationId { get; set; }
        public Nullable<int> InstanceSubClassificationId { get; set; }
        public int DocumentId { get; set; }
        public Nullable<int> SubmissionType { get; set; }
        public int IsMandatory { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> Deleteflag { get; set; }
    }
}
