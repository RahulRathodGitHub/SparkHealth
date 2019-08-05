using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblLanguages
    {
        public string LanguageCode { get; set; }
        public string LanguageName { get; set; }
        public byte? DefaultLanguage { get; set; }
        public string CultureInfo { get; set; }
        public string Direction { get; set; }
        public bool Enabled { get; set; }
    }
}
