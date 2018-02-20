using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSNewDO
{
    class MasterTrainerDO
    {
    }
    public class SearchTrainerDO
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public int AadhaarNumber { get; set; }
        public int TpId { get; set; }
        public string MobileNo { get; set; }
        public int State { get; set; }
        public string City { get; set; }
    }
    public class TrainerDetailsDO
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public int Gender { get; set; }
        public string DateofBirth { get; set; }
        public Nullable<int> AadhaarNumber { get; set; }
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
    }
    public class SaveTrainerDO
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public int Gender { get; set; }
        public string DateofBirth { get; set; }
        public int AadhaarNumber { get; set; }
        public string EducationAttained { get; set; }
        public int Industryexperience { get; set; }
        public int TrainingExperience { get; set; }
        public int TrainingType { get; set; }
        public string MobileNumber { get; set; }
        public string LandlineNumber { get; set; }
        public string EmailAddress { get; set; }
        public int ParentType { get; set; }
        public string NameofParent { get; set; }
        public string NameofTrainingPartner { get; set; }
        public string SPOCMobileNumber { get; set; }
        public string Scheme { get; set; }
        public string DOA { get; set; }
        public int EmploymentState { get; set; }
        public string Sector { get; set; }
        public int DomainJobRole { get; set; }
        public int OtherJobRole { get; set; }
        public int State { get; set; }
        public string City { get; set; }
        public int SSCId { get; set; }
        public string JobRole { get; set; }
        public int TOTalDates { get; set; }
        public DateTime? Createddate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updatedate { get; set; }
        public int Updatedby { get; set; }
        public int InstanceId { get; set; }
        public string SubClassificationName { get; set; }
        public string ClassificationName { get; set; }
        public string Description { get; set; }
    }
}
