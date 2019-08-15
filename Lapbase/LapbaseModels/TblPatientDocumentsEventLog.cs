using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPatientDocumentsEventLog
    {
        public int TblPatientDocumentsEventLogId { get; set; }
        public int OrganizationCode { get; set; }
        public int TblPatientDocumentsId { get; set; }
        public short EventCode { get; set; }
        public int UserPracticeCode { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public string Notes { get; set; }
    }
}
