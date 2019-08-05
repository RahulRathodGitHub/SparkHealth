using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPatientsBoldlog
    {
        public int PatientBoldLogId { get; set; }
        public int OrganizationCode { get; set; }
        public int PatientId { get; set; }
        public string PatientCustomId { get; set; }
        public string ChartNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string EmploymentStatus { get; set; }
        public string EmployerName { get; set; }
        public bool HasInsurance { get; set; }
        public short IsCoverProcedure { get; set; }
        public string SecondaryInsurance { get; set; }
        public string TertiaryInsurance { get; set; }
        public bool IsSelfPay { get; set; }
        public bool IsCharity { get; set; }
        public decimal PreOperativeWeightLoss { get; set; }
        public string DietryWeightLoss { get; set; }
        public bool DurationObesity { get; set; }
        public bool SmokingCessation { get; set; }
        public bool MentalHealthClearance { get; set; }
        public bool Iqtesting { get; set; }
        public string PreCertificationOther { get; set; }
        public string PbsProcedure { get; set; }
        public int PbsYear { get; set; }
        public int PbsSurgeonId { get; set; }
        public decimal OriginalWeight { get; set; }
        public bool OriginalWeightActual { get; set; }
        public decimal LowestWeightAchieved { get; set; }
        public bool LowestWeightAchievedActual { get; set; }
        public string PbsEvent { get; set; }
        public string PnbsProcedure { get; set; }
        public bool? HasConsentedToSrc { get; set; }
        public string BoldChartNumber { get; set; }
        public string InsuranceNumber { get; set; }
        public bool IsMedicare { get; set; }
        public bool IsMedicaid { get; set; }
        public bool IsPrivateInsurance { get; set; }
        public bool IsGovernmentInsurance { get; set; }
        public int? LogUserPracticeCode { get; set; }
        public DateTime? LogDateTime { get; set; }
    }
}
