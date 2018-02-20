using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOSNewDO;
using NOSNewDAL;

namespace NOSNewBL
{
    class MasterTrainerBL
    {
    }
    public class TrainerBL
    {
        TrainerDAL objDAL = new TrainerDAL();
        public List<TrainerDetailsDO> GetTrainerDetails(SearchTrainerDO objDO)
        {
            return objDAL.GetTrainerDetails(objDO);
        }
        public int SaveTraninerDetail(SaveTrainerDO objDO)
        {
            return objDAL.SaveTrainerDetails(objDO);
        }
        public SaveTrainerDO GetTrainerDetailsById(int TrainerId)
        {
            SaveTrainerDO objDO = new SaveTrainerDO();
            objDO = objDAL.GetTrainerDetailsById(TrainerId);
            return objDO;
        }
        public int UpdateTrainerDetails(SaveTrainerDO objDO)
        {
            return objDAL.UpdateTrainerDetails(objDO);
        }
        public List<SaveTrainerDO> GetJobRoleDetailsByTrainerId(int InstanceId, int MasterTrainnersID)
        {

            return objDAL.GetJobRoleDetailsByTrainerId(InstanceId, MasterTrainnersID);
        }
        public List<SaveTrainerDO> GetJobRoleDetailsBySSCId(int InstanceId, int TrainerId)
        {
            return objDAL.GetJobRoleDetailsBySSCId(InstanceId, TrainerId);
        }
        public int SaveJobRoleDetailsForMasterTrainers(SaveTrainerDO objDO)
        {
            return objDAL.SaveJobRoleDetailsForMasterTrainers(objDO);
        }
    }
}
