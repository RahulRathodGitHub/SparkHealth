using System;
using System.Collections.Generic;

namespace Lapbase.Models
{
    public class Patient
    {
        public int Id { get; set; }

        public string Username { get; set; }
        public DateTimeOffset WhenCreated { get; set; }
        public DateTimeOffset ValidFrom { get; set; }
        public DateTimeOffset ValidTo { get; set; }
        public bool Deleted { get; set; }

        public int PatientCode { get; set; }
        public int OrganisationCode { get; set; }
    }
}
