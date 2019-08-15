using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPatientsLog
    {
        public int PatientIdlog { get; set; }
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public int PatientId { get; set; }
        public string NameId { get; set; }
        public string ReferenceId { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public short? Title { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Sex { get; set; }
        public string Race { get; set; }
        public string Insurance { get; set; }
        public int? DoctorId { get; set; }
        public DateTime? DateFirstVisit { get; set; }
        public DateTime? DateLastVisit { get; set; }
        public string RefDrId1 { get; set; }
        public string RefDrId2 { get; set; }
        public string RefDrId3 { get; set; }
        public DateTime? RefDrDate1 { get; set; }
        public DateTime? RefDrDate2 { get; set; }
        public DateTime? RefDrDate3 { get; set; }
        public string RefDrDuration1 { get; set; }
        public string RefDrDuration2 { get; set; }
        public string RefDrDuration3 { get; set; }
        public string RefDrStatus1 { get; set; }
        public string RefDrStatus2 { get; set; }
        public string RefDrStatus3 { get; set; }
        public bool? Select { get; set; }
        public short? Select2 { get; set; }
        public short? Select3 { get; set; }
        public DateTime? DateNextVisit { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedByUser { get; set; }
        public string CreatedByComputer { get; set; }
        public DateTime? LastModified { get; set; }
        public string ModifiedByUser { get; set; }
        public string ModifiedByComputer { get; set; }
        public string RemoteDrId { get; set; }
        public string CreatedByWindowsUser { get; set; }
        public string ModifiedByWindowsUser { get; set; }
        public int? WebExport { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime? ReferralDate { get; set; }
        public string ReferralDuration { get; set; }
        public string SocialHistory { get; set; }
        public int? PatientMdId { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedByUser { get; set; }
        public DateTime? ZeroDate { get; set; }
        public DateTime? ConsultationDate { get; set; }
        public string MedicalSummary { get; set; }
        public int? LogUserPracticeCode { get; set; }
        public DateTime? LogDateTime { get; set; }
    }
}
