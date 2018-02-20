using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOSNewDAL;
using NOSNewDO;

namespace NOSNewBL
{
    class BindingListsBL
    {
    }

    public class SSCBL
    {
        SSCDAL objDAL = new SSCDAL();
        public List<SSCDO> GetSSCByInstanceId(string InstanceId)
        {
            List<SSCDO> objList = new List<SSCDO>();
            objList = objDAL.GetSSCByInstanceId(InstanceId);
            return objList;
        }
        //public List<SSCDO> GetClassificationsByInstanceId(int InstanceId)
        //{
        //    List<SSCDO> objList = new List<SSCDO>();
        //    objList = objDAL.GetClassificationsByInstanceId(InstanceId);
        //    return objList;
        //}
        //public List<SSCDO> GetSSCByInstanceIdReport(int InstanceId)
        //{
        //    List<SSCDO> objList = new List<SSCDO>();
        //    objList = objDAL.GetSSCByInstanceIdReport(InstanceId);
        //    return objList;
        //}
    }
    public class JobRoleBL
    {
        public List<JobRoleDO> GetJobRoleBySSCId(string InstanceId, string SSCId)
        {
            List<JobRoleDO> objList = new List<JobRoleDO>();
            JobRoleDAL objDAL = new JobRoleDAL();
            objList = objDAL.GetJobRoleBySSCId(InstanceId, SSCId);
            return objList;
        }

        //    public List<JobRoleDO> GetInstanceSpecificJobRoleBySSCId(string InstanceId, string SSCID)
        //    {
        //        List<JobRoleDO> objList = new List<JobRoleDO>();
        //        JobRoleDAL objDAL = new JobRoleDAL();
        //        objList = objDAL.GetInstanceSpecificJobRoleBySSCId(InstanceId, SSCID);
        //        return objList;
        //    }

        }

        //public class SchemeListBL
        //{
        //    public List<SchemeListDO> GetSchemeListByCodeName(string CodeName)
        //    {
        //        List<SchemeListDO> objList = new List<SchemeListDO>();
        //        SchemeListDAL objDAL = new SchemeListDAL();
        //        objList = objDAL.GetSchemeListByCodeName(CodeName);
        //        return objList;
        //    }
        //}

        //public class UsersListBL
        //{
        //    public List<UsersListDO> GetAssessorList(OtherSpsParamsDO objDO)
        //    {
        //        UsersListDAL objDAL = new UsersListDAL();
        //        return objDAL.GetAssessorList(objDO);
        //    }


        //    public List<UsersListDO> GetManagerList(int InstanceId, string RoleName)
        //    {
        //        UsersListDAL objDAL = new UsersListDAL();
        //        return objDAL.GetManagerList(InstanceId, RoleName);
        //    }
        //}

        //public class TemplateListBL
        //{
        //    public List<TemplateListDO> GetTemplateList()
        //    {
        //        TemplateListDAL objDAL = new TemplateListDAL();
        //        return objDAL.GetTemplateList();
        //    }
        //}

        //public class ExamListBL
        //{
        //    public List<ExamListDO> GetExamsList(int InstanceId, Nullable<int> ExamForAcademics)
        //    {
        //        ExamListDAL objDAL = new ExamListDAL();
        //        return objDAL.GetExamsList(InstanceId, ExamForAcademics);
        //    }
        //}

        //public class SubjectListBL
        //{
        //    public List<SubjectListDO> GetSubjectList(int InstanceId, int ClassificationId)
        //    {
        //        SubjectListDAL objDAL = new SubjectListDAL();
        //        return objDAL.GetSubjectList(InstanceId, ClassificationId);
        //    }
        //}

        //public class TheroyListBL
        //{
        //    public List<TheroyListDO> GetTheoryList(int InstanceId, int ClassificationId, int subClassificationId)
        //    {
        //        TheroyListDAL objDAL = new TheroyListDAL();
        //        return objDAL.GetTheoryList(InstanceId, ClassificationId, subClassificationId);
        //    }
        //}
        //public class TemplateDetailsBL
        //{
        //    public List<TemplateDetailsDO> GetTemplateDetailsList(int templateId)
        //    {
        //        TemplateDetailsDAL objDAL = new TemplateDetailsDAL();
        //        return objDAL.GetTemplateDetailsList(templateId);
        //    }
        //}
        public class StateListBL
        {
            public List<StateListDO> GetStates(int CountryId)
            {
                List<StateListDO> obj = new List<StateListDO>();
                StateListDAL objDal = new StateListDAL();
                obj = objDal.GetStates(CountryId);
                return obj;
            }
        }

    
}
