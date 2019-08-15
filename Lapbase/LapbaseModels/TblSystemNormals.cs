using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblSystemNormals
    {
        public int UserPracticeCode { get; set; }
        public string Code { get; set; }
        public string TestType { get; set; }
        public string ImperialLow { get; set; }
        public string ImperialLowF { get; set; }
        public string ImperialHigh { get; set; }
        public string ImperialHighF { get; set; }
        public string ImperialUnits { get; set; }
        public string MetricLow { get; set; }
        public string MetricLowF { get; set; }
        public string MetricHigh { get; set; }
        public string MetricHighF { get; set; }
        public string MetricUnits { get; set; }
        public string ConversionImpToMetric { get; set; }
        public string Description { get; set; }
    }
}
