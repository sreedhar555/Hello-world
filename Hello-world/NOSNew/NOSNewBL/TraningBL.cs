using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOSNewDO;
using NOSNewDAL;

namespace NOSNewBL
{
    class TraningBL
    {
    }
    public class TraningLocBL
    {
        public int SaveTraningDetail(TraningLocDO objDO)
        {
            TraningLocDAL objDAL = new TraningLocDAL();
            return objDAL.SaveTraningDetails(objDO);
        }
        public List<TrainingDetailsDO> GetTrainingDetails(TrainingSearchDO objDO)
        {
            TraningLocDAL objDAL = new TraningLocDAL();
            return objDAL.GetTrainingDetails(objDO);
        }
        public TraningLocDO GetTrainingId(int id)
        {
            TraningLocDAL objDAL = new TraningLocDAL();
            return objDAL.GetTrainingId(id);
        }
        public int UpdateTraningDetails(tblTrainingLocation obj)
        {
            TraningLocDAL objDAL = new TraningLocDAL();
            return objDAL.UpdateTraningDetails(obj);
        }
        public TraningLocDO GetTrainingDetailsById(int LocationId)
        {
            TraningLocDO objDO = new TraningLocDO();
            TraningLocDAL objDAL = new TraningLocDAL();
            objDO = objDAL.GetTrainingDetailsById(LocationId);
            return objDO;
        }
        public int UpdateTrainingDetails(TraningLocDO objDO)
        {
            TraningLocDAL objDAL = new TraningLocDAL();
            return objDAL.UpdateTrainingDetails(objDO);
        }
        public int DeleteTraning(int LocationId, int DeletedBy)
        {
            TraningLocDAL objDAL = new TraningLocDAL();
            return objDAL.DeleteTraning(LocationId, DeletedBy);
        }
        public List<TraningLocDO> GetJobRoleDetailsByLocationId(int InstanceId, int TrainingLlocationsId)
        {
            TraningLocDAL objDAL = new TraningLocDAL();
            return objDAL.GetJobRoleDetailsByLocationId(InstanceId, TrainingLlocationsId);
        }
    }
    public class StateBL
    {
        public List<StateDO> GetStates(int CountryId)
        {
            List<StateDO> obj = new List<StateDO>();
            StateDAL objDal = new StateDAL();
            obj = objDal.GetStates(CountryId);
            return obj;
        }
    }
    public class SscBL
    {
        public List<SscDO> GetSSC(string InstanceId)
        {
            List<SscDO> obj = new List<SscDO>();
            SscDAL objDAL = new SscDAL();
            obj = objDAL.GetSSC(InstanceId);
            return obj;
        }
    }
    public class JobroleBL
    {
        public List<TraningLocDO> GetJobRoleDetailsBySSCId(int InstanceId, int LocationId)
        {
            JobroleDAL objDAL = new JobroleDAL();
            return objDAL.GetJobRoleDetailsBySSCId(InstanceId, LocationId);
        }
    }
    public class SaveJRBL
    {
        public int SaveJobRoleDetailsForTrainingLoc(TraningLocDO objDO)
        {
            SaveJRDAL objDAL = new SaveJRDAL();
            return objDAL.SaveJobRoleDetailsForTrainingLoc(objDO);
        }
    }
}
