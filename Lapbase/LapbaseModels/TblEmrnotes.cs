using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblEmrnotes
    {
        public int NotesId { get; set; }
        public string Notes { get; set; }
        public int OrganizationCode { get; set; }
    }
}
