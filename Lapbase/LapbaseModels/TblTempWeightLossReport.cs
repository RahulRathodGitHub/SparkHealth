using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblTempWeightLossReport
    {
        public int OrganizationCode { get; set; }
        public int GroupByMonthNo { get; set; }
        public int PatientId { get; set; }
        public string CustomPatientId { get; set; }
        public string PatientName { get; set; }
        public string Sex { get; set; }
        public int? Age { get; set; }
        public DateTime? DateSeen { get; set; }
        public string LapbandDate { get; set; }
        public int? VisitMonthsSinceOperation { get; set; }
        public decimal? StartEw { get; set; }
        public string WeightMeasurment { get; set; }
        public decimal? StartWeight { get; set; }
        public decimal? IdealWeight { get; set; }
        public decimal? Weight { get; set; }
        public decimal? InitBmi { get; set; }
        public decimal? Bmi { get; set; }
        public decimal? Ewlgroup025 { get; set; }
        public decimal? Ewlgroup2550 { get; set; }
        public decimal? Ewlgroup5075 { get; set; }
        public decimal? Ewlgroup75100 { get; set; }
        public int? Ewll { get; set; }
        public string StrEwll { get; set; }
        public string HospitalName { get; set; }
        public string DoctorName { get; set; }
        public string HospitalNameTitle { get; set; }
        public string DoctorNameTitle { get; set; }
        public DateTime? InitFilBirthdate { get; set; }
        public int? InitFilBmi { get; set; }
        public string InitFilGroup { get; set; }
        public string InitFilSurgeryType { get; set; }
        public string InitFilLapbandType { get; set; }
        public string InitFilApproach { get; set; }
        public string InitFilCategory { get; set; }
        public string InitFilLapbandSize { get; set; }
        public int? InitFilSurgeonId { get; set; }
        public string InitFilHospitalCode { get; set; }
        public string InitFilRegionId { get; set; }
        public DateTime? InitFilLapBandDate { get; set; }
    }
}
