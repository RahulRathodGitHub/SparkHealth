using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblUserTrust
    {
        public int TblUserTrustId { get; set; }
        public int OrganizationCode { get; set; }
        public int TrustUserPracticeCode { get; set; }
        public int TrusteeUserPracticeCode { get; set; }
        public int PatientId { get; set; }
        public bool UsePatientTitle { get; set; }
        public bool UsePatientData { get; set; }
        public DateTime? Fdate { get; set; }
        public DateTime? Tdate { get; set; }
        public int AccessPermission { get; set; }
        public string Remark { get; set; }
    }
}
