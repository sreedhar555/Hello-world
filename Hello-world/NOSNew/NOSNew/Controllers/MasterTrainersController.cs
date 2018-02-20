using NOSNewBL;
using NOSNewDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NOSNew.Controllers
{
    public class MasterTrainersController : Controller
    {
        // GET: MasterTrainers
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetMasterTrainers()
        {

            GetStateList();
            var instanceId = Session["InstanceId"];
            if (instanceId != null)
            {
                GetSSCList(instanceId.ToString());
            }
            else
            {

            }
            return View();
        }
        public ActionResult SearchMasterTrainers()
        {
            GetStateList();
            var instanceId = Session["InstanceId"];
            if (instanceId != null)
            {
                GetSSCList(instanceId.ToString());
            }
            else
            {

            }
            return View();
        }
        public ActionResult UpdateTrainerDetails(int TrainerId)
        {
            GetStateList();

            var instanceId = Session["InstanceId"];


            if (instanceId != null)
            {
                GetSSCList(instanceId.ToString());
                if (TrainerId == 0)
                {
                    ViewData["UpdateMasterTrainer"] = null;
                }
                else
                {
                    TrainerBL objBL = new TrainerBL();
                    SaveTrainerDO objDO = new SaveTrainerDO();
                    objDO = objBL.GetTrainerDetailsById(TrainerId);
                    if (objDO != null)
                    {
                        ViewData["TrainerDetails"] = objDO;

                    }
                    else
                    {
                        ViewData["TrainerDetails"] = null;
                        ViewData["UpdateMasterTrainer"] = null;


                    }
                }
            }
            else
            {

            }
            return View();
        }
        public JsonResult SaveTraninerDetails(List<SaveTrainerDO> SaveTrainer)
        {
            int returnStatus = 0;
            JsonResult result = new JsonResult();
            TrainerBL objBL = new TrainerBL();

            SaveTrainerDO objDO = new SaveTrainerDO();
            foreach (var item in SaveTrainer)
            {
                objDO.TrainerId = item.TrainerId;
                objDO.TrainerName = item.TrainerName;
                objDO.Gender = item.Gender;
                objDO.DateofBirth = item.DateofBirth;
                objDO.AadhaarNumber = item.AadhaarNumber;
                objDO.EducationAttained = item.EducationAttained;
                objDO.Industryexperience = item.Industryexperience;
                objDO.TrainingExperience = item.TrainingExperience;
                objDO.TrainingType = item.TrainingType;
                objDO.MobileNumber = item.MobileNumber;
                objDO.LandlineNumber = item.LandlineNumber;
                objDO.EmailAddress = item.EmailAddress;
                objDO.ParentType = item.ParentType;
                objDO.NameofParent = item.NameofParent;
                objDO.NameofTrainingPartner = item.NameofTrainingPartner;
                objDO.SPOCMobileNumber = item.SPOCMobileNumber;
                objDO.Scheme = item.Scheme;
                objDO.DOA = item.DOA;
                objDO.EmploymentState = item.EmploymentState;
                objDO.Sector = item.Sector;
                objDO.DomainJobRole = item.DomainJobRole;
                objDO.OtherJobRole = item.OtherJobRole;
                objDO.State = item.State;
                objDO.City = item.City;
                objDO.TOTalDates = item.TOTalDates;
                objDO.Createddate = item.Createddate;
                objDO.CreatedBy = item.CreatedBy;
                objDO.Updatedate = item.Updatedate;
                objDO.Updatedby = item.Updatedby;
                int obj = 0;
                obj = objBL.SaveTraninerDetail(objDO);
                if (obj == 1)
                {
                    returnStatus = 1;
                }
                else
                {
                    returnStatus = -1;
                }
                result.Data = obj;
            }
            return result;
        }
        public JsonResult GetTrainerDetailsBySearch(List<SearchTrainerDO> SearchTrainers)
        {
            JsonResult result = new JsonResult();
            TrainerBL obj = new TrainerBL();
            List<TrainerDetailsDO> objList = new List<TrainerDetailsDO>();

            foreach (var item in SearchTrainers)
            {

                objList = obj.GetTrainerDetails(item);
            }
            result.Data = objList;
            return result;
        }
        public string GetTrainerDetails(List<SaveTrainerDO> jobroleUpdateTrainerDetails)
        {
            TrainerBL objBL = new TrainerBL();
            int result = 0;
            int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());
            int UserId = Convert.ToInt32(Session["UserId"].ToString());
            foreach (var item in jobroleUpdateTrainerDetails)
            {
                item.InstanceId = InstanceId;
                item.CreatedBy = UserId;


                if (item.TrainerId != null)
                {
                    result = objBL.UpdateTrainerDetails(item);
                }
                else
                {
                    result = objBL.SaveTraninerDetail(item);
                }

            }
            return result.ToString();
        }
        public JsonResult GetJobRoleDetailsList(int MasterTrainnersID)
        {
            JsonResult result = new JsonResult();

            TrainerBL objBL = new TrainerBL();
            List<SaveTrainerDO> objList = new List<SaveTrainerDO>();
            int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());
            objList = objBL.GetJobRoleDetailsByTrainerId(InstanceId, MasterTrainnersID);

            if (objList != null)
            {
                result.Data = objList;
            }
            else
            {
                result.Data = null;
            }

            return result;
        }
        public int SaveJobRoleDetailsForMasterTrainers(List<SaveTrainerDO> jobRoleTrainerDetails)
        {
            TrainerBL objBL = new TrainerBL();
            int result = 0;
            foreach (var item in jobRoleTrainerDetails)
            {

                item.CreatedBy = Convert.ToInt32(Session["UserId"].ToString());
                item.Createddate = DateTime.Now;

                if (item.TrainerId != null)
                {
                    //result = objBL.UpdateJobRoleDetailsForTP(item);
                    result = objBL.SaveJobRoleDetailsForMasterTrainers(item);

                }
                else
                {
                    result = objBL.SaveJobRoleDetailsForMasterTrainers(item);
                }
            }

            return result;

        }
        public void GetSSCList(string InstanceId)
        {
            SSCBL obj = new SSCBL();
            List<SSCDO> objList = new List<SSCDO>();

            objList = obj.GetSSCByInstanceId(InstanceId);

            ViewData["SSCList"] = objList;

        }
        public JsonResult GetJobRolesBySSCId(string SSCId)
        {
            JsonResult result = new JsonResult();

            JobRoleBL obj = new JobRoleBL();
            List<JobRoleDO> objList = new List<JobRoleDO>();
            int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());

            objList = obj.GetJobRoleBySSCId(InstanceId.ToString(), SSCId);
            ViewData["JobRoleList"] = objList;
            result.Data = objList;
            return result;
        }

        #region State
        public void GetStateList()
        {
            StateListBL obj = new StateListBL();
            List<StateListDO> objList = new List<StateListDO>();

            int CountryId = 96;

            objList = obj.GetStates(CountryId);
            ViewData["StateList"] = objList;

        }

        #endregion

    }
}