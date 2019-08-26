using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.OutputModels
{
    public class Report
    {
        public List<decimal?> Data { get; set; }
        public List<string> Labels { get; set; }

        public Report()
        {
            this.Data = new List<decimal?>();
            this.Labels = new List<string>();
        }

        public void AddEntry(decimal? data, string label)
        {
            this.Data.Add(data);
            this.Labels.Add(label);
        }
    }

}
