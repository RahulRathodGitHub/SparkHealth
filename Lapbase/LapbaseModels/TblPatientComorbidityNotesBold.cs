using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPatientComorbidityNotesBold
    {
        public int TblComorbidityNotesId { get; set; }
        public int OrganizationCode { get; set; }
        public int PatientId { get; set; }
        public int ConsultId { get; set; }
        public string Cvs { get; set; }
        public string Met { get; set; }
        public string Pul { get; set; }
        public string Gas { get; set; }
        public string Mus { get; set; }
        public string Reprd { get; set; }
        public string Psy { get; set; }
        public string Gen { get; set; }
    }
}
