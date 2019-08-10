using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPrevOp
    {
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public int PatientId { get; set; }
        public int PrevOpId { get; set; }
        public int Year { get; set; }
        public decimal OriginalWeight { get; set; }
        public bool OriginalWeightActual { get; set; }
        public decimal LowestWeightAchieved { get; set; }
        public bool LowestWeightAchievedActual { get; set; }
        public string PrevOpSurgery { get; set; }
        public string PrevOpEvent { get; set; }
        public int DoctorId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedByUser { get; set; }
        public string CreatedByWindowsUser { get; set; }
        public string CreatedByComputer { get; set; }
        public DateTime? LastModified { get; set; }
        public string ModifiedByUser { get; set; }
        public string ModifiedByWindowsUser { get; set; }
        public string ModifiedByComputer { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedByUser { get; set; }
    }
}
