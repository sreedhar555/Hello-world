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
    
    public partial class tblEBlog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEBlog()
        {
            this.tblEBlogComments = new HashSet<tblEBlogComment>();
        }
    
        public int EBlogId { get; set; }
        public int InstanceId { get; set; }
        public int OwnerId { get; set; }
        public Nullable<int> EBlogTypeId { get; set; }
        public string Title { get; set; }
        public string EBlogDescription { get; set; }
        public string EBlogURL { get; set; }
        public string Tags { get; set; }
        public Nullable<int> EBlogTemplateId { get; set; }
        public Nullable<bool> AllowComments { get; set; }
        public Nullable<bool> Published { get; set; }
        public Nullable<bool> IsAbusive { get; set; }
        public Nullable<bool> GirlsOnly { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEBlogComment> tblEBlogComments { get; set; }
    }
}