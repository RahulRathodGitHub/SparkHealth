using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblReferringDoctors
    {
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public string RefDrId { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public byte UseFirst { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Suburb { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public bool? Hide { get; set; }
    }
}
