using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPatientCommentLog
    {
        public int CommentLogId { get; set; }
        public int CommentId { get; set; }
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public int PatientId { get; set; }
        public DateTime? DateSeen { get; set; }
        public int Seenby { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedByUser { get; set; }
        public string CreatedByComputer { get; set; }
        public DateTime? LastModified { get; set; }
        public string ModifiedByUser { get; set; }
        public string ModifiedByComputer { get; set; }
        public string CreatedByWindowsUser { get; set; }
        public string ModifiedByWindowsUser { get; set; }
        public string Notes { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedByUser { get; set; }
        public int? LogUserPracticeCode { get; set; }
        public DateTime? LogDateTime { get; set; }
    }
}
