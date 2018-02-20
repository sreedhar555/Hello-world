using NOSNewDO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewDAL
{
    public class TrainingPartnerDAL
    {
        OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();

        #region Insert TP
        public int SaveTPDetails(TrainingPartnerDO od)
        {
            int resultstatus = 0;
            var partner = db.stp_tblTrainingPartner_Insert(od.TrainingPartnerName, od.TrainingPartnerCode, od.POCName, od.TPAddress, od.TPDescription,
                od.NoOfCenters, od.POCMobileNo, od.StateId, od.City, od.Createddate, od.CreatedBy, od.Updatedate, od.Updatedby);

            if (partner > 0)
            {
                resultstatus = 1;
            }
            else
            {
                resultstatus = partner;
            }

            return resultstatus;
        }
        #endregion

        #region Search TP
        public List<TrainingPartnerDO> SearchTrainingPartner(TrainingPartnerDO objDO)
        {
            List<TrainingPartnerDO> objList = new List<TrainingPartnerDO>();

            var result = db.stp_tblTrainingPartner_Search(objDO.TrainingPartnerName, objDO.TrainingPartnerCode, objDO.StateId, objDO.City).ToList();

            if (result != null)
            {
                foreach (var item in result)
                {
                    TrainingPartnerDO objNew = new TrainingPartnerDO();
                    objNew.TrainingPartnerId = item.TrainingPartnerId;
                    objNew.TrainingPartnerName = item.TrainingPartnerName;
                    objNew.TrainingPartnerCode = item.TrainingPartnerCode;
                    objNew.POCName = item.POCName;
                    objNew.TPAddress = item.TPAddress;
                    objNew.TPDescription = item.TPDescription;
                    objNew.NoOfCenters = Convert.ToInt32(item.NoOfCenters);
                    objNew.POCMobileNo = item.POCMobileNo;
                    objNew.StateId = Convert.ToInt32(item.StateId);
                    objNew.City = item.City;


                    objList.Add(objNew);
                }
            }
            return objList;
        }
        #endregion

        public TrainingPartnerDO GetTPDetailsById(int TrainingPartnerId)
        {
            TrainingPartnerDO objDO = new TrainingPartnerDO();
            var result = db.stp_tblTrainingPartnerDetails_SELById(TrainingPartnerId);

            if (result != null)
            {
                foreach (var item in result)
                {
                    objDO.TrainingPartnerId = item.TrainingPartnerId;
                    objDO.TrainingPartnerName = item.TrainingPartnerName;
                    objDO.TrainingPartnerCode = item.TrainingPartnerCode;
                    objDO.POCName = item.POCName;
                    objDO.TPAddress = item.TPAddress;
                    objDO.TPDescription = item.TPDescription;
                    objDO.NoOfCenters = Convert.ToInt32(item.NoOfCenters);
                    objDO.POCMobileNo = item.POCMobileNo;
                    objDO.StateId = Convert.ToInt32(item.StateId);
                    objDO.City = item.City;
                }
            }

            return objDO;
        }
        #region Update TP
        public int UpdateTPDetails(TrainingPartnerDO objDO)
        {
            var result = db.stp_tblTrainingPartner_Update(objDO.TrainingPartnerId, objDO.TrainingPartnerName, objDO.TrainingPartnerCode,
                                                          objDO.POCName, objDO.TPAddress, objDO.TPDescription, objDO.NoOfCenters, objDO.POCMobileNo, objDO.StateId,
                                                          objDO.City, objDO.Createddate, objDO.CreatedBy, objDO.Updatedate, objDO.Updatedby);
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
        #endregion

        #region Delete TP
        public int DeleteTP(int TrainingPartnerId, int DeletedBy)
        {
            var result = db.stp_tblTrainingPartner_Delete(TrainingPartnerId);
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
        #endregion

        public List<TrainingPartnerDO> GetJobRoleDetailsByTpId(int InstanceId, int TrainingPartnerId)
        {
            List<TrainingPartnerDO> objList = new List<TrainingPartnerDO>();

            var result = db.stp_GetJobRoleDetails(InstanceId, TrainingPartnerId).ToList();

            if (result != null)
            {
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        TrainingPartnerDO objNewDO = new TrainingPartnerDO();
                        objNewDO.ClassificationName = item.ClassificationName;
                        objNewDO.SubClassificationName = item.SubClassificationName;
                        objNewDO.Description = item.Description;


                        objList.Add(objNewDO);
                    }
                }
            }
            return objList;

        }
        public int UpdateJobRoleDetailsForTP(TrainingPartnerDO objDO)
        {
            //var result = db.STP_tblOnlinetestDetailsLatest_Update(objDO.OnlineTestDetailsId, objDO.OnlineTestId, objDO.questionBankId, objDO.topicId, objDO.chapterId, null, null, 0, 0, 0, objDO.marks, objDO.createdBy, DateTime.Now);
            var result = 0;
            return result;
        }

        public int SaveJobRoleDetailsForTP(TrainingPartnerDO objDO)
        {
            var result = db.stp_tbltpjobroles_Insert(objDO.TrainingPartnerId, objDO.SSCId, Convert.ToInt32(objDO.JobRole),"",objDO.CreatedBy,DateTime.Now,null,null);
            int resultstatus = 0;
            if (result > 0)
            {
                resultstatus = 1;
            }
            else
            {
                resultstatus = result;
            }

            return resultstatus;
        }
      
    }
}
