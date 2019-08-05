using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblUserApplicationData
    {
        public string SessionId { get; set; }
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public int? PatientId { get; set; }
        public int? CunsultId { get; set; }
        public int? OperationId { get; set; }
        public int? ComplicationId { get; set; }
        public bool? Imperial { get; set; }
        public string LanguageCode { get; set; }
        public string CultureInfo { get; set; }
        public string Direction { get; set; }
        public bool? VisitWeeksFlag { get; set; }
        public string UserName { get; set; }
    }
}
