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
    
    public partial class tblBusDiaryFuel
    {
        public int BusDiaryFuelId { get; set; }
        public int BusDiaryId { get; set; }
        public int FuelTypeId { get; set; }
        public Nullable<decimal> FuelFillingQty { get; set; }
        public Nullable<int> FuelFillStationID { get; set; }
        public string FuelFillingStation { get; set; }
        public Nullable<decimal> AmountSpent { get; set; }
        public Nullable<System.DateTime> FuelFillingDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> Deleteflag { get; set; }
        public Nullable<decimal> FuelConsumed { get; set; }
        public Nullable<decimal> KmReading { get; set; }
        public Nullable<decimal> Average { get; set; }
    }
}
