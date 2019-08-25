using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lapbase.OutputModels
{
    public class EWL_WL_GraphReport : IReport
    {
        public Nullable<DateTime> DateSeen { get; set; }
        public string DateSeen_MY { get; set; }
        public string strDateSeen { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<decimal> EWL { get; set; }
        public string PatientName { get; set; }
        public Nullable<decimal> InitBMI { get; set; }
        public Nullable<int> AGE { get; set; }
        public string strLapBandDate { get; set; }
        public Nullable<Boolean> ImperialFlag { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> CurrentWeight { get; set; }
        public Nullable<decimal> TargetWeight { get; set; }
        public Nullable<decimal> IdealWeight { get; set; }
        public Nullable<decimal> StartWeight { get; set; }
        public string HeightMeasurment { get; set; }
        public string WeightMeasurment { get; set; }
        public Nullable<int> visitWeeksFlag { get; set; }
        public string strZeroDate { get; set; }
    }
}
    
