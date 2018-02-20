using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewDO
{
    class TraningDO
    {
    }
    public class TraningLocDO
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string TrainingLocCode { get; set; }
        public int ClsRoomCapacity { get; set; }
        public int NoOfRooms { get; set; }
        public string Descriptions { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public int Updatedby { get; set; }
        public DateTime? Updatedate { get; set; }
        public bool deleteflag { get; set; }
        public int InstanceId { get; set; }
        public int SSCId { get; set; }
        public int JobRoleId { get; set; }
        public string SubClassificationName { get; set; }
        public string ClassificationName { get; set; }
        public string Description { get; set; }
    }
    public class StateDO
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
    public class UpdateTrainingLocDO
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string TrainingLocCode { get; set; }
        public int ClsRoomCapacity { get; set; }
        public int NoOfRooms { get; set; }
        public string Descriptions { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int createdby { get; set; }
        public Nullable<System.DateTime> Createddate { get; set; }
        public int Updatedby { get; set; }
        public Nullable<System.DateTime> Updatedate { get; set; }
        public bool deleteflag { get; set; }
    }
    public class TrainingSearchDO
    {
        public string LocationName { get; set; }
        public string TrainingLocCode { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
    }
    public class TrainingDetailsDO
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string TrainingLocCode { get; set; }
        public Nullable<int> ClsRoomCapacity { get; set; }
        public Nullable<int> NoOfRooms { get; set; }
        public string Descriptions { get; set; }
        public Nullable<int> StateId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
    public class SscDO
    {
        public int InstanceClassificationId { get; set; }
        public string ClassificationName { get; set; }
    }
    public class JobroleDO
    {
        public int InstanceSubClassificationId { get; set; }
        public string SubClassificationName { get; set; }
        public string SubClassificationDescription { get; set; }
    }
}
