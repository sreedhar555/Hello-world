using NOSNewDAL;
using NOSNewDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewBL
{
    public class TrainingCenterBL
    {
        TrainingCenterDAL objDAL = new TrainingCenterDAL();

        public int SaveTcDetails(TrainingCenterDO od)
        {
            return objDAL.SaveTcDetails(od);
        }
        public List<TrainingCenterDO> SearchTrainingCenter(TrainingCenterDO objDO)
        {
            List<TrainingCenterDO> objList = new List<TrainingCenterDO>();
            objList = objDAL.SearchTrainingCenter(objDO);
            return objList;
        }
        public TrainingCenterDO GetTCDetailsById(int TrainingCenterId)
        {
            TrainingCenterDO objDO = new TrainingCenterDO();
            objDO = objDAL.GetTCDetailsById(TrainingCenterId);
            return objDO;
        }
        public int UpdateTCDetails(TrainingCenterDO objDO)
        {
            return objDAL.UpdateTCDetails(objDO);
        }
        public int DeleteTC(int TrainingCenterId, int DeletedBy)
        {
            return objDAL.DeleteTC(TrainingCenterId, DeletedBy);
        }
        public List<TrainingCenterDO> GetJobRoleDetailsByTcId(int InstanceId, int TrainingCenterId)
        {
            return objDAL.GetJobRoleDetailsByTcId(InstanceId, TrainingCenterId);
        }
        
        public int SaveJobRoleDetailsForTC(TrainingCenterDO objDO)
        {
            return objDAL.SaveJobRoleDetailsForTC(objDO);
        }
    }
}
