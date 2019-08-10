using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblLogos
    {
        public int LogoId { get; set; }
        public string LogoName { get; set; }
        public string LogoPath { get; set; }
        public int UserPracticeCode { get; set; }
        public int OrganizationCode { get; set; }
    }
}
