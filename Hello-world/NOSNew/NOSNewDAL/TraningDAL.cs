using NOSNewDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NOSNewDAL
{
    class TraningDAL
    {
    }
    public class TraningLocDAL
    {
        OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();

        public int SaveTraningDetails(TraningLocDO objDO)
        {
            int resultStatus = 0;
            var Traning = db.stp_tblTrainingLocation_INSERT(objDO.LocationName, objDO.TrainingLocCode, objDO.ClsRoomCapacity, objDO.NoOfRooms, objDO.Descriptions, objDO.StateId, objDO.City, objDO.Address, objDO.SSCId, objDO.JobRoleId, objDO.createdby, objDO.Createddate, null, objDO.Updatedate);
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

        public List<TrainingDetailsDO> GetTrainingDetails(TrainingSearchDO objDO)
        {
            List<TrainingDetailsDO> objList = new List<TrainingDetailsDO>();
            var result = db.stp_tblTrainingLocation_SEARCH(objDO.LocationName, objDO.TrainingLocCode, objDO.StateId, objDO.City).ToList();
            if (result != null)
            {
                foreach (var item in result)
                {
                    TrainingDetailsDO objNew = new TrainingDetailsDO();
                    objNew.LocationId = item.LocationId;
                    objNew.LocationName = item.LocationName;
                    objNew.TrainingLocCode = item.TrainingLocCode;
                    objNew.ClsRoomCapacity = item.ClsRoomCapacity;
                    objNew.NoOfRooms = item.NoOfRooms;
                    objNew.Descriptions = item.Descriptions;
                    objNew.StateId = item.StateId;
                    objNew.City = item.City;
                    objNew.Address = item.Address;
                    objList.Add(objNew);
                }
            }
            return objList;
        }

        public TraningLocDO GetTrainingId(int id)
        {
            TraningLocDO objNew = new TraningLocDO();
            var result = (from s in db.tblTrainingLocations where s.LocationId == id select s).ToList();
            if (result != null)
            {
                foreach (var item in result)
                {
                    objNew.LocationId = item.LocationId;
                    objNew.LocationName = item.LocationName;
                    objNew.TrainingLocCode = item.TrainingLocCode;
                    objNew.ClsRoomCapacity = Convert.ToInt32(item.ClsRoomCapacity);
                    objNew.NoOfRooms = Convert.ToInt32(item.NoOfRooms);
                    objNew.Descriptions = item.Descriptions;
                    objNew.StateId = Convert.ToInt32(item.StateId);
                    objNew.City = item.City;
                    objNew.Address = item.Address;
                }
            }
            return objNew;


        }

        public int UpdateTraningDetails(tblTrainingLocation obj)
        {
            var result = (from s in db.tblTrainingLocations where s.LocationId == obj.LocationId select s).SingleOrDefault();
            TraningLocDO objNew = new TraningLocDO();

            objNew.LocationId = obj.LocationId;
            objNew.LocationName = obj.LocationName;
            objNew.TrainingLocCode = obj.TrainingLocCode;
            objNew.ClsRoomCapacity = Convert.ToInt32(obj.ClsRoomCapacity);
            objNew.NoOfRooms = Convert.ToInt32(obj.NoOfRooms);
            objNew.Descriptions = obj.Descriptions;
            objNew.StateId = Convert.ToInt32(obj.StateId);
            objNew.City = obj.City;
            objNew.Address = obj.Address;
            if (db.SaveChanges() > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }


        }
        public TraningLocDO GetTrainingDetailsById(int LocationId)
        {
            TraningLocDO objDO = new TraningLocDO();
            var result = db.STP_tblTrainingLocation_GetTrainingDetailsById(LocationId);

            if (result != null)
            {
                foreach (var item in result)
                {
                    objDO.LocationId = item.LocationId;
                    objDO.LocationName = item.LocationName;
                    objDO.TrainingLocCode = item.TrainingLocCode;
                    objDO.ClsRoomCapacity = Convert.ToInt32(item.ClsRoomCapacity);
                    objDO.NoOfRooms = Convert.ToInt32(item.NoOfRooms);
                    objDO.Descriptions = item.Descriptions;
                    objDO.StateId = Convert.ToInt32(item.StateId);
                    objDO.City = item.City;
                    objDO.Address = item.Address;
                }
            }

            return objDO;
        }
        public int UpdateTrainingDetails(TraningLocDO objDO)
        {


            var result = db.stp_tblTrainingLocation_UPDATE(objDO.LocationId, objDO.LocationName, objDO.TrainingLocCode,
                                                          objDO.ClsRoomCapacity, objDO.NoOfRooms, objDO.Descriptions, objDO.StateId,
                                                          objDO.City, objDO.Address, objDO.Createddate, objDO.createdby, objDO.Updatedate, objDO.Updatedby);
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
        public int DeleteTraning(int LocationId, int createdby)
        {
            var result = db.stp_tblTrainingLocation_Delete(LocationId);
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
        public List<TraningLocDO> GetJobRoleDetailsByLocationId(int InstanceId, int TrainingLlocationsId)
        {
            List<TraningLocDO> objList = new List<TraningLocDO>();

            var result = db.stp_GetJobRoleDetailsTL(InstanceId, TrainingLlocationsId).ToList();

            if (result != null)
            {
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        TraningLocDO objNewDO = new TraningLocDO();
                        objNewDO.ClassificationName = item.ClassificationName;
                        objNewDO.SubClassificationName = item.SubClassificationName;
                        objNewDO.Description = item.Description;


                        objList.Add(objNewDO);
                    }
                }
            }
            return objList;

        }
    }

    public class StateDAL
    {
        OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();
        public List<StateDO> GetStates(int CountryId)
        {
            List<StateDO> obj = new List<StateDO>();

            var result = db.stp_tblState_SELByCountryId(CountryId).ToList();

            foreach (var item in result)
            {
                StateDO objItem = new StateDO();
                objItem.StateId = item.StateId;
                objItem.StateName = item.StateName;


                obj.Add(objItem);
            }

            return obj;
        }
    }
    public class SscDAL
    {
        OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();
        public List<SscDO> GetSSC(string InstanceId)
        {
            List<SscDO> obj = new List<SscDO>();
            var result = db.stp_GetLogistics(Convert.ToInt32(InstanceId)).ToList();
            if (result != null)
            {
                foreach (var item in result)
                {
                    SscDO objNew = new SscDO();
                    objNew.InstanceClassificationId = item.InstanceClassificationId;
                    objNew.ClassificationName = item.ClassificationName;
                    obj.Add(objNew);
                }
            }
            return obj;
        }
    }
    public class JobroleDAL
    {
        OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();
        public List<TraningLocDO> GetJobRoleDetailsBySSCId(int InstanceId, int InstanceClassificationId)
        {
            List<TraningLocDO> objList = new List<TraningLocDO>();

            var result = db.stp_GetJobRoles(InstanceId, InstanceClassificationId).ToList();

            if (result != null)
            {
                if (result.Count > 0)
                {
                    foreach (var item in result)
                    {
                        TraningLocDO objNewDO = new TraningLocDO();
                        objNewDO.SSCId = item.InstanceSubClassificationId;
                        objNewDO.JobRoleId = Convert.ToInt32(item.SubClassificationName);

                        objList.Add(objNewDO);
                    }
                }
            }
            return objList;
        }
    }
    public class SaveJRDAL
    {
        OnlineTest2017NewEntities db = new OnlineTest2017NewEntities();
        public int SaveJobRoleDetailsForTrainingLoc(TraningLocDO objDO)
        {
            var result = db.stp_TBLTLJobroles_Insert(objDO.LocationId, objDO.SSCId, Convert.ToInt32(objDO.JobRoleId), "", objDO.createdby, DateTime.Now, null, null);
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
