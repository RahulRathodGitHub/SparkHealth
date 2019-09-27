
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.OutputModels
{
    public class CalorieReport
    {
        public List<decimal> CalorieGained { get; set; }
        public List<decimal> CalorieLost { get; set; }
        public List<DateTime?> RecordedTime { get; set; }

        public CalorieReport()
        {
            this.CalorieGained = new List<decimal>();
            this.CalorieLost = new List<decimal>();
            this.RecordedTime = new List<DateTime?>();
        }
    }
}