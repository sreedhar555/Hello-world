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
    
    public partial class tblEResourceItems1
    {
        public int EResourceId { get; set; }
        public int InstanceId { get; set; }
        public int MainCategoryId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> SubCategoryId { get; set; }
        public string EResourceName { get; set; }
        public string Code { get; set; }
        public string Comments { get; set; }
        public Nullable<int> TotalUnits { get; set; }
        public Nullable<int> AvailableUnits { get; set; }
        public string Capacity { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string Location { get; set; }
        public Nullable<int> NoShowTime { get; set; }
        public Nullable<int> UnitLimit { get; set; }
        public string BookingLimit { get; set; }
        public Nullable<bool> Needworkflow { get; set; }
        public Nullable<bool> CheckConcurrency { get; set; }
        public string CostPerDay { get; set; }
        public string Facilities { get; set; }
        public Nullable<int> BookingType { get; set; }
        public string CommentsForUser { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    
        public virtual tblInstanceCategory tblInstanceCategory { get; set; }
        public virtual tblInstanceCategory tblInstanceCategory1 { get; set; }
    }
}
