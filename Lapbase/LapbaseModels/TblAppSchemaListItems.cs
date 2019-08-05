using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblAppSchemaListItems
    {
        public int Id { get; set; }
        public int TblAppschemaCode { get; set; }
        public string FieldId { get; set; }
        public byte ListValue { get; set; }
        public string ListTextEnglish { get; set; }
        public string ListTextArabic { get; set; }
        public string ListTextSpanish { get; set; }
        public string ListTextPortugese { get; set; }
    }
}
