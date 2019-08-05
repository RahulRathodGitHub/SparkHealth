using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPatientPathologyData
    {
        public int OrganizationCode { get; set; }
        public int PatientId { get; set; }
        public int PathologyId { get; set; }
        public DateTime? PathologyDataDate { get; set; }
        public int SectionId { get; set; }
        public string TestId { get; set; }
        public string TestName { get; set; }
        public string TestValue { get; set; }
        public string TestUnit { get; set; }
        public string TestRange { get; set; }
        public string TestStatus { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedByUser { get; set; }
    }
}
