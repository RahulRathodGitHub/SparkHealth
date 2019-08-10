using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblComplications
    {
        public int ComplicationNum { get; set; }
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public int PatientId { get; set; }
        public DateTime? ComplicationDate { get; set; }
        public string ComplicationCode { get; set; }
        public string TypeCode { get; set; }
        public bool Readmitted { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedByUser { get; set; }
        public string CreatedByWindowsUser { get; set; }
        public string CreatedByComputer { get; set; }
        public DateTime? LastModified { get; set; }
        public string ModifiedByUser { get; set; }
        public string ModifiedByWindowsUser { get; set; }
        public string ModifiedByComputer { get; set; }
        public bool ReOperation { get; set; }
        public string Notes { get; set; }
        public string Complication { get; set; }
        public string FacilityCode { get; set; }
        public string FacilityOther { get; set; }
        public string AdverseSurgery { get; set; }
        public int DoctorId { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedByUser { get; set; }
        public DateTime? AdmitDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public DateTime? PerformDate { get; set; }
        public string Reason { get; set; }
    }
}
