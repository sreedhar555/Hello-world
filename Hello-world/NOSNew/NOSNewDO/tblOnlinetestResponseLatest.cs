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
    
    public partial class tblOnlinetestResponseLatest
    {
        public int OnlineTestResponseId { get; set; }
        public Nullable<int> OnlineTestId { get; set; }
        public int OnlinetestSetId { get; set; }
        public Nullable<int> UseronlinetestDetailsId { get; set; }
        public Nullable<int> TestAttemptId { get; set; }
        public int QuestionnaireId { get; set; }
        public int UserId { get; set; }
        public Nullable<int> AnswerId { get; set; }
        public string StudentCorrectAnswer { get; set; }
        public string ReviewerCorrectAnswer { get; set; }
        public Nullable<double> Marks { get; set; }
        public Nullable<int> QuestionStatus { get; set; }
        public string timetocomplete { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}
