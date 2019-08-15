using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblImportDataLog
    {
        public long Id { get; set; }
        public string InputFileName { get; set; }
        public int? OrganizationCode { get; set; }
        public int? UserPracticeCode { get; set; }
        public int? TotalRows { get; set; }
        public int? ImportedRows { get; set; }
        public int? ExceptionRows { get; set; }
        public DateTime? ImportDate { get; set; }
    }
}
