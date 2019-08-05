using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblErrorLogFile
    {
        public int TblErrorLogFileId { get; set; }
        public DateTime LogDateTime { get; set; }
        public int UserPracticeCode { get; set; }
        public int UserCode { get; set; }
        public string ClientIp { get; set; }
        public string UserName { get; set; }
        public string SchemaName { get; set; }
        public string ProcessName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
