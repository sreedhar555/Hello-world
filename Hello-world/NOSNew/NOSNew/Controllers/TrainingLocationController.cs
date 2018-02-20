using NOSNewBL;
using NOSNewDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NOSNew.Controllers
{
    public class TrainingLocationController : Controller
    {
        // GET: TrainingLocation
        public ActionResult ManageTrainingLocation()
        {
            GetStateList();
            return View();
        }
        public ActionResult CreateTrainingLocation()
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
        public void GetStateList()
        {
            StateListBL obj = new StateListBL();
            List<StateListDO> objList = new List<StateListDO>();

            int CountryId = 96;

            objList = obj.GetStates(CountryId);
            ViewData["StateList"] = objList;

        }
    }
}