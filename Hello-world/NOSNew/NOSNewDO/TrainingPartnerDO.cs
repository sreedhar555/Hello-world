using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewDO
{
   public class TrainingPartnerDO
    {
        public int InstanceId { get; set; }
        public Nullable<int> TrainingPartnerId { get; set; }
        public string TrainingPartnerName { get; set; }
        public string TrainingPartnerCode { get; set; }
        public string POCName { get; set; }
        public string TPAddress { get; set; }
        public string TPDescription { get; set; }
        public int NoOfCenters { get; set; }
        public string POCMobileNo { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public DateTime Createddate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Updatedate { get; set; }
        public int Updatedby { get; set; }
        public int SSCId { get; set; }
        public string JobRole{ get; set; }
        public string SubClassificationName { get; set; }
        public string ClassificationName { get; set; }
        public string Description { get; set; }

    }
}
