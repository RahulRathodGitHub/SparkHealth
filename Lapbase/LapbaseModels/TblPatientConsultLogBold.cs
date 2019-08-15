﻿using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPatientConsultLogBold
    {
        public int TblPatientConsultComorbidityLogId { get; set; }
        public int TblPatientConsultComorbidityId { get; set; }
        public int OrganizationCode { get; set; }
        public int? PatientId { get; set; }
        public int? ConsultId { get; set; }
        public string CvsHypertension { get; set; }
        public string CvsCongestive { get; set; }
        public string CvsIschemic { get; set; }
        public string CvsAngina { get; set; }
        public string CvsPeripheral { get; set; }
        public string CvsLower { get; set; }
        public string CvsDvt { get; set; }
        public string MetGlucose { get; set; }
        public string MetLipids { get; set; }
        public string MetGout { get; set; }
        public string PulObstructive { get; set; }
        public string PulObesity { get; set; }
        public string PulPulHypertension { get; set; }
        public string PulAsthma { get; set; }
        public string GasGerd { get; set; }
        public string GasCholelithiasis { get; set; }
        public string GasLiver { get; set; }
        public string MusBackPain { get; set; }
        public string MusMusculoskeletal { get; set; }
        public string MusFibromyalgia { get; set; }
        public string ReprdPolycystic { get; set; }
        public string ReprdMenstrual { get; set; }
        public string PsyImpairment { get; set; }
        public string PsyDepression { get; set; }
        public string PsyMentalHealth { get; set; }
        public string PsyAlcohol { get; set; }
        public string PsyTobacoo { get; set; }
        public string PsyAbuse { get; set; }
        public string GenStress { get; set; }
        public string GenCerebri { get; set; }
        public string GenHernia { get; set; }
        public string GenFunctional { get; set; }
        public string GenSkin { get; set; }
        public string GenRenalInsuff { get; set; }
        public string GenRenalFail { get; set; }
        public string GenSteroid { get; set; }
        public string GenTherapeutic { get; set; }
        public string GenPrevPcisurgery { get; set; }
        public string VitaminList { get; set; }
        public string VitaminDescription { get; set; }
        public DateTime? PatientVisitDate { get; set; }
        public decimal PatientHeight { get; set; }
        public decimal PatientWeight { get; set; }
        public bool BoldFlag { get; set; }
        public string BoldVisitId { get; set; }
        public string SupportGroup { get; set; }
        public string AcsSmoke { get; set; }
        public string AcsOxy { get; set; }
        public string AcsEmbo { get; set; }
        public string AcsCopd { get; set; }
        public string AcsCpap { get; set; }
        public string AcsGerd { get; set; }
        public string AcsGal { get; set; }
        public string AcsMuscd { get; set; }
        public string AcsPain { get; set; }
        public string AcsMeds { get; set; }
        public string AcsSurg { get; set; }
        public string AcsMob { get; set; }
        public string AcsUri { get; set; }
        public string AcsMyo { get; set; }
        public string AcsPci { get; set; }
        public string AcsCsurg { get; set; }
        public string AcsLipid { get; set; }
        public string AcsHyper { get; set; }
        public string AcsDvt { get; set; }
        public string AcsVenous { get; set; }
        public string AcsHealth { get; set; }
        public string AcsDiab { get; set; }
        public string AcsObese { get; set; }
        public string AusEndDiab { get; set; }
        public string AusEndThy { get; set; }
        public string AusEndOtherName { get; set; }
        public string AusEndOtherDesc { get; set; }
        public string AusPulAsthma { get; set; }
        public string AusPulApnea { get; set; }
        public string AusPulEmb { get; set; }
        public string AusPulOtherName { get; set; }
        public string AusPulOtherDesc { get; set; }
        public string AusGasRef { get; set; }
        public string AusGasUlc { get; set; }
        public string AusGasGall { get; set; }
        public string AusGasHep { get; set; }
        public string AusGasOtherName { get; set; }
        public string AusGasOtherDesc { get; set; }
        public string AusCvsIsc { get; set; }
        public string AusCvsBlood { get; set; }
        public string AusCvsCol { get; set; }
        public string AusCvsDvt { get; set; }
        public string AusCvsVen { get; set; }
        public string AusCvsAnti { get; set; }
        public string AusCvsOtherName { get; set; }
        public string AusCvsOtherDesc { get; set; }
        public string AusPsyDep { get; set; }
        public string AusPsyAnx { get; set; }
        public string AusPsyPhob { get; set; }
        public string AusPsyEat { get; set; }
        public string AusPsyHead { get; set; }
        public string AusPsyStroke { get; set; }
        public string AusPsyOtherName { get; set; }
        public string AusPsyOtherDesc { get; set; }
        public string AusMuscBack { get; set; }
        public string AusMuscHip { get; set; }
        public string AusMuscKnee { get; set; }
        public string AusMuscFeet { get; set; }
        public string AusMuscFibr { get; set; }
        public string AusMuscOtherName { get; set; }
        public string AusMuscOtherDesc { get; set; }
        public string AusGenInf { get; set; }
        public string AusGenRen { get; set; }
        public string AusGenUri { get; set; }
        public string AusOtherPso { get; set; }
        public string AusOtherSkin { get; set; }
        public string AusOtherCancer { get; set; }
        public string AusOtherAnemia { get; set; }
        public string AusOtherOtherName { get; set; }
        public string AusOtherOtherDesc { get; set; }
        public string MedicationList { get; set; }
        public string AcsSho { get; set; }
        public string AcsFat { get; set; }
        public int? LogUserPracticeCode { get; set; }
        public DateTime? LogDateTime { get; set; }
    }
}
