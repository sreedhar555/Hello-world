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
    
    public partial class tblGeoTagImage
    {
        public int ImageID { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public string PersonalDocumentSize { get; set; }
        public Nullable<int> DocumentType { get; set; }
        public int UserId { get; set; }
        public Nullable<int> AccessorId { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public string Location { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public string DeleteFlag { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<int> OnlineTestIdBasedOnUser { get; set; }
        public Nullable<int> OnlineSetIdBasedOnUser { get; set; }
    }
}
