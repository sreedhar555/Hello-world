using NOSNewBL;
using NOSNewDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NOSNew.Controllers
{
    public class TrainersController : Controller
    {
        // GET: Trainers
        #region Trainers Search View
        public ActionResult ManageTrainers()
        {
            GetStateList();

            return View();
        }
        #endregion

        #region SSC
        public void GetSSCList(string InstanceId)
        {
            SSCBL obj = new SSCBL();
            List<SSCDO> objList = new List<SSCDO>();

            objList = obj.GetSSCByInstanceId(InstanceId);

            ViewData["SSCList"] = objList;

        }
        #endregion

        #region Master Trainer
        public void GetMasterTrainer(string InstanceId)
        {
            TrainersBL obj = new TrainersBL();
            List<TrainersDO> objList = new List<TrainersDO>();

            objList = obj.MasterTrainers(InstanceId);

            ViewData["MasterTrainer"] = objList;

        }
        #endregion

        #region Job Role
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
        #endregion

        #region Trainers Insert View
        public ActionResult CreateNewTrainer()
        {
            GetStateList();

            var instanceId = Session["InstanceId"];
            if (instanceId != null)
            {
                GetMasterTrainer(instanceId.ToString());

            }
            else
            {

            }
            return View();
        }
        #endregion 

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

        #region Insert Trainer
        public int SaveTrainerDetails(TrainersDO od)
        {
            int returnstatus = 0;
            int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());

            TrainersDO objDO = new TrainersDO();

            objDO.TrainerId = od.TrainerId;
            objDO.TrainerName = od.TrainerName;
            objDO.Gender = od.Gender;
            objDO.DateofBirth = od.DateofBirth;
            objDO.AadhaarNumber = od.AadhaarNumber;
            objDO.EducationAttained = od.EducationAttained;
            objDO.Industryexperience = od.Industryexperience;
            objDO.TrainingExperience = od.TrainingExperience;
            objDO.TrainingType = od.TrainingType;
            objDO.MobileNumber = od.MobileNumber;
            objDO.LandlineNumber = od.LandlineNumber;
            objDO.EmailAddress = od.EmailAddress;
            objDO.ParentType = od.ParentType;
            objDO.NameofParent = od.NameofParent;
            objDO.NameofTrainingPartner = od.NameofTrainingPartner;
            objDO.SPOCMobileNumber = od.SPOCMobileNumber;
            objDO.Scheme = od.Scheme;
            objDO.DOA = od.DOA;
            objDO.EmploymentState = od.EmploymentState;
            objDO.Sector = od.Sector;
            objDO.DomainJobRole = od.DomainJobRole;
            objDO.OtherJobRole = od.OtherJobRole;
            objDO.State = od.State;
            objDO.City = od.City;
            objDO.TOTalDates = od.TOTalDates;
            objDO.MasterTrainerId = od.MasterTrainerId;
            objDO.Certified = od.Certified;
            objDO.SmartPortal = od.SmartPortal;
            objDO.Createddate = od.Createddate;
            objDO.CreatedBy = od.CreatedBy;
            objDO.Updatedate = od.Updatedate;
            objDO.Updatedby = od.Updatedby;
            int result = 0;
            TrainersBL objBL = new TrainersBL();
            result = objBL.SaveTrainer(objDO);

            if (result == 1)
            {
                returnstatus = 1;
            }

            else
            {
                returnstatus = -1;
            }
            return returnstatus;
        }
        #endregion

        //#region Search TC
        //public JsonResult SearchTrainingCenterDetail(List<TrainingCenterDO> tcSearchDetail)
        //{
        //    JsonResult result = new JsonResult();
        //    TrainingCenterBL obj = new TrainingCenterBL();

        //    List<TrainingCenterDO> objList = new List<TrainingCenterDO>();

        //    foreach (var item in tcSearchDetail)
        //    {

        //        objList = obj.SearchTrainingCenter(item);

        //        result.Data = objList;
        //    }

        //    return result;
        //}
        //#endregion

        //#region Update TC View
        //public ActionResult UpdateTrainingCenter(int TrainingCenterId)
        //{
        //    GetStateList();

        //    var instanceId = Session["InstanceId"];
        //    GetSSCList(instanceId.ToString());

        //    if (instanceId != null)
        //    {

        //        if (TrainingCenterId == 0)
        //        {
        //            ViewData["UpdateTrainingCenter"] = null;
        //        }
        //        else
        //        {
        //            TrainingCenterBL objBl = new TrainingCenterBL();
        //            TrainingCenterDO objDO = new TrainingCenterDO();
        //            objDO = objBl.GetTCDetailsById(TrainingCenterId);
        //            if (objDO != null)
        //            {
        //                ViewData["TCDetails"] = objDO;

        //            }
        //            else
        //            {
        //                ViewData["TCDetails"] = null;
        //                ViewData["UpdateTrainingCenter"] = null;


        //            }
        //        }
        //    }
        //    else
        //    {

        //    }
        //    return View();
        //}
        //#endregion

        //#region Update TC Details
        //public string SaveTrainingCenterDetails(List<TrainingCenterDO> tcDetailsDetails)
        //{
        //    TrainingCenterBL objBL = new TrainingCenterBL();
        //    int result = 0;
        //    int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());
        //    int UserId = Convert.ToInt32(Session["UserId"].ToString());
        //    foreach (var item in tcDetailsDetails)
        //    {
        //        item.instanceId = InstanceId;
        //        item.CreatedBy = UserId;


        //        if (item.TrainingCenterId != null)
        //        {
        //            result = objBL.UpdateTCDetails(item);
        //        }
        //        else
        //        {
        //            result = objBL.SaveTcDetails(item);
        //        }

        //    }
        //    return result.ToString();
        //}
        //#endregion

        //#region Delete TC
        //public int DeleteTrainingCenter(int TrainingCenterId)
        //{
        //    int intResult = 0;
        //    int CreatedBy = Convert.ToInt32(Session["UserId"].ToString());
        //    TrainingCenterBL objBL = new TrainingCenterBL();
        //    intResult = objBL.DeleteTC(TrainingCenterId, CreatedBy);
        //    return intResult;
        //}
        //#endregion

        //#region Job Role Details
        //public JsonResult GetJobRoleDetailsList(int TrainingCenterId)
        //{
        //    JsonResult result = new JsonResult();

        //    TrainingCenterBL objBL = new TrainingCenterBL();
        //    List<TrainingCenterDO> objList = new List<TrainingCenterDO>();
        //    int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());
        //    objList = objBL.GetJobRoleDetailsByTcId(InstanceId, TrainingCenterId);

        //    if (objList != null)
        //    {
        //        result.Data = objList;
        //    }
        //    else
        //    {
        //        result.Data = null;
        //    }

        //    return result;
        //}
        //#endregion

        //#region Save Job Role Deatails
        //public int SaveJobRoleDetailsForTC(List<TrainingCenterDO> jobRoleDetailsTc)
        //{
        //    TrainingCenterBL objBL = new TrainingCenterBL();
        //    int result = 0;
        //    foreach (var item in jobRoleDetailsTc)
        //    {

        //        item.CreatedBy = Convert.ToInt32(Session["UserId"].ToString());
        //        item.Createddate = DateTime.Now;

        //        if (item.TrainingCenterId != null)
        //        {
        //            //result = objBL.UpdateJobRoleDetailsForTP(item);
        //            result = objBL.SaveJobRoleDetailsForTC(item);

        //        }
        //        else
        //        {
        //            result = objBL.SaveJobRoleDetailsForTC(item);
        //        }
        //    }

        //    return result;

        //}

        //#endregion


    }
}