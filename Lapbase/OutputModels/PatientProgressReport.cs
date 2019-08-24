using Lapbase.OutputModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.OutputModels
{
    public class PatientProgressReport: IReport
    {
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientTitle { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Nullable<int> AGE { get; set; }
        public string dateseen { get; set; }
        public string LapbandDate { get; set; }
        public Nullable<decimal> StartEW { get; set; }
        [NotMapped]
        public string WeightMeasurement { get; set; }
        public Nullable<decimal> StartWeight { get; set; }
        public Nullable<decimal> IdealWeight { get; set; }
        public Nullable<decimal> BMIHeight { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> InitBMI { get; set; }
        public Nullable<decimal> BMI { get; set; }
        public Nullable<decimal> EWLL { get; set; }
        public Nullable<decimal> TWL { get; set; }
        public Nullable<DateTime> ReportDate { get; set; }

    }
}
