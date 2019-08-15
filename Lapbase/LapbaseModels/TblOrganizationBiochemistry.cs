using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblOrganizationBiochemistry
    {
        public int OrgBiochemId { get; set; }
        public int? OrganizationCode { get; set; }
        public string BiochemistryCode { get; set; }
    }
}
