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
    
    public partial class tblStoredProcedure
    {
        public int StoredProcedureID { get; set; }
        public string StoredProcedureName { get; set; }
        public Nullable<bool> HasParameters { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public string ExcelFileName { get; set; }
        public string ExcelSheetName { get; set; }
        public string SavePath { get; set; }
        public string ToList { get; set; }
        public string CCList { get; set; }
        public string BCCList { get; set; }
        public string Heading { get; set; }
        public string SubHeading { get; set; }
        public Nullable<int> SameExcelSheetSPId { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
