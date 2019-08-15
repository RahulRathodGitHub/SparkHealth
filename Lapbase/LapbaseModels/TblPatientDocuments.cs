using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPatientDocuments
    {
        public int OrganizationCode { get; set; }
        public int TblPatientDocumentsId { get; set; }
        public int UserPracticeCode { get; set; }
        public int PatientId { get; set; }
        public string EventLink { get; set; }
        public long EventId { get; set; }
        public DateTime? EventDate { get; set; }
        public short DocumentType { get; set; }
        public string DocumentFileName { get; set; }
        public string DocumentName { get; set; }
        public long? DocumentFileSize { get; set; }
        public DateTime? UploadDate { get; set; }
        public bool IsDeleted { get; set; }
        public string DocDescription { get; set; }
    }
}
