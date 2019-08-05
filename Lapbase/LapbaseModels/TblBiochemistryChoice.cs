using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblBiochemistryChoice
    {
        public int BiochemistryChoiceId { get; set; }
        public string BiochemistryCode { get; set; }
        public string ChoiceCode { get; set; }
        public string ChoiceDescription { get; set; }
        public int? Rank { get; set; }
    }
}
