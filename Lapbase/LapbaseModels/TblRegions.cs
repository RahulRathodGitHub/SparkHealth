using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblRegions
    {
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public string RegionId { get; set; }
        public string RegionName { get; set; }
    }
}
