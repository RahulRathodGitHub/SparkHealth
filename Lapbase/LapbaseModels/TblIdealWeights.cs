using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblIdealWeights
    {
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public double Height { get; set; }
        public double? IdealWeight { get; set; }
        public double? IdealWeightFemale { get; set; }
    }
}
