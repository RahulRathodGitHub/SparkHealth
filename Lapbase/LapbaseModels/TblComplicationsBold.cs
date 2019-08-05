using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblComplicationsBold
    {
        public int TblComplicationsId { get; set; }
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public int PatientId { get; set; }
        public int ComplicationNum { get; set; }
        public DateTime? ComplicationDate { get; set; }
        public string ComplicationCode { get; set; }
        public string FacilityCode { get; set; }
        public string AdverseSurgery { get; set; }
        public int DoctorId { get; set; }
        public bool BoldFlag { get; set; }
        public string BoldAdverseEventId { get; set; }
    }
}
