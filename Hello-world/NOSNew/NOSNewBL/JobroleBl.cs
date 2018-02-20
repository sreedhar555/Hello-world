using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOSNewDO;
using NOSNewDAL;

namespace NOSNewBL
{
    class JobroleBl
    {
    }
    public class JobroleDetailBl
    {
        JobroleDetailDal objDAL = new JobroleDetailDal();
        public int SaveJobRoleDetail(SaveJobRoleDO objDO)
        {
            return objDAL.SaveJobRoleDetails(objDO);
        }
        public List<JobroleDO> SearchJobRoleDetail(JobroleSearchDO objDO)
        {
            return objDAL.SearchJobRoleDetails(objDO);
        }
        
        //public SaveJobRoleDO GetJobRoleId(int id)
        //{
        //    return objDAL.GetJobRoleId(id);
        //}
        public int UpdateJobRoleDetails(tblInstanceSubClassification obj)
        {
           return objDAL.UpdateJobRoleDetails(obj);
        }
        public SaveJobRoleDO GetTrainingDetailsById(int InstanceSubClassificationId)
        {
            SaveJobRoleDO objDO = new SaveJobRoleDO();
            objDO = objDAL.GetTrainingDetailsById(InstanceSubClassificationId);
            return objDO;
        }
        public int UpdateJobROleDetails(SaveJobRoleDO objDO)
        {
            return objDAL.UpdateJobROleDetails(objDO);
        }
        public int JobRoleDetails(JobroleSaveDO objDO)
        {
            return objDAL.JobRoleDetails(objDO);
        }
        public int SaveJobRoleDetailsForTL(JobroleSaveDO objDO)
        {
            return objDAL.JobRoleDetails(objDO);
        }
    }
}
