using NOSNewDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewDAL
{
    public class TrainingCenterDAL
    {
        OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();

        #region Insert TC
        public int SaveTcDetails(TrainingCenterDO od)
        {
            int resultstatus = 0;
            var center = db.stp_tblTrainingCenter_Insert(od.TrainingCenterName,od.TrainingPartnerId, od.TrainingCenterIDSmartID, od.SDMSID, od.CenterAddress, od.CenterDescription,
                Convert.ToDateTime(od.StartDate), od.PocName, od.PocMobileNo, od.StateId, od.City, od.Createddate, od.CreatedBy, od.Updatedate, od.Updatedby);

            if (center > 0)
            {
                resultstatus = 1;
            }
            else
            {
                resultstatus = center;
            }

            return resultstatus;
        }
        #endregion

        #region Search T
        public List<TrainingCenterDO> SearchTrainingCenter(TrainingCenterDO objDO)
        {
            List<TrainingCenterDO> objList = new List<TrainingCenterDO>();

            var result = db.stp_tblTrainingCenter_Search(objDO.TrainingCenterName, objDO.TrainingPartnerId, objDO.TrainingCenterIDSmartID, objDO.SDMSID,objDO.StateId,objDO.City).ToList();

            if (result != null)
            {
                foreach (var item in result)
                {
                    TrainingCenterDO objNew = new TrainingCenterDO();
                    objNew.TrainingCenterId = item.TrainingCenterId;
                    objNew.TrainingCenterName = item.TrainingCenterName;
                    objNew.TrainingPartnerId = item.TrainingPartnerId;
                    objNew.TrainingCenterIDSmartID = item.TrainingCenterIDSmartID;
                    objNew.SDMSID = item.SDMSID;
                    objNew.CenterAddress = item.CenterAddress;
                    objNew.CenterDescription = item.CenterDescription;
                    objNew.StartDate = item.TrainingCenterApprovalStartDate.ToString();
                    objNew.PocName = item.PocName;
                    objNew.PocMobileNo = item.PocMobileNo;
                    objNew.StateId = Convert.ToInt32(item.StateId);
                    objNew.City = item.City;


                    objList.Add(objNew);
                }
            }
            return objList;
        }
        #endregion

        #region Update TC
        public TrainingCenterDO GetTCDetailsById(int TrainingCenterId)
        {
            TrainingCenterDO objNew = new TrainingCenterDO();
            var result = db.stp_tblTrainingCenterDetails_SELById(TrainingCenterId);

            if (result != null)
            {
                foreach (var item in result)
                {
                    objNew.TrainingCenterId = item.TrainingCenterId;
                    objNew.TrainingCenterName = item.TrainingCenterName;
                    objNew.TrainingPartnerId = item.TrainingPartnerId;
                    objNew.TrainingCenterIDSmartID = item.TrainingCenterIDSmartID;
                    objNew.SDMSID = item.SDMSID;
                    objNew.CenterAddress = item.CenterAddress;
                    objNew.CenterDescription = item.CenterDescription;
                    objNew.StartDate = item.TrainingCenterApprovalStartDate.ToString();
                    objNew.PocName = item.PocName;
                    objNew.PocMobileNo = item.PocMobileNo;
                    objNew.StateId = Convert.ToInt32(item.StateId);
                    objNew.City = item.City;
                }
            }

            return objNew;
        }
        public int UpdateTCDetails(TrainingCenterDO objDO)
        {
        var result = db.stp_tblTrainingCenter_Update(objDO.TrainingCenterId, objDO.TrainingCenterName, objDO.TrainingPartnerId,
                     objDO.TrainingCenterIDSmartID, objDO.SDMSID, objDO.CenterAddress, objDO.CenterDescription, Convert.ToDateTime(objDO.StartDate), objDO.PocName,
                     objDO.PocMobileNo,objDO.StateId,objDO.City, objDO.Createddate, objDO.CreatedBy, objDO.Updatedate, objDO.Updatedby);
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
        public int DeleteTC(int TrainingCenterId, int DeletedBy)
        {
            var result = db.stp_tblTrainingCenter_Delete(TrainingCenterId);
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

        #region Bind Job Role Details


        public List<TrainingCenterDO> GetJobRoleDetailsByTcId(int InstanceId, int TrainingCenterId)
        {
            List<TrainingCenterDO> objList = new List<TrainingCenterDO>();

            var result = db.stp_GetJobRoleDetails_Center(InstanceId, TrainingCenterId).ToList();

            if (result != null)
            {
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        TrainingCenterDO objNewDO = new TrainingCenterDO();
                        objNewDO.ClassificationName = item.ClassificationName;
                        objNewDO.SubClassificationName = item.SubClassificationName;
                        objNewDO.Description = item.Description;


                        objList.Add(objNewDO);
                    }
                }
            }
            return objList;

        }
        #endregion

        #region Add Job Role
        public int SaveJobRoleDetailsForTC(TrainingCenterDO objDO)
        {
            var result = db.stp_tbltcjobroles_Insert(objDO.TrainingCenterId, objDO.SSCId, Convert.ToInt32(objDO.JobRole), "", objDO.CreatedBy, DateTime.Now, null, null);
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
        #endregion


    }
}
