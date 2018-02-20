using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOSNewDO;

namespace NOSNewDAL
{
    public class SSCDAL
    {
        OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();

        public List<SSCDO> GetSSCByInstanceId(string InstanceId)
        {
            List<SSCDO> objList = new List<SSCDO>();

            var result = db.stp_GetLogistics(Convert.ToInt32(InstanceId)).ToList();

            if (result != null)
            {
                foreach (var item in result)
                {
                    SSCDO objNew = new SSCDO();

                    //objNew.GlobalLogisticsId = item.GlobalLogisticsId;
                    //objNew.LogisticsName = item.LogisticsName;
                    objNew.InstanceClassificationId = item.InstanceClassificationId;
                    objNew.ClassificationName = item.ClassificationName;
                    //objNew.Code = item.Code;

                    objList.Add(objNew);
                }
            }

            return objList;
        }

        //    public List<SSCDO> GetClassificationsByInstanceId(int InstanceId)
        //    {
        //        List<SSCDO> objList = new List<SSCDO>();
        //        var result = db.stp_tblInstanceClassification_GetByInstanceId(InstanceId).ToList();

        //        if (result != null)
        //        {
        //            if (result.Count > 0)
        //            {
        //                foreach (var item in result)
        //                {
        //                    SSCDO objDO = new SSCDO();
        //                    objDO.InstanceClassificationId = item.InstanceClassificationId;
        //                    objDO.ClassificationName = item.ClassificationName;

        //                    objList.Add(objDO);
        //                }
        //            }
        //        }
        //        return objList;
        //    }
        //    public List<SSCDO> GetSSCByInstanceIdReport(int InstanceId)
        //    {
        //        List<SSCDO> objList = new List<SSCDO>();

        //        var result = db.stp_tblInstanceClassification_GetByInstanceId(InstanceId);

        //        if (result != null)
        //        {
        //            foreach (var item in result)
        //            {
        //                SSCDO objNew = new SSCDO();

        //                objNew.InstanceClassificationId = item.InstanceClassificationId;
        //                objNew.ClassificationName = item.ClassificationName;
        //                objNew.ProgramType = Convert.ToInt32(item.ProgramType);

        //                objList.Add(objNew);
        //            }
        //        }

        //        return objList;
        //    }
        }

        public class JobRoleDAL
        {
            OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();

            public List<JobRoleDO> GetJobRoleBySSCId(string InstanceId, string SSCId)
            {
                List<JobRoleDO> objList = new List<JobRoleDO>();

                var result = db.stp_GetJobRoles(Convert.ToInt32(InstanceId), Convert.ToInt32(SSCId)).ToList();

                if (result != null)
                {
                    foreach (var item in result)
                    {
                        JobRoleDO objNew = new JobRoleDO();

                        //objNew.GlobalJobRoleId = item.GlobalJobRoleId;
                        //objNew.JobRole = item.JobRole;
                        objNew.InstanceSubClassificationId = item.InstanceSubClassificationId;
                        objNew.SubClassificationName = item.SubClassificationName;

                        objList.Add(objNew);
                    }
                }

                return objList;
            }
            //    public List<JobRoleDO> GetInstanceSpecificJobRoleBySSCId(string InstanceId, string SSCId)
            //    {
            //        List<JobRoleDO> objList = new List<JobRoleDO>();

            //        var result = db.stp_tblInstanceSubClassification_GetByClassificationIdAndUserID(Convert.ToInt32(InstanceId), Convert.ToInt32(SSCId), null).ToList();

            //        if (result != null)
            //        {
            //            foreach (var item in result)
            //            {
            //                JobRoleDO objNew = new JobRoleDO();

            //                objNew.InstanceSubClassificationId = item.InstanceSubClassificationId;
            //                objNew.SubClassificationName = item.SubClassificationName;

            //                objList.Add(objNew);
            //            }
            //        }

            //        return objList;
            //    }


            }

            //public class SchemeListDAL
            //{
            //    OnlineTestDBEntities db = new OnlineTestDBEntities();
            //    public List<SchemeListDO> GetSchemeListByCodeName(string CodeName)
            //    {
            //        List<SchemeListDO> objList = new List<SchemeListDO>();

            //        var result = db.STP_GetCommonDataByCodeName(CodeName);

            //        if (result != null)
            //        {
            //            foreach (var item in result)
            //            {
            //                SchemeListDO objNew = new SchemeListDO();

            //                objNew.ID = item.ID;
            //                objNew.value = item.value;
            //                objNew.Data = item.Data;
            //                objNew.Code = item.Code;

            //                objList.Add(objNew);
            //            }
            //        }

            //        return objList;
            //    }

            //}

            //public class UsersListDAL
            //{
            //    OnlineTestDBEntities db = new OnlineTestDBEntities();
            //    public List<UsersListDO> GetAssessorList(OtherSpsParamsDO objDO)
            //    {
            //        List<UsersListDO> objList = new List<UsersListDO>();

            //        var result = db.stp_GetAssessorsusersByClassSubclass(objDO.InstanceId, objDO.RoleName, objDO.InstanceClassificationId.ToString(), objDO.InstanceSubClassificationId.ToString()).ToList();

            //        if (result != null)
            //        {
            //            foreach (var item in result)
            //            {
            //                UsersListDO objNew = new UsersListDO();

            //                objNew.RoleUserId = item.RoleUserId;
            //                objNew.RoleUserName = item.RoleUserName;

            //                objList.Add(objNew);
            //            }
            //        }

            //        return objList;
            //    }

            //    public List<UsersListDO> GetManagerList(int InstanceId, string RoleName)
            //    {
            //        List<UsersListDO> objList = new List<UsersListDO>();

