using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewDO
{
    class JobroleDo
    {
    }
    public class SaveJobRoleDO
    {
        public int InstanceId { get; set; }
        public int InstanceClassificationId { get; set; }
        public int InstanceSubClassificationId { get; set; }
        public string SubClassificationName { get; set; }
        public string SubClassificationDescription { get; set; }
        public int ResultsModeId { get; set; }
        //public int SSCId { get; set; }
        //public int JobRole { get; set; }
        //public string JobRoleDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
    public class JobroleSearchDO
    {
        public int InstanceId { get; set; }
        public int InstanceClassificationId { get; set; }
    }
    public class JobroleSaveDO
    {
        public int TrainingLlocationsID { get; set; }
        public int SSCId { get; set; }
        public int JobRoleId { get; set; }
        public string Descript { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Createddate { get; set; }
        public int Updatedby { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
