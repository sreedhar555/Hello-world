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
    
    public partial class tblEForm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEForm()
        {
            this.tblEFormActivities = new HashSet<tblEFormActivity>();
            this.tblEFormAuthorizations = new HashSet<tblEFormAuthorization>();
        }
    
        public int EFormId { get; set; }
        public int InstanceId { get; set; }
        public string EFormName { get; set; }
        public string EFormDocument { get; set; }
        public Nullable<double> DocSize { get; set; }
        public int CategoryId { get; set; }
        public Nullable<int> SubCategoryId { get; set; }
        public string Keyword { get; set; }
        public Nullable<int> AssignTo { get; set; }
        public Nullable<System.DateTime> Duedate { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<bool> SendSMS { get; set; }
        public Nullable<bool> SendEMail { get; set; }
        public Nullable<bool> IncludeParents { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEFormActivity> tblEFormActivities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEFormAuthorization> tblEFormAuthorizations { get; set; }
        public virtual tblInstanceCategory tblInstanceCategory { get; set; }
    }
}
