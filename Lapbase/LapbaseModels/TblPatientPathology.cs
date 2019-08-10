using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPatientPathology
    {
        public int OrganizationCode { get; set; }
        public int PatientId { get; set; }
        public int PathologyId { get; set; }
        public string PathologyBaseline { get; set; }
        public DateTime? PathologyDate { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedByUser { get; set; }
        public string RefDr { get; set; }
        public bool Review { get; set; }
    }
}
