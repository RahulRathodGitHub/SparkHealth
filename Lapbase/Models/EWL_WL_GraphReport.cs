using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lapbase.Models
{
    [Table("EWL_WL_GraphReport")]
    public class EWL_WL_GraphReport: IReport
    {
        //public Guid Id { get; set; }
        [NotMapped]
        public string DateSeen { get; set; }
        public string DateSeen_MY { get; set; }
        public string strDateSeen { get; set; }
        [Key]
        public int PatientId { get; set; }
        [NotMapped]
        public string EWL { get; set; }
        public string PatientName { get; set; }
        public decimal InitBMI { get; set; }
        public decimal AGE { get; set; }
        public string strLapBandDate { get; set; }
        public decimal Weight { get; set; }
        public decimal CurrentWeight { get; set; }
        public decimal TargetWeight { get; set; }
        public decimal IdealWeight { get; set; }
        public decimal StartWeight { get; set; }
        public byte ImperialFlag { get; set; }
        public decimal HeightMeasurment { get; set; }
        public decimal WeightMeasurment { get; set; }
    }
}
