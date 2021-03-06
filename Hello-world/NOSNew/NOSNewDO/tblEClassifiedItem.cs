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
    
    public partial class tblEClassifiedItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEClassifiedItem()
        {
            this.tblEClassifiedItemImages = new HashSet<tblEClassifiedItemImage>();
        }
    
        public int EClassifiedItemId { get; set; }
        public int InstanceId { get; set; }
        public int ParentCategoryId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string Subject { get; set; }
        public string EClassifiedDescription { get; set; }
        public Nullable<int> Availableunits { get; set; }
        public Nullable<int> ItemUsedYears { get; set; }
        public Nullable<int> Months { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public string EvaluatedBy { get; set; }
        public string RejectedReason { get; set; }
        public Nullable<int> NumOfViews { get; set; }
        public Nullable<bool> DontDisplay { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEClassifiedItemImage> tblEClassifiedItemImages { get; set; }
    }
}
