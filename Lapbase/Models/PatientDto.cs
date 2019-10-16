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

    }
}
