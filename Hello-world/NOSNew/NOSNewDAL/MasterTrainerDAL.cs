using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOSNewDO;

namespace NOSNewDAL
{
    class MasterTrainerDAL
    {
    }
    public class TrainerDAL
    {
        OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();
        public List<TrainerDetailsDO> GetTrainerDetails(SearchTrainerDO objDO)
        {
            List<TrainerDetailsDO> objList = new List<TrainerDetailsDO>();
            var result = db.stp_tblMasterTrainer_Search(objDO.TrainerName, objDO.AadhaarNumber, objDO.TpId, objDO.MobileNo, objDO.State, objDO.City).ToList();
            if (result != null)
            {
                foreach (var item in result)
                {
                    TrainerDetailsDO objNew = new TrainerDetailsDO();
                    objNew.TrainerId = item.TrainerId;
                    objNew.TrainerName = item.TrainerName;
                    objNew.Gender = item.Gender;
                    objNew.DateofBirth = item.DateofBirth;
                    objNew.AadhaarNumber = item.AadhaarNumber;
                    objNew.EducationAttained = item.EducationAttained;
                    objNew.Industryexperience = item.Industryexperience;
                    objNew.TrainingExperience = item.TrainingExperience;
                    objNew.TrainingType = item.TrainingType;
                    objNew.MobileNumber = item.MobileNumber;
                    objNew.LandlineNumber = item.LandlineNumber;
                    objNew.EmailAddress = item.EmailAddress;
                    objNew.ParentType = item.ParentType;
                    objNew.NameofParent = item.NameofParent;
                    objNew.NameofTrainingPartner = item.NameofTrainingPartner;
                    objNew.SPOCMobileNumber = item.SPOCMobileNumber;
                    objNew.Scheme = item.Scheme;
                    objNew.Sector = item.Sector;
                    objNew.State = item.State;
                    objNew.City = item.City;
                    objList.Add(objNew);
                }
            }
            return objList;
        }
        public int SaveTrainerDetails(SaveTrainerDO objDO)
        {
            int resultStatus = 0;
            var Traning = db.stp_tblMasterTrainer_Insert(objDO.TrainerId, objDO.TrainerName, objDO.Gender, objDO.DateofBirth, objDO.AadhaarNumber, objDO.EducationAttained, objDO.Industryexperience, objDO.TrainingExperience, objDO.TrainingType, objDO.MobileNumber, objDO.LandlineNumber, objDO.EmailAddress, objDO.ParentType, objDO.NameofParent, objDO.NameofTrainingPartner, objDO.SPOCMobileNumber, objDO.Scheme, objDO.DOA, objDO.EmploymentState, objDO.Sector, objDO.DomainJobRole, objDO.OtherJobRole, objDO.State, objDO.City, objDO.SSCId, objDO.JobRole, objDO.TOTalDates, DateTime.Now, objDO.CreatedBy, objDO.Updatedate, objDO.Updatedby);
            if (Traning > 0)
            {
                resultStatus = 1;
            }
            else
            {
                resultStatus = Traning;
            }
            return resultStatus;
        }
        public SaveTrainerDO GetTrainerDetailsById(int TrainerId)
        {
            SaveTrainerDO objDO = new SaveTrainerDO();
            var result = db.stp_tblMasterTrainer_SELById(TrainerId);

            if (result != null)
            {
                foreach (var item in result)
                {
                    objDO.TrainerId = item.TrainerId;
                    objDO.TrainerName = item.TrainerName;
                    objDO.Gender = item.Gender;
                    objDO.DateofBirth = item.DateofBirth;
                    objDO.AadhaarNumber = Convert.ToInt32(item.AadhaarNumber);
                    objDO.EducationAttained = item.EducationAttained;
                    objDO.Industryexperience = Convert.ToInt32(item.Industryexperience);
                    objDO.TrainingExperience = Convert.ToInt32(item.TrainingExperience);
                    objDO.TrainingType = Convert.ToInt32(item.TrainingType);
                    objDO.MobileNumber = item.MobileNumber;
                    objDO.LandlineNumber = item.LandlineNumber;
                    objDO.EmailAddress = item.EmailAddress;
                    objDO.ParentType = Convert.ToInt32(item.ParentType);
                    objDO.NameofParent = item.NameofParent;
                    objDO.NameofTrainingPartner = item.NameofTrainingPartner;
                    objDO.SPOCMobileNumber = item.SPOCMobileNumber;
                    objDO.Scheme = item.Scheme;
                    objDO.Sector = item.Sector;
                    objDO.State = Convert.ToInt32(item.State);
                    objDO.City = item.City;
                }
            }

            return objDO;
        }
        public int UpdateTrainerDetails(SaveTrainerDO objDO)
        {
            var result = db.stp_tblMasterTrainer_Update(objDO.TrainerId, objDO.TrainerName, objDO.Gender, objDO.DateofBirth, objDO.AadhaarNumber, objDO.EducationAttained, objDO.Industryexperience, objDO.TrainingExperience, objDO.TrainingType, objDO.MobileNumber, objDO.LandlineNumber, objDO.EmailAddress, objDO.ParentType, objDO.NameofParent, objDO.NameofTrainingPartner, objDO.SPOCMobileNumber, objDO.Scheme, objDO.DOA, objDO.EmploymentState, objDO.Sector, objDO.DomainJobRole, objDO.OtherJobRole, objDO.State, objDO.City, objDO.TOTalDates, DateTime.Now, objDO.CreatedBy, objDO.Updatedate, objDO.Updatedby);
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
        public List<SaveTrainerDO> GetJobRoleDetailsBySSCId(int InstanceId, int Instanceclassificationid)
        {
            List<SaveTrainerDO> objList = new List<SaveTrainerDO>();

            var result = db.stp_GetJobRoles(InstanceId, @Instanceclassificationid).ToList();

            if (result != null)
            {
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        SaveTrainerDO objNewDO = new SaveTrainerDO();
                        objNewDO.SSCId = item.InstanceSubClassificationId;
                        objNewDO.JobRole = item.SubClassificationName;

                        objList.Add(objNewDO);
                    }
                }
            }
            return objList;

        }
        public List<SaveTrainerDO> GetJobRoleDetailsByTrainerId(int InstanceId, int MasterTrainnersID)
        {
            List<SaveTrainerDO> objList = new List<SaveTrainerDO>();

            var result = db.stp_GetJobRoleDetailsMT(InstanceId, MasterTrainnersID).ToList();

            if (result != null)
            {
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        SaveTrainerDO objNewDO = new SaveTrainerDO();
                        objNewDO.ClassificationName = item.ClassificationName;
                        objNewDO.SubClassificationName = item.SubClassificationName;
                        objNewDO.Description = item.Description;


                        objList.Add(objNewDO);
                    }
                }
            }
            return objList;

        }
        public int SaveJobRoleDetailsForMasterTrainers(SaveTrainerDO objDO)
        {
            var result = db.stp_tblmtjobroles_Insert(objDO.TrainerId, objDO.SSCId, Convert.ToInt32(objDO.JobRole), "", objDO.CreatedBy, DateTime.Now, null, null);
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
