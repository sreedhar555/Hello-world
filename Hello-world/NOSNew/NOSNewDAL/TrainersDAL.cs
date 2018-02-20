using NOSNewDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewDAL
{
    public class TrainersDAL
    {
        OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();

        #region Master Trainer Binding
        public List<TrainersDO> MasterTrainers(string InstanceId)
        {
            List<TrainersDO> objList = new List<TrainersDO>();

            var result = db.stp_tblMasterTrainers_SELById(Convert.ToInt32(InstanceId)).ToList();

            if (result != null)
            {
                foreach (var item in result)
                {
                    TrainersDO objNew = new TrainersDO();

                    objNew.MasterTrainerId = Convert.ToInt32(item.MasterTrainerId);
                    objNew.TrainerName = item.TrainerName;
      

                    objList.Add(objNew);
                }
            }

            return objList;
        }
        #endregion

        #region Insert Trainer
        public int SaveTrainer(TrainersDO objDO)
        {
            int resultstatus = 0;
            var Trainer = db.stp_tblTrainer_Insert(objDO.TrainerName,objDO.Gender, objDO.DateofBirth, objDO.AadhaarNumber, objDO.EducationAttained, objDO.Industryexperience, objDO.TrainingExperience, objDO.TrainingType, objDO.MobileNumber,
                                  objDO.LandlineNumber, objDO.EmailAddress, objDO.ParentType, objDO.NameofParent, objDO.NameofTrainingPartner, objDO.SPOCMobileNumber, objDO.Scheme, objDO.DOA, objDO.EmploymentState, objDO.Sector, objDO.DomainJobRole, objDO.OtherJobRole,
                                  objDO.State, objDO.City,objDO.TOTalDates,objDO.MasterTrainerId,objDO.Certified,objDO.SmartPortal, objDO.CreatedBy,DateTime.Now, objDO.Updatedby, objDO.Updatedate);


            if (Trainer > 0)
            {
                resultstatus = 1;
            }
            else
            {
                resultstatus = Trainer;
            }

            return resultstatus;
        }
        #endregion

    }
}
