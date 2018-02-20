using NOSNewBL;
using NOSNewDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NOSNew.Controllers
{
    public class TrainingCenterController : Controller
    {
        // GET: TrainingCenter
        #region TC Search View
        public ActionResult ManageTrainingCenter()
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

        #region TC Insert View
        public ActionResult CreateTrainingCenter()
        {
            GetStateList();

            var instanceId = Session["InstanceId"];
            if (instanceId != null)
            {

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

        #region Insert TC
        public int SaveTrainingCenter(TrainingCenterDO od)
        {
            int returnstatus = 0;
            int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());

            TrainingCenterDO ob = new TrainingCenterDO();
            ob.TrainingCenterId = od.TrainingCenterId;
            ob.TrainingCenterName = od.TrainingCenterName;
            ob.TrainingPartnerId = od.TrainingPartnerId;
            ob.TrainingCenterIDSmartID = od.TrainingCenterIDSmartID;
            ob.SDMSID = od.SDMSID;
            ob.CenterAddress = od.CenterAddress;
            ob.CenterDescription  = od.CenterDescription;
            ob.StartDate = od.StartDate;
            ob.PocName = od.PocName ;  
            ob.PocMobileNo = od.PocMobileNo;
            ob.StateId = od.StateId;
            ob.City = od.City;
            ob.Createddate = od.Createddate;
            ob.CreatedBy = 1194;
            ob.Updatedate = od.Updatedate;
            ob.Updatedby = 1195;
            int result = 0;
            TrainingCenterBL objBL = new TrainingCenterBL();
            result = objBL.SaveTcDetails(ob);

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

        #region Search TC
        public JsonResult SearchTrainingCenterDetail(List<TrainingCenterDO> tcSearchDetail)
        {
            JsonResult result = new JsonResult();
            TrainingCenterBL obj = new TrainingCenterBL();

            List<TrainingCenterDO> objList = new List<TrainingCenterDO>();
            
            foreach (var item in tcSearchDetail)
            {

                objList = obj.SearchTrainingCenter(item);

                result.Data = objList;
            }

            return result;
        }
        #endregion

        #region Update TC View
        public ActionResult UpdateTrainingCenter(int TrainingCenterId)
        {
            GetStateList();

            var instanceId = Session["InstanceId"];
            GetSSCList(instanceId.ToString());

            if (instanceId != null)
            {

                if (TrainingCenterId == 0)
                {
                    ViewData["UpdateTrainingCenter"] = null;
                }
                else
                {
                    TrainingCenterBL objBl = new TrainingCenterBL();
                    TrainingCenterDO objDO = new TrainingCenterDO();
                    objDO = objBl.GetTCDetailsById(TrainingCenterId);
                    if (objDO != null)
                    {
                        ViewData["TCDetails"] = objDO;

                    }
                    else
                    {
                        ViewData["TCDetails"] = null;
                        ViewData["UpdateTrainingCenter"] = null;


                    }
                }
            }
            else
            {

            }
            return View();
        }
        #endregion

        #region Update TC Details
        public string SaveTrainingCenterDetails(List<TrainingCenterDO> tcDetailsDetails)
        {
            TrainingCenterBL objBL = new TrainingCenterBL();
            int result = 0;
            int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());
            int UserId = Convert.ToInt32(Session["UserId"].ToString());
            foreach (var item in tcDetailsDetails)
            {
                item.instanceId = InstanceId;
                item.CreatedBy = UserId;


                if (item.TrainingCenterId != null)
                {
                    result = objBL.UpdateTCDetails(item);
                }
                else
                {
                    result = objBL.SaveTcDetails(item);
                }

            }
            return result.ToString();
        }
        #endregion

        #region Delete TC
        public int DeleteTrainingCenter(int TrainingCenterId)
        {
            int intResult = 0;
            int CreatedBy = Convert.ToInt32(Session["UserId"].ToString());
            TrainingCenterBL objBL = new TrainingCenterBL();
            intResult = objBL.DeleteTC(TrainingCenterId, CreatedBy);
            return intResult;
        }
        #endregion

        #region Job Role Details
        public JsonResult GetJobRoleDetailsList(int TrainingCenterId)
        {
            JsonResult result = new JsonResult();

            TrainingCenterBL objBL = new TrainingCenterBL();
            List<TrainingCenterDO> objList = new List<TrainingCenterDO>();
            int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());
            objList = objBL.GetJobRoleDetailsByTcId(InstanceId, TrainingCenterId);

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
        #endregion

        #region Save Job Role Deatails
        public int SaveJobRoleDetailsForTC(List<TrainingCenterDO> jobRoleDetailsTc)
        {
            TrainingCenterBL objBL = new TrainingCenterBL();
            int result = 0;
            foreach (var item in jobRoleDetailsTc)
            {

                item.CreatedBy = Convert.ToInt32(Session["UserId"].ToString());
                item.Createddate = DateTime.Now;

                if (item.TrainingCenterId != null)
                {
                    //result = objBL.UpdateJobRoleDetailsForTP(item);
                    result = objBL.SaveJobRoleDetailsForTC(item);

                }
                else
                {
                    result = objBL.SaveJobRoleDetailsForTC(item);
                }
            }

            return result;

        }
        #endregion

    }
}