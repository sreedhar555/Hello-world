//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NOSNewDO
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSalesOfApplication
    {
        public int SalesAppGeneralInfo { get; set; }
        public Nullable<int> GeneralInformationId { get; set; }
        public Nullable<int> SalesOfApplicationId { get; set; }
        public Nullable<int> ReceiptNo { get; set; }
        public Nullable<int> AcademicYearId { get; set; }
        public Nullable<System.DateTime> InfoDate { get; set; }
        public Nullable<int> InstanceId { get; set; }
        public Nullable<int> ClassificationId { get; set; }
        public Nullable<int> SubClassificationId { get; set; }
        public Nullable<int> PackageId { get; set; }
        public Nullable<int> StudentTypeId { get; set; }
        public Nullable<int> MediumId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Email { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string FatherOccupation { get; set; }
        public Nullable<int> CasteId { get; set; }
        public string PrevOrganization { get; set; }
        public string PrevCourse { get; set; }
        public string PrevTotalMarks { get; set; }
        public string PrevHTNO { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> PCountryId { get; set; }
        public Nullable<int> StateId { get; set; }
        public Nullable<int> PStateId { get; set; }
        public string OtherState { get; set; }
        public string POtherState { get; set; }
        public string City { get; set; }
        public string PCity { get; set; }
        public string Zip { get; set; }
        public string PZip { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string WorkPhoneExtension { get; set; }
        public string FaxNumber { get; set; }
        public Nullable<bool> SMSStatus { get; set; }
        public Nullable<decimal> SalesOfApplicationAmount { get; set; }
        public Nullable<int> PaymentModeId { get; set; }
        public string ChequeDDNo { get; set; }
        public Nullable<System.DateTime> ChequeDDDate { get; set; }
        public string ChequeDDBank { get; set; }
        public string ChequeDDBranch { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<int> AdmissionApprovalType { get; set; }
        public string ReferenceBy { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    }
}