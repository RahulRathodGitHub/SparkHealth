using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPatientBioChemistry
    {
        public int BiochemistryNum { get; set; }
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public int PatientId { get; set; }
        public DateTime? BiochemistryDate { get; set; }
        public string BiochemistryValue { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedByUser { get; set; }
        public DateTime? LastModified { get; set; }
        public string ModifiedByUser { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedByUser { get; set; }
    }
}
