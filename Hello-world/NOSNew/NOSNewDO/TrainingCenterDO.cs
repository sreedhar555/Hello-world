using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewDO
{
    public class TrainingCenterDO
    {
        public int instanceId { get; set; }
        public string TrainingCenterName { get; set; }
        public Nullable<int> TrainingCenterId { get; set; }
        public Nullable<int> TrainingPartnerId { get; set; }
        public string TrainingCenterIDSmartID { get; set; }
        public string SDMSID { get; set; }
        public string CenterAddress { get; set; }
        public string CenterDescription { get; set; }
        public string StartDate { get; set; }
        public string PocName { get; set; }
        public string PocMobileNo { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public DateTime Createddate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Updatedate { get; set; }
        public int Updatedby { get; set; }
        public int SSCId { get; set; }
        public string JobRole { get; set; }
        public string SubClassificationName { get; set; }
        public string ClassificationName { get; set; }
        public string Description { get; set; }
    }
}
