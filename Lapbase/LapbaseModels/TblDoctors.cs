using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblDoctors
    {
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public int DoctorId { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Initial { get; set; }
        public string Title { get; set; }
        public string DoctorName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Degrees { get; set; }
        public string Speciality { get; set; }
        public byte? UseOwnLetterHead { get; set; }
        public string PrefSurgeryType { get; set; }
        public string PrefApproach { get; set; }
        public string PrefCategory { get; set; }
        public string PrefGroup { get; set; }
        public string CountryCode { get; set; }
        public string LapBandCode { get; set; }
        public bool? OtherType { get; set; }
        public bool? IsSurgeon { get; set; }
        public bool? Hide { get; set; }
        public string DoctorBoldCode { get; set; }
    }
}
