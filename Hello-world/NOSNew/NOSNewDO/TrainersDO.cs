using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewDO
{
   public class TrainersDO
    {
        public string TrainerName { get; set; }
        public int MasterTrainerId { get; set; }
        public int Gender { get; set; }
        public string DateofBirth { get; set; }
        public string AadhaarNumber { get; set; }
        public string EducationAttained { get; set; }
        public Nullable<int> Industryexperience { get; set; }
        public Nullable<int> TrainingExperience { get; set; }
        public Nullable<int> TrainingType { get; set; }
        public string MobileNumber { get; set; }
        public string LandlineNumber { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<int> ParentType { get; set; }
        public string NameofParent { get; set; }
        public string NameofTrainingPartner { get; set; }
        public string SPOCMobileNumber { get; set; }
        public string Scheme { get; set; }
        public string Sector { get; set; }
        public Nullable<int> State { get; set; }
        public string City { get; set; }

        public int TrainerId { get; set; }
        public string DOA { get; set; }
        public int EmploymentState { get; set; }

        public int DomainJobRole { get; set; }
        public int OtherJobRole { get; set; }

        public int SSCId { get; set; }
        public string JobRole { get; set; }
        public int TOTalDates { get; set; }
        public DateTime? Createddate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updatedate { get; set; }
        public int Updatedby { get; set; }
        public int InstanceId { get; set; }
        public int Certified { get; set; }
        public int SmartPortal { get; set; }
    }
}
