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
    
    public partial class tblStudentWithdrawalCommentsDetail
    {
        public int CommentsDetailsID { get; set; }
        public int StudentwithdrawalStatusID { get; set; }
        public string MidSessionReportStatus { get; set; }
        public string GeneralConduct { get; set; }
        public Nullable<byte> Result { get; set; }
        public Nullable<byte> ProficiencyInCoCurricularActivites { get; set; }
        public Nullable<byte> ProficiencyInGames { get; set; }
        public Nullable<byte> IsClassTeacher { get; set; }
        public string MidSessionReportFileName { get; set; }
        public Nullable<byte> SupportsForExtra { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
