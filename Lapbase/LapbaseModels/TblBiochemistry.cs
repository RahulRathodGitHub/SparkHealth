using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblBiochemistry
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int? Rank { get; set; }
        public string Type { get; set; }
        public int? BiochemistryGroup { get; set; }
    }
}
