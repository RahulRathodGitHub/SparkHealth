using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblApplicationVersion
    {
        public decimal VersionNo { get; set; }
        public string ApplicationUrl { get; set; }
        public bool? Enabled { get; set; }
    }
}
