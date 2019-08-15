using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPatientDocumentsContent
    {
        public int TblPatientDocumentsContentId { get; set; }
        public int TblPatientDocumentsId { get; set; }
        public byte[] ContentFile { get; set; }
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
    }
}
