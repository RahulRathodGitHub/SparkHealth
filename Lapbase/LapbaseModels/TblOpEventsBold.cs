using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblOpEventsBold
    {
        public int OrganizationCode { get; set; }
        public int AdmitId { get; set; }
        public int UserPracticeCode { get; set; }
        public int PatientId { get; set; }
        public int LastConsultIdbeforeOperation { get; set; }
        public int? AnesthesiaDuration { get; set; }
        public string Dvtcode { get; set; }
        public string Asacode { get; set; }
        public string SurgicalAssistance { get; set; }
        public string Concurrent { get; set; }
        public string IntraEvents { get; set; }
        public string PreDischargeEvents { get; set; }
        public int? TimeAfterSurgery { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string DischargeTo { get; set; }
        public decimal? BloodTransfusion { get; set; }
        public string SerialNo { get; set; }
        public string BandType { get; set; }
        public DateTime? AdmitDate { get; set; }
        public DateTime? OperationDate { get; set; }
        public string HospitalCode { get; set; }
        public int SurgeonId { get; set; }
        public int Duration { get; set; }
        public string SurgeryType { get; set; }
        public string Approach { get; set; }
        public decimal BloodLoss { get; set; }
        public DateTime? LastSeen { get; set; }
        public decimal? LastWeight { get; set; }
        public bool? BoldFlag { get; set; }
        public bool BoldSent { get; set; }
        public bool SurgicalFellowParticipated { get; set; }
        public bool SurgicalResidentParticipated { get; set; }
        public bool Dvtantigloculan { get; set; }
        public bool Dvtted { get; set; }
        public bool DvtfootPump { get; set; }
        public bool Dvtcompress { get; set; }
        public string HospitalId { get; set; }
        public string TimeAfterSurgeryMeasurement { get; set; }
        public int PreDischargeSurgeon { get; set; }
        public string PreDischargeSurgery { get; set; }
        public string RegistryProcedure { get; set; }
    }
}
