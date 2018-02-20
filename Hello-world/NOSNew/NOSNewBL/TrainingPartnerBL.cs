using NOSNewDAL;
using NOSNewDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewBL
{
    public class TrainingPartnerBL
    {
        TrainingPartnerDAL objDAL = new TrainingPartnerDAL();

        public int SaveTPDetails(TrainingPartnerDO od)
        {

            return objDAL.SaveTPDetails(od);
        }
        public List<TrainingPartnerDO> SearchTrainingPartner(TrainingPartnerDO objDO)
        {
            List<TrainingPartnerDO> objList = new List<TrainingPartnerDO>();
            objList = objDAL.SearchTrainingPartner(objDO);
            return objList;
        }
       
        public TrainingPartnerDO GetTPDetailsById(int TrainingPartnerId)
        {
            TrainingPartnerDO objDO = new TrainingPartnerDO();
            objDO = objDAL.GetTPDetailsById(TrainingPartnerId);
            return objDO;
        }
        public int UpdateTPDetails(TrainingPartnerDO objDO)
        {
            return objDAL.UpdateTPDetails(objDO);
        }
        public int DeleteTP(int TrainingPartnerId, int DeletedBy)
        {
            return objDAL.DeleteTP(TrainingPartnerId, DeletedBy);
        }
        public List<TrainingPartnerDO> GetJobRoleDetailsByTpId(int InstanceId, int TrainingPartnerId)
        {
            return objDAL.GetJobRoleDetailsByTpId(InstanceId, TrainingPartnerId);
        }
        public int UpdateJobRoleDetailsForTP(TrainingPartnerDO objDO)
        {
            return objDAL.UpdateJobRoleDetailsForTP(objDO);
        }
        public int SaveJobRoleDetailsForTP(TrainingPartnerDO objDO)
        {
            return objDAL.SaveJobRoleDetailsForTP(objDO);
        }
       
    }
}
