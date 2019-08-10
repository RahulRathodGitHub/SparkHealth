using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblOrganization
    {
        public int Code { get; set; }
        public string OrgDomainName { get; set; }
        public decimal? VersionNo { get; set; }
        public int? ApplicationMode { get; set; }
        public bool? IsActivated { get; set; }
        public string LanguageCode { get; set; }
        public string CultureInfo { get; set; }
        public bool SuperBill { get; set; }
        public bool DataClamp { get; set; }
        public string DefaultSort { get; set; }
        public bool? Emr { get; set; }
        public string SubmitData { get; set; }
        public string PracticeBoldCode { get; set; }
        public string AdminEmail { get; set; }
        public bool InactiveFlag { get; set; }
        public string Ifsocode { get; set; }
        public bool? Export { get; set; }
        public bool? Bsrexport { get; set; }
        public string ConnectionString { get; set; }
    }
}
