﻿using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblFollowUpNotes
    {
        public string Notes { get; set; }
        public int UserPracticeCode { get; set; }
        public int OrganizationCode { get; set; }
    }
}
