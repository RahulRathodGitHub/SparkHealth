using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblHospitals
    {
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public string HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HospitalBoldCode { get; set; }
        public string RegionId { get; set; }
    }
}
