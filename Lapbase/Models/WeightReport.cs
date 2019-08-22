using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{
    public class WeightReport: IReport
    {
        public List<decimal> Weight { get; set; }
        public List<DateTime?> weightRecordedTime { get; set; }

        public WeightReport()
        {
            this.Weight = new List<decimal>();
            this.weightRecordedTime = new List<DateTime?>();
        }
    }

}
