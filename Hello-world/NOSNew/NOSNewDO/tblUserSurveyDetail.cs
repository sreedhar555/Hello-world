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
    
    public partial class tblUserSurveyDetail
    {
        public int UserSurveyID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> SurveyDetailsID { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public Nullable<int> Answer1Rating1 { get; set; }
        public Nullable<int> Answer1Rating2 { get; set; }
        public Nullable<int> Answer1Rating3 { get; set; }
        public Nullable<int> PaperType { get; set; }
        public string Paper2Rating { get; set; }
        public Nullable<int> LastAttemptedQuestionId { get; set; }
        public string timetocomplete { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}