            //        var result = db.stp_tblUser_tblInstanceRole_GetUserByRoleName(InstanceId, RoleName).ToList();

            //        if (result != null)
            //        {
            //            foreach (var item in result)
            //            {
            //                UsersListDO objNew = new UsersListDO();

            //                objNew.RoleUserId = item.RoleUserId;
            //                objNew.RoleUserName = item.RoleUserName;

            //                objList.Add(objNew);
            //            }
            //        }

            //        return objList;
            //    }
            //}

            //public class TemplateListDAL
            //{
            //    OnlineTestDBEntities db = new OnlineTestDBEntities();
            //    public List<TemplateListDO> GetTemplateList()
            //    {
            //        List<TemplateListDO> objList = new List<TemplateListDO>();

            //        var result = db.stp_tblOnlinetestTemplates_ALL().ToList();

            //        if (result != null)
            //        {
            //            foreach (var item in result)
            //            {
            //                TemplateListDO objNew = new TemplateListDO();

            //                objNew.OnlineTestTemplateId = item.OnlineTestTemplateId;
            //                objNew.TemplateName = item.TemplateName;

            //                objList.Add(objNew);
            //            }
            //        }

            //        return objList;
            //    }
            //}

            //public class ExamListDAL
            //{
            //    OnlineTestDBEntities db = new OnlineTestDBEntities();

            //    public List<ExamListDO> GetExamsList(int InstanceId, Nullable<int> ExamForAcademics)
            //    {
            //        List<ExamListDO> objList = new List<ExamListDO>();

            //        var result = db.stp_tblInstanceExams_GetExams(InstanceId, ExamForAcademics).ToList().OrderBy(x => x.DisplayOrder).ToList();

            //        if (result != null)
            //        {
            //            foreach (var item in result)
            //            {
            //                ExamListDO objNew = new ExamListDO();

            //                objNew.ExamId = item.ExamId;
            //                objNew.ExamName = item.ExamName;

            //                objList.Add(objNew);
            //            }
            //        }

            //        return objList;
            //    }
            //}

            //public class SubjectListDAL
            //{
            //    OnlineTestDBEntities db = new OnlineTestDBEntities();
            //    public List<SubjectListDO> GetSubjectList(int InstanceId, int ClassificationId)
            //    {
            //        List<SubjectListDO> objList = new List<SubjectListDO>();

            //        var result = db.stp_GETSUBJECTSBYCLASS(ClassificationId, InstanceId).ToList();

            //        if (result != null)
            //        {
            //            foreach (var item in result)
            //            {
            //                SubjectListDO objNew = new SubjectListDO();

            //                objNew.SubjectId = item.SubjectId;
            //                objNew.SubjectName = item.SubjectName;

            //                objList.Add(objNew);
            //            }
            //        }

            //        return objList;
            //    }
            //}

            //public class TheroyListDAL
            //{
            //    OnlineTestDBEntities db = new OnlineTestDBEntities();
            //    public List<TheroyListDO> GetTheoryList(int InstanceId, int ClassificationId, int subClassificationId)
            //    {
            //        List<TheroyListDO> objList = new List<TheroyListDO>();

            //        var result = db.stp_tblonlinetestlatest_GetThoeryList(InstanceId, ClassificationId, subClassificationId).ToList();

            //        if (result != null)
            //        {
            //            foreach (var item in result)
            //            {
            //                TheroyListDO objNew = new TheroyListDO();

            //                objNew.ReferanceTheroyId = item.ReferanceTheroyId;
            //                objNew.TheoryName = item.TheoryName;

            //                objList.Add(objNew);
            //            }
            //        }

            //        return objList;
            //    }
            //}
            //public class TemplateDetailsDAL
            //{
            //    OnlineTestDBEntities db = new OnlineTestDBEntities();
            //    public List<TemplateDetailsDO> GetTemplateDetailsList(int templateId)
            //    {
            //        List<TemplateDetailsDO> objList = new List<TemplateDetailsDO>();

            //        var result = db.Stp_CreateTestSettings(templateId).ToList();

            //        if (result != null)
            //        {
            //            foreach (var item in result)
            //            {
            //                TemplateDetailsDO objNew = new TemplateDetailsDO();
            //                objNew.IsRandomQuestionsFrom = item.IsRandomQuestionsFrom;
            //                objNew.IsRandomAnswers = item.IsRandomAnswers;
            //                objNew.DisplayResultsPerQuestion = item.DisplayResultsPerQuestion;
            //                objNew.DisplayIncorrect = item.DisplayIncorrect;
            //                objNew.Noofattemptsallowed = item.Noofattemptsallowed;
            //                objNew.IsBackOption = item.IsBackOption;
            //                objNew.IsNegativeMarking = item.IsNegativeMarking;
            //                objNew.IsAnswerMust = item.IsAnswerMust;
            //                objNew.OnlineTestMarksTypeId = item.OnlineTestMarksTypeId;
            //                objNew.IsHeader = item.IsHeader;
            //                objNew.HeaderText = item.HeaderText;
            //                objNew.LogoName = item.LogoName;
            //                objNew.Logosize = item.Logosize;
            //                objNew.SlotBooking = item.SlotBooking;
            //                objList.Add(objNew);
            //            }
            //        }

            //        return objList;
            //    }
            //}
            public class StateListDAL
    {
        OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();

        public List<StateListDO> GetStates(int CountryId)
        {
            List<StateListDO> obj = new List<StateListDO>();

            var result = db.stp_tblState_SELByCountryId(CountryId).ToList();

            foreach (var item in result)
            {
                StateListDO objItem = new StateListDO();
                objItem.StateId = item.StateId;
                objItem.StateName = item.StateName;


                obj.Add(objItem);
            }

            return obj;
        }
    }

}
