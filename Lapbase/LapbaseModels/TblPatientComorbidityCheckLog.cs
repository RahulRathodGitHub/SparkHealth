using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPatientComorbidityCheckLog
    {
        public int PatientComorbidityCheckLogId { get; set; }
        public int OrganizationCode { get; set; }
        public int PatientId { get; set; }
        public bool AusEndDiab { get; set; }
        public bool AusEndThy { get; set; }
        public bool AusEndOther { get; set; }
        public bool AusPulAsthma { get; set; }
        public bool AusPulApnea { get; set; }
        public bool AusPulEmb { get; set; }
        public bool AusPulOther { get; set; }
        public bool AusGasRef { get; set; }
        public bool AusGasUlc { get; set; }
        public bool AusGasGall { get; set; }
        public bool AusGasHep { get; set; }
        public bool AusGasOther { get; set; }
        public bool AusCvsIsc { get; set; }
        public bool AusCvsBlood { get; set; }
        public bool AusCvsCol { get; set; }
        public bool AusCvsDvt { get; set; }
        public bool AusCvsVen { get; set; }
        public bool AusCvsAnti { get; set; }
        public bool AusCvsOther { get; set; }
        public bool AusPsyDep { get; set; }
        public bool AusPsyAnx { get; set; }
        public bool AusPsyPhob { get; set; }
        public bool AusPsyEat { get; set; }
        public bool AusPsyHead { get; set; }
        public bool AusPsyStroke { get; set; }
        public bool AusPsyOther { get; set; }
        public bool AusMuscBack { get; set; }
        public bool AusMuscHip { get; set; }
        public bool AusMuscKnee { get; set; }
        public bool AusMuscFeet { get; set; }
        public bool AusMuscFibr { get; set; }
        public bool AusMuscOther { get; set; }
        public bool AusGenInf { get; set; }
        public bool AusGenRen { get; set; }
        public bool AusGenUri { get; set; }
        public bool AusOtherPso { get; set; }
        public bool AusOtherSkin { get; set; }
        public bool AusOtherCancer { get; set; }
        public bool AusOtherAnemia { get; set; }
        public bool AusOtherOther { get; set; }
        public int? LogUserPracticeCode { get; set; }
        public DateTime? LogDateTime { get; set; }
    }
}
