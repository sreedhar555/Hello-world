using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using NOSNewDO;
using NOSNewBL;

namespace NOSNew.Controllers
{
    public class TraningLocController : Controller
    {
        // GET: TraningLoc
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SearchTrainingDetails()
        {
            var instanceId = Session["InstanceId"];
            if (instanceId != null)
            {
                GetSSCList(instanceId.ToString());
            }
            GetStateList();
            return View();
        }
        public ActionResult UpdateTrainingDetails(int LocationId)
        {
            var instanceId = Session["InstanceId"];
            GetStateList();

            if (instanceId != null)
            {
                GetSSCList(instanceId.ToString());
                if (LocationId == 0)
                {
                    ViewData["UpdateTrainingLocation"] = null;
                }
                else
                {
                    TraningLocBL objBL = new TraningLocBL();
                    TraningLocDO objDO = new TraningLocDO();
                    objDO = objBL.GetTrainingDetailsById(LocationId);
                    if (objDO != null)
                    {
                        ViewData["TrainingDetails"] = objDO;

                    }
                    else
                    {
                        ViewData["TrainingDetails"] = null;
                        ViewData["UpdateTrainingLocation"] = null;


                    }
                }
            }

            else
            {

            }
            return View();
        }
        public ActionResult TraningLocation()
        {
            GetStateList();
            var countryId = Session["CountryId"];
            if (countryId != null)
            {

            }

            return View();
        }
        public ActionResult CreateJobRole()
        {
            var instanceId = Session["InstanceId"];
            if (instanceId != null)
            {
                GetSSCList(instanceId.ToString());
            }
            return View();
        }
        public ActionResult SearchJobRole()
        {
            var instanceId = Session["InstanceId"];
            if (instanceId != null)
            {
                GetSSCList(instanceId.ToString());
            }
            return View();
        }
        public ActionResult UpdateJobRoleDetails(int InstanceSubClassificationId)
        {
            var instanceId = Session["InstanceId"];
            GetStateList();
            GetSSCList(instanceId.ToString());
            if (instanceId != null)
            {

                if (InstanceSubClassificationId == 0)
                {
                    ViewData["InstanceSubClassificationId"] = null;
                }
                else
                {
                    JobroleDetailBl objBl = new JobroleDetailBl();
                    SaveJobRoleDO objDO = new SaveJobRoleDO();
                    objDO = objBl.GetTrainingDetailsById(InstanceSubClassificationId);
                    if (objDO != null)
                    {
                        ViewData["JobRoleDetails"] = objDO;

                    }
                    else
                    {
                        ViewData["JobRoleDetails"] = null;
                        ViewData["InstanceSubClassificationId"] = null;


                    }
                }
            }
            else
            {

            }
            return View();
        }
        [NonAction]
        public void GetStateList()
        {
            StateBL obj = new StateBL();
            List<StateDO> objList = new List<StateDO>();

            int CountryId = 96;

            objList = obj.GetStates(CountryId);
            ViewData["StateList"] = objList;

        }

