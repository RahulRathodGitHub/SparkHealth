using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{
    [Table("PatientProgressReport")]
    public class PatientProgressReport
    {
        [Key]
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientTitle { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int AGE { get; set; }
        public string dateseen { get; set; }
        public string LapbandDate { get; set; }
        public decimal StartEW { get; set; }
        [NotMapped]
        public string WeightMeasurement { get; set; }
        public decimal StartWeight { get; set; }
        public decimal IdealWeight { get; set; }
        public decimal BMIHeight { get; set; }
        public decimal Weight { get; set; }
        public decimal InitBMI { get; set; }
        public decimal BMI { get; set; }
        public decimal EWLL { get; set; }
        public decimal TWL { get; set; }
        public DateTime ReportDate { get; set; }



        //public int OrganisationCode { get; set; }
        //public int SurgeonId { get; set; }
        //public string HospitalCode { get; set; }
        //public string RegionId { get; set; }
        //public Boolean ImperialFlag { get; set; }
        //public int FAge { get; set; }
        //public int TAge { get; set; }
        //public int FBMI { get; set; }
        //public int TBMI { get; set; }
        //public string GroupCode { get; set; }
        //public string SurgeryType { get; set; }
        //public string BandType { get; set; }
        //public string Approach { get; set; }
        //public string Category { get; set; }
        //public string BandSize { get; set; }
        //public int ReportType { get; set; }
    }
}
