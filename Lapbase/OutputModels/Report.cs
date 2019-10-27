using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.OutputModels
{
    public class Report
    {
        public List<decimal?> Data1{ get; set; }
        public String DataLabel1 { get; set; }

        public List<decimal?> Data2 { get; set; }
        public String DataLabel2 { get; set; }

        public List<string> TimeLabels { get; set; }

        public Report() {

            this.Data1 = new List<decimal?>();
            this.DataLabel1 = "";

            this.Data2 = new List<decimal?>();
            this.DataLabel2 = "";

            this.TimeLabels = new List<string>();
        }

        public void AddEntry(decimal? data, String dataLabel, string timeLabel)
        {
            this.Data1.Add(data);
            this.DataLabel1 = dataLabel;
            this.TimeLabels.Add(timeLabel);
        }


        public void AddEntry(decimal? data1, String dataLabel1, decimal? data2, String dataLabel2, string timeLabel)
        {
            this.Data1.Add(data1);
            this.DataLabel1 = dataLabel1;

            this.Data2.Add(data2);
            this.DataLabel2 = dataLabel2;

            this.TimeLabels.Add(timeLabel);
        }
    }

}
