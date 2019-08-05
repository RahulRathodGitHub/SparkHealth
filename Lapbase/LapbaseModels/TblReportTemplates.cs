using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblReportTemplates
    {
        public string ReportTemplateName { get; set; }
        public int UserPracticeCode { get; set; }
        public int OrganizationCode { get; set; }
        public int? TemplateId { get; set; }
    }
}
