using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblSystemCodes
    {
        public int UserPracticeCode { get; set; }
        public string Code { get; set; }
        public string BoldCode { get; set; }
        public string CategoryCode { get; set; }
        public string Score { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public int? Rank { get; set; }
    }
}
