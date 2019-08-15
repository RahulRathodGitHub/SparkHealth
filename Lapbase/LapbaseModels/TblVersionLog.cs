using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblVersionLog
    {
        public decimal Version { get; set; }
        public string VersionNo { get; set; }
        public string ChangeLog { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public bool? Enabled { get; set; }
    }
}
