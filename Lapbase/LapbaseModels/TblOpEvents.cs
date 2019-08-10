using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblOpEvents
    {
        public int OrganizationCode { get; set; }
        public int AdmitId { get; set; }
        public int UserPracticeCode { get; set; }
        public int PatientId { get; set; }
        public DateTime? AdmitDate { get; set; }
        public decimal? OpWeight { get; set; }
        public string HospitalCode { get; set; }
        public int SurgeonId { get; set; }
        public DateTime? OperationDate { get; set; }
        public int Duration { get; set; }
        public int DaysInHospital { get; set; }
        public string SurgeryType { get; set; }
        public string Approach { get; set; }
        public string Category { get; set; }
        public string Group { get; set; }
        public decimal StartNeck { get; set; }
        public decimal StartWaist { get; set; }
        public decimal StartHip { get; set; }
        public string BandSize { get; set; }
        public string ReservoirSite { get; set; }
        public decimal BalloonVolume { get; set; }
        public string Pathway { get; set; }
        public string Indication { get; set; }
        public string Procedure { get; set; }
        public string Findings { get; set; }
        public string Closure { get; set; }
        public decimal BloodLoss { get; set; }
        public string RouxLimbLength { get; set; }
        public string RouxColic { get; set; }
        public string RouxGastric { get; set; }
        public string RouxEnterostomy { get; set; }
        public bool Banded { get; set; }
        public string VbgstomaSize { get; set; }
        public string VbgstomaWrap { get; set; }
        public decimal BpdstomachSize { get; set; }
        public string BpdilealLength { get; set; }
        public string BpdchannelLength { get; set; }
        public bool BpdduodenalSwitch { get; set; }
        public string TubeSize { get; set; }
        public bool PreviousSurgery { get; set; }
        public string PrevAbdoSurgery1 { get; set; }
        public string PrevAbdoSurgery2 { get; set; }
        public string PrevAbdoSurgery3 { get; set; }
        public string PrevAbdoSurgeryNotes { get; set; }
        public bool PrevPelvicSurgery { get; set; }
        public string PrevPelvicSurgery1 { get; set; }
        public string PrevPelvicSurgery2 { get; set; }
        public string PrevPelvicSurgery3 { get; set; }
        public string PrevPelvicSurgeryNotes { get; set; }
        public bool ComcomitantSurgery { get; set; }
        public string ComcomitantSurgery1 { get; set; }
        public string ComcomitantSurgery2 { get; set; }
        public string ComcomitantSurgery3 { get; set; }
        public string ComcomitantSurgeryNotes { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedByUser { get; set; }
        public string CreatedByComputer { get; set; }
        public DateTime? LastModified { get; set; }
        public string ModifiedByUser { get; set; }
        public string ModifiedByComputer { get; set; }
        public string CreatedByWindowsUser { get; set; }
        public string ModifiedByWindowsUser { get; set; }
        public string GeneralNotes { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedByUser { get; set; }
        public string LapbandType { get; set; }
        public string InRoomTime { get; set; }
        public string OutRoomTime { get; set; }
        public string SurgeryStartTime { get; set; }
        public string SurgeryEndTime { get; set; }
        public string FirstAssistant { get; set; }
        public string Bougie { get; set; }
        public string PreopHematocrit { get; set; }
        public DateTime? PreopHematocritDate { get; set; }
        public string PreopAlbumin { get; set; }
        public DateTime? PreopAlbuminDate { get; set; }
        public string OtherProcedure { get; set; }
        public int? NumberBloodTranfusion { get; set; }
        public int? NumberIntraopTranfusion { get; set; }
        public bool? UnplannedAdmission { get; set; }
        public bool? TransferAcuteCare { get; set; }
    }
}
