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
    
    public partial class tblOnlineTestQuestionnaire
    {
        public int OnlineTestQuestionnaireId { get; set; }
        public int InstanceId { get; set; }
        public int OnlineTestId { get; set; }
        public string Question { get; set; }
        public string QuestionFileName { get; set; }
        public Nullable<double> QuestionFileSize { get; set; }
        public int Complexity { get; set; }
        public Nullable<int> QuestionTypeId { get; set; }
        public Nullable<int> ParentQuestionId { get; set; }
        public Nullable<byte> ModeOfQuestion { get; set; }
        public Nullable<bool> IsMandatory { get; set; }
        public Nullable<bool> IsNestedType { get; set; }
        public Nullable<int> NumberOfNestedQuestions { get; set; }
        public Nullable<double> Marks { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public Nullable<int> Section { get; set; }
    }
}
