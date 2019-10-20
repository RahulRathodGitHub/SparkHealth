using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{
    public class PatientDto
    {
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public short? Title { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Sex { get; set; }
        public string Race { get; set; }
        public string Insurance { get; set; }
        public DateTime? DateFirstVisit { get; set; }
        public DateTime? DateLastVisit { get; set; }
        public string MaritalStatus { get; set; }
        public string MedicalSummary { get; set; }
        public string DoctorName { get; set; }
        public string DoctorTelephone { get; set; }
        public string DoctorFax { get; set; }
        public DateTime? LapBandDate { get; set; }
        public string Notes { get; set; }
        public decimal? Height { get; set; }
        public decimal? StartWeight { get; set; }
        public DateTime? StartWeightDate { get; set; }
        public decimal? IdealWeight { get; set; }
        public decimal? CurrentWeight { get; set; }
        public decimal? OpWeight { get; set; }
        public decimal? TargetWeight { get; set; }
        public string SurgeryType { get; set; }
        public string Approach { get; set; }
        public decimal? StartBmiweight { get; set; }
        public int? VisitWeeksFlag { get; set; }
        public string LapbandType { get; set; }
        public string LapbandSize { get; set; }

    }
}
