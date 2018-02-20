using NOSNewBL;
using NOSNewDO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NOSNew.Controllers
{
    public class TrainingPartnerController : Controller
    {
        
        #region Search TP View
        public ActionResult ManageTrainingPartner()
        {
            GetStateList();
            var instanceId = Session["InstanceId"];
            if (instanceId != null)
            {
                
                ViewData["InstanceId"] = instanceId.ToString();
            }
            else
            {

            }
            return View();
        }

        #endregion
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
        #region Insert TP View
        public ActionResult CreateTrainingPartner()
        {
            GetStateList();
            var instanceId = Session["InstanceId"];
            if (instanceId != null)
            {
                //GetSSCList(instanceId.ToString());
            }
            else
            {

            }
            return View();
        }
        #endregion

        #region Update TP View
        public ActionResult UpdateTrainingPartner(int TrainingPartnerId)
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

                if (TrainingPartnerId == 0)
                {
                    ViewData["UpdateTrainingPartner"] = null;
                }
                else
                {
                    TrainingPartnerBL objBl = new TrainingPartnerBL();
                    TrainingPartnerDO objDO = new TrainingPartnerDO();
                    objDO = objBl.GetTPDetailsById(TrainingPartnerId);
                    if (objDO != null)
                    {
                        ViewData["TPDetails"] = objDO;

                    }
                    else
                    {
                        ViewData["TPDetails"] = null;
                        ViewData["UpdateTrainingPartner"] = null;


                    }
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

        #region Insert TP
        public int SaveTrainingPartner(TrainingPartnerDO od)
        {
            int returnstatus = 0;
            int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());

            TrainingPartnerDO ob = new TrainingPartnerDO();

            ob.TrainingPartnerId = od.TrainingPartnerId;
            ob.TrainingPartnerName = od.TrainingPartnerName;
            ob.TrainingPartnerCode = od.TrainingPartnerCode;
            ob.POCName = od.POCName;
            ob.TPAddress = od.TPAddress;
            ob.TPDescription = od.TPDescription;
            ob.NoOfCenters = od.NoOfCenters;
            ob.POCMobileNo = od.POCMobileNo;
            ob.StateId = od.StateId;
            ob.City = od.City;
            ob.Createddate = od.Createddate;
            ob.CreatedBy = 1194;
            ob.Updatedate = od.Updatedate;
            ob.Updatedby = 1195;
            int result = 0;
            TrainingPartnerBL objBL = new TrainingPartnerBL();
            result = objBL.SaveTPDetails(ob);

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

        #region Search TP
        public JsonResult SearchTrainingPartnerDetail(List<TrainingPartnerDO> tpSearchDetail)
        {
            JsonResult result = new JsonResult();
            TrainingPartnerBL obj = new TrainingPartnerBL();

            List<TrainingPartnerDO> objList = new List<TrainingPartnerDO>();
            //int TrainingPartnerId = Convert.ToInt32(Session["TrainingPartnerId"].ToString());


            foreach (var item in tpSearchDetail)
            {
                //item.TrainingPartnerId = TrainingPartnerId;

                objList = obj.SearchTrainingPartner(item);

                result.Data = objList;
            }

            return result;
        }
        #endregion

        #region Update TP Details
        public string SaveTPDetails(List<TrainingPartnerDO> tpDetailsDetails)
        {
            TrainingPartnerBL objBL = new TrainingPartnerBL();
            int result = 0;
            int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());
            int UserId = Convert.ToInt32(Session["UserId"].ToString());
            foreach (var item in tpDetailsDetails)
            {
                item.InstanceId = InstanceId;
                item.CreatedBy = UserId;
                

                if (item.TrainingPartnerId != null)
                {
                    result = objBL.UpdateTPDetails(item);
                }
                else
                {
                    result = objBL.SaveTPDetails(item);
                }

            }
            return result.ToString();
        }
        #endregion

        #region Delete TP
        public int DeleteTrainingPartner(int TrainingPartnerId)
        {
            int intResult = 0;
            int CreatedBy = Convert.ToInt32(Session["UserId"].ToString());
            TrainingPartnerBL objBL = new TrainingPartnerBL();
            intResult = objBL.DeleteTP(TrainingPartnerId, CreatedBy);
            return intResult;
        }
        #endregion

        #region Job Role Details
        public JsonResult GetJobRoleDetailsList(int TrainingPartnerId)
        {
            JsonResult result = new JsonResult();

            TrainingPartnerBL objBL = new TrainingPartnerBL();
            List<TrainingPartnerDO> objList = new List<TrainingPartnerDO>();
            int InstanceId = Convert.ToInt32(Session["InstanceId"].ToString());
            objList = objBL.GetJobRoleDetailsByTpId(InstanceId, TrainingPartnerId);

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
        public int SaveJobRoleDetailsForTP(List<TrainingPartnerDO> jobRoleTpDetails)
        {
            TrainingPartnerBL objBL = new TrainingPartnerBL();
            int result = 0;
            foreach (var item in jobRoleTpDetails)
            {

                item.CreatedBy = Convert.ToInt32(Session["UserId"].ToString());
                item.Createddate = DateTime.Now;

                if (item.TrainingPartnerId != null)
                {
                    //result = objBL.UpdateJobRoleDetailsForTP(item);
                    result = objBL.SaveJobRoleDetailsForTP(item);

                }
                else
                {
                    result = objBL.SaveJobRoleDetailsForTP(item);
                }
            }

            return result;

        }
        #endregion
    }
}