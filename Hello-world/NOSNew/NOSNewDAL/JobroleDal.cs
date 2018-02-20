using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOSNewDO;
namespace NOSNewDAL
{
    class JobroleDal
    {
    }
    public class JobroleDetailDal
    {
        OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();
        public int SaveJobRoleDetails(SaveJobRoleDO objDO)
        {
            int resultStatus = 0;
            var result = db.stp_tblJobRole_INSERT_SSC(objDO.InstanceId, objDO.InstanceClassificationId, objDO.SubClassificationName, objDO.SubClassificationDescription, objDO.ResultsModeId, objDO.CreatedBy, DateTime.Now);
            if (result > 0)
            {
                resultStatus = 1;
            }
            else
            {
                resultStatus = result;
            }
            return resultStatus;
        }
        public List<JobroleDO> SearchJobRoleDetails(JobroleSearchDO objDO)
        {
            List<JobroleDO> objList = new List<JobroleDO>();
            var result = db.stp_GetJobRoles(objDO.InstanceId, objDO.InstanceClassificationId);
            if (result != null)
            {
                foreach (var item in result)
                {
                    JobroleDO objNew = new JobroleDO();
                    objNew.InstanceSubClassificationId = item.InstanceSubClassificationId;
                    objNew.SubClassificationName = item.SubClassificationName;
                    objNew.SubClassificationDescription = item.SubClassificationDescription;
                    objList.Add(objNew);
                }
            }
            return objList;
        }
        public int UpdateJobRoleDetails(tblInstanceSubClassification obj)
        {
            var result = (from s in db.tblInstanceSubClassifications where s.InstanceSubClassificationId == obj.InstanceSubClassificationId select s).SingleOrDefault();
            SaveJobRoleDO objNew = new SaveJobRoleDO();

            objNew.InstanceId = Convert.ToInt32(obj.InstanceId);
            objNew.InstanceClassificationId = Convert.ToInt32(obj.InstanceClassificationId);
            objNew.InstanceSubClassificationId = Convert.ToInt32(obj.InstanceSubClassificationId);
            objNew.SubClassificationName = obj.SubClassificationName;
            objNew.SubClassificationDescription = obj.SubClassificationDescription;
            objNew.ResultsModeId = Convert.ToInt32(obj.ResultsModeId);
            if (db.SaveChanges() > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public SaveJobRoleDO GetTrainingDetailsById(int InstanceSubClassificationId)
        {
            SaveJobRoleDO objDO = new SaveJobRoleDO();
            var result = db.STP_tblInstanceSubClassification_GetJobRoleById(InstanceSubClassificationId);

            if (result != null)
            {
                foreach (var item in result)
                {
                    objDO.InstanceId = Convert.ToInt32(item.InstanceId);
                    objDO.InstanceClassificationId = Convert.ToInt32(item.InstanceClassificationId);
                    objDO.InstanceSubClassificationId = Convert.ToInt32(item.InstanceSubClassificationId);
                    objDO.SubClassificationName = item.SubClassificationName;
                    objDO.SubClassificationDescription = item.SubClassificationDescription;
                    objDO.ResultsModeId = Convert.ToInt32(item.ResultsModeId);
                }
            }

            return objDO;
        }
        public int UpdateJobROleDetails(SaveJobRoleDO objDO)
        {


            var result = db.stp_tblJobRole_UPDATE_SSC(objDO.InstanceId, objDO.InstanceSubClassificationId, objDO.InstanceClassificationId, objDO.SubClassificationName,
                                                          objDO.SubClassificationDescription, objDO.ResultsModeId, objDO.CreatedBy, DateTime.Now);
            var returnStatus = 0;
            if (result != null)
            {
                foreach (var item in result)
                {

                    returnStatus = item.Value;
                }
            }

            return returnStatus;
        }
        public int JobRoleDetails(JobroleSaveDO objDO)
        {
            int resultStatus = 0;
            var result = db.stp_TBLTLJobroles_Insert(objDO.TrainingLlocationsID, objDO.SSCId, objDO.JobRoleId, "", objDO.CreatedBy, DateTime.Now, objDO.Updatedby, DateTime.Now);
            if (result > 0)
            {
                resultStatus = 1;
            }
            else
            {
                resultStatus = result;
            }
            return resultStatus;
        }
    }
}
