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
    
    public partial class tblQuestionBankQuestion
    {
        public int QuestionnaireId { get; set; }
        public int InstanceId { get; set; }
        public int QuestionBankDetailsId { get; set; }
        public int QuestionComplexityId { get; set; }
        public Nullable<int> QuestionStatus { get; set; }
        public Nullable<int> QuestionPriority { get; set; }
        public string Question { get; set; }
        public string QuestionFileName { get; set; }
        public Nullable<double> QuestionFileSize { get; set; }
        public Nullable<int> ParentQuestionId { get; set; }
        public int ModeOfQuestion { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsNestedType { get; set; }
        public Nullable<int> NumberOfNestedQuestions { get; set; }
        public double Marks { get; set; }
        public Nullable<double> NegativeMarks { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public string ContentLang { get; set; }
        public Nullable<int> RepeatedQuestionID { get; set; }
        public Nullable<int> QuestionNo { get; set; }
        public string QuestionTranslate { get; set; }
    }
}