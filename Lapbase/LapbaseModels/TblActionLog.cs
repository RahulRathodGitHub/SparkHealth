using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblActionLog
    {
        public int TblActionLogId { get; set; }
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public string ComputerName { get; set; }
        public string Page { get; set; }
        public string Action { get; set; }
        public string ActionDetail { get; set; }
        public string PatientId { get; set; }
        public string RecordId { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
