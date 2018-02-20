using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewDO
{
    public class NEWDO
    {

    }
    public class BindingListSearchDO
    {
        public int InstanceClassificationId { get; set; }
        public int InstanceSubClassificationId { get; set; }

        public int InstanceId { get; set; }
    }

    public class SSCDO
    {
        public int GlobalLogisticsId { get; set; }
        public string LogisticsName { get; set; }
        public int InstanceClassificationId { get; set; }
        public string ClassificationName { get; set; }
        public Nullable<int> Code { get; set; }
        public int ProgramType { get; set; }
    }

    public class JobRoleDO
    {
        public int GlobalJobRoleId { get; set; }
        public string JobRole { get; set; }
        public int InstanceSubClassificationId { get; set; }
        public string SubClassificationName { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime AttendanceEffectiveDate { get; set; }

    }

    public class SchemeListDO
    {
        public int ID { get; set; }
        public int value { get; set; }
        public string Data { get; set; }
        public string Code { get; set; }
    }

    public class UsersListDO
    {
        public int RoleUserId { get; set; }
        public string RoleUserName { get; set; }

    }

    public class OtherSpsParamsDO
    {
        public int InstanceId { get; set; }
        public string RoleName { get; set; }
        public int InstanceClassificationId { get; set; }
        public int InstanceSubClassificationId { get; set; }
    }

    public class TimeListParamsDO
    {
        public string TextHour { get; set; }
        public string ValueHour { get; set; }
        public string TextMinute { get; set; }
        public string ValueMinute { get; set; }
    }

   public class TemplateListDO
    {
        public int OnlineTestTemplateId { get; set; }
        public string TemplateName { get; set; }
    }

    public class ExamListDO
    {
        public int ExamId { get; set; }
        public string ExamName { get; set; }
    }

    public class SubjectListDO
    {
        public Nullable<int> SubjectId { get; set; }
        public string SubjectName { get; set; }
    }

    public class TheroyListDO
    {
        public int ReferanceTheroyId { get; set; }
        public string TheoryName { get; set; }
    }

    public class TemplateDetailsDO
    {
        public Nullable<int> IsRandomQuestionsFrom { get; set; }
        public Nullable<int> IsRandomAnswers { get; set; }
        public Nullable<int> DisplayResultsPerQuestion { get; set; }
        public Nullable<int> DisplayIncorrect { get; set; }
        public Nullable<int> Noofattemptsallowed { get; set; }
        public Nullable<bool> IsBackOption { get; set; }
        public Nullable<bool> IsNegativeMarking { get; set; }
        public Nullable<bool> IsAnswerMust { get; set; }
        public Nullable<int> OnlineTestMarksTypeId { get; set; }
        public Nullable<bool> IsHeader { get; set; }
        public string HeaderText { get; set; }
        public string LogoName { get; set; }
        public Nullable<double> Logosize { get; set; }
        public Nullable<int> SlotBooking { get; set; }
    }

    public class AssessmentDO
    {
        public int InstanceId { get; set; }
        public int OnlineTestId { get; set; }
        public int NatureofTest { get; set; }
        public int OnlineTestTypeId { get; set; }
        public string Title { get; set; }
        public double Marks { get; set; }
        public Nullable<int> IsRandomQuestionsFrom { get; set; }
        public Nullable<bool> IsRandomAnswers { get; set; }
        public Nullable<int> DisplayResultsPerQuestion { get; set; }
        public Nullable<int> DisplayIncorrect { get; set; }
        public Nullable<int> Noofattemptsallowed { get; set; }
        public Nullable<bool> IsBackOption { get; set; }
        public Nullable<bool> IsNegativeMarking { get; set; }
        public Nullable<bool> IsAnswerMust { get; set; }
        public Nullable<int> OnlineTestMarksTypeId { get; set; }
        public Nullable<bool> IsHeader { get; set; }
        public string HeaderText { get; set; }
        public string LogoName { get; set; }
        public Nullable<double> Logosize { get; set; }
        public Nullable<int> ExamId { get; set; }
        public Nullable<int> globalSubjectId { get; set; }
        public Nullable<bool> IsAuthorize { get; set; }
        public Nullable<int> SlotBooking { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> ClassificationId { get; set; }
        public Nullable<int> SubClassificationId { get; set; }
        public Nullable<int> IsTheory { get; set; }
        public Nullable<int> ReferenceTheoryIdForPractical { get; set; }
        public Nullable<int> IsRandomQuestionUserWise { get; set; }
        public Nullable<int> GraceTime { get; set; }
    }
    public class StateListDO
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
    } 

}
