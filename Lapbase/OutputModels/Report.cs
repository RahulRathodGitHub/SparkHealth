using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.OutputModels
{
    public class Report
    {
        public List<decimal?> Data1{ get; set; }
        public List<decimal?> Data2 { get; set; }
        public List<string> Labels { get; set; }

        public Report()
        {
            this.Data1 = new List<decimal?>();
            this.Data2 = new List<decimal?>();
            this.Labels = new List<string>();
        }

        public void AddEntry(decimal? data, string label)
        {
            this.Data1.Add(data);
            this.Labels.Add(label);
        }

        public void AddEntry(decimal? data1, decimal? data2, string label)
        {
            this.Data1.Add(data1);
            this.Data2.Add(data2);
            this.Labels.Add(label);
        }
    }

}
