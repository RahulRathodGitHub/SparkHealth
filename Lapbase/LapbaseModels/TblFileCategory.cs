using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblFileCategory
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int OrderNo { get; set; }
        public int FacilityId { get; set; }
    }
}