        public JsonResult SaveTraningLocDetails(List<TraningLocDO> SaveDetails)
        {
            int returnStatus = 0;
            JsonResult result = new JsonResult();
            TraningLocBL objBL = new TraningLocBL();

            TraningLocDO objDO = new TraningLocDO();
            foreach (var item in SaveDetails)
            {
                objDO.LocationName = item.LocationName;
                objDO.TrainingLocCode = item.TrainingLocCode;
                objDO.ClsRoomCapacity = item.ClsRoomCapacity;
                objDO.NoOfRooms = item.NoOfRooms;
                objDO.Descriptions = item.Descriptions;
                objDO.StateId = item.StateId;
                objDO.City = item.City;
                objDO.Address = item.Address;
                objDO.createdby = item.createdby;
                objDO.Createddate = item.Createddate;
                objDO.Updatedby = item.Updatedby;
                objDO.Updatedate = item.Updatedate;
                objDO.deleteflag = objDO.deleteflag;

                int obj = 0;
                obj = objBL.SaveTraningDetail(objDO);
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

        public JsonResult GetTrainingDetailsBySearch(List<TrainingSearchDO> SearchDetails)
        {
            JsonResult result = new JsonResult();
            TraningLocBL obj = new TraningLocBL();
            List<TrainingDetailsDO> objList = new List<TrainingDetailsDO>();

            foreach (var item in SearchDetails)
            {

                objList = obj.GetTrainingDetails(item);
            }
            result.Data = objList;
            return result;
        }

        public string UpdateTrainingDetail(List<TraningLocDO> UpdateDetails)
        {
            TraningLocBL objBL = new TraningLocBL();
            int result = 0;
            int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());
            int UserId = Convert.ToInt32(Session["UserId"].ToString());
            foreach (var item in UpdateDetails)
            {
                item.InstanceId = InstanceId;
                item.createdby = UserId;


                if (item.LocationId != null)
                {
                    result = objBL.UpdateTrainingDetails(item);
                }
                else
                {
                    result = objBL.SaveTraningDetail(item);
                }

            }
            return result.ToString();
        }
        public int DeleteTrainingLocation(int LocationId)
        {
            int result = 0;
            int CreatedBy = Convert.ToInt32(Session["UserId"].ToString());
            TraningLocBL objBL = new TraningLocBL();
            result = objBL.DeleteTraning(LocationId, CreatedBy);
            return result;
        }
        public void GetSSCList(string InstanceId)
        {
            SscBL objBL = new SscBL();
            List<SscDO> objDO = new List<SscDO>();
            objDO = objBL.GetSSC(InstanceId);
            ViewData["SSCList"] = objDO;
        }
        public JsonResult GetJobRoleBySSCId(string SSCId)
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
        public JsonResult SaveJobRoleDetails(List<SaveJobRoleDO> SaveJobeRole)
        {
            JsonResult result = new JsonResult();
            JobroleDetailBl objBL = new JobroleDetailBl();
            int returnStatus = 0;
            SaveJobRoleDO objDO = new SaveJobRoleDO();
            foreach (var item in SaveJobeRole)
            {
                objDO.InstanceId = item.InstanceId;
                objDO.InstanceClassificationId = item.InstanceClassificationId;
                objDO.SubClassificationName = item.SubClassificationName;
                objDO.SubClassificationDescription = item.SubClassificationDescription;
                objDO.ResultsModeId = item.ResultsModeId;
                objDO.CreatedBy = item.CreatedBy;
                objDO.CreatedDate = item.CreatedDate;


                int obj = 0;
                obj = objBL.SaveJobRoleDetail(objDO);
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
        public JsonResult SearchJobRoleDetails(List<JobroleSearchDO> SearchJobRole)
        {
            JsonResult result = new JsonResult();
            JobroleDetailBl obj = new JobroleDetailBl();
            List<JobroleDO> objList = new List<JobroleDO>();
            foreach (var item in SearchJobRole)
            {
                objList = obj.SearchJobRoleDetail(item);
            }
            result.Data = objList;
            return result;
        }
        public string UpdateJobRoleDetail(List<SaveJobRoleDO> UpdateJobRole)
        {
            JobroleDetailBl objBL = new JobroleDetailBl();
            int result = 0;
            int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());
            int UserId = Convert.ToInt32(Session["UserId"].ToString());
            foreach (var item in UpdateJobRole)
            {
                item.InstanceId = InstanceId;
                item.CreatedBy = UserId;


                if (item.InstanceId != null)
                {
                    result = objBL.UpdateJobROleDetails(item);
                }
                else
                {
                    result = objBL.SaveJobRoleDetail(item);
                }

            }
            return result.ToString();
        }
        public JsonResult GetJobRoleDetailsList(int TrainingLlocationsId)
        {
            JsonResult result = new JsonResult();

            TraningLocBL objBL = new TraningLocBL();
            List<TraningLocDO> objList = new List<TraningLocDO>();
            int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());
            objList = objBL.GetJobRoleDetailsByLocationId(InstanceId, TrainingLlocationsId);

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
        public int SaveJobRoleDetailsForTraningLoc(List<TraningLocDO> jobRoleTrainingLocDetails)
        {
            SaveJRBL objBL = new SaveJRBL();
            int result = 0;
            foreach (var item in jobRoleTrainingLocDetails)
            {

                item.createdby = Convert.ToInt32(Session["UserId"].ToString());
                item.Createddate = DateTime.Now;

                if (item.LocationId != null)
                {
                    //result = objBL.UpdateJobRoleDetailsForTP(item);
                    result = objBL.SaveJobRoleDetailsForTrainingLoc(item);

                }
                else
                {
                    result = objBL.SaveJobRoleDetailsForTrainingLoc(item);
                }
            }

            return result;

        }
    }
}