using NOSNewDAL;
using NOSNewDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewBL
{
    public class TrainersBL
    {
        TrainersDAL objDAL = new TrainersDAL();
        public List<TrainersDO> MasterTrainers(string InstanceId)
        {
            List<TrainersDO> objList = new List<TrainersDO>();
            objList = objDAL.MasterTrainers(InstanceId);
            return objList;
        }
        public int SaveTrainer(TrainersDO objDO)
        {

            return objDAL.SaveTrainer(objDO);
        }
    }
}
