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
    
    public partial class tblAssetDetail
    {
        public int AssetDetailsId { get; set; }
        public int InstanceId { get; set; }
        public int MainCategoryId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public string AssetName { get; set; }
        public string AssetDescription { get; set; }
        public string IdNumber { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string AssetType { get; set; }
        public Nullable<System.DateTime> DateOfPurchase { get; set; }
        public Nullable<int> PurchaseTimeInHrs { get; set; }
        public Nullable<int> PurchaseTimeInMins { get; set; }
        public Nullable<System.DateTime> ReplacementDate { get; set; }
        public Nullable<System.DateTime> PreviousServiceDate { get; set; }
        public Nullable<System.DateTime> NextServiceDate { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string VerdorMobileNumber { get; set; }
        public Nullable<System.DateTime> WarrentyStartDate { get; set; }
        public Nullable<System.DateTime> WarrentyEndDate { get; set; }
        public Nullable<int> NoOfYearsOfWarrenty { get; set; }
        public string WarrentyStatus { get; set; }
        public string AssetLocation { get; set; }
        public Nullable<decimal> AssetValue { get; set; }
        public Nullable<System.DateTime> ManufacturedDate { get; set; }
        public string RoomNo { get; set; }
        public string Floor { get; set; }
        public Nullable<int> AssetAssignedTo { get; set; }
        public string ImageOfAsset { get; set; }
        public string AssetStatus { get; set; }
        public Nullable<int> AssetModeId { get; set; }
        public Nullable<int> NonMovableMainCategoryId { get; set; }
        public Nullable<int> NonMovableCategoryId { get; set; }
        public Nullable<int> NonMovableSubCategoryId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}