using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblUserActivationCode
    {
        public int Id { get; set; }
        public int? UserPracticeCode { get; set; }
        public long? ActivationCode { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public bool? IsExpired { get; set; }
    }
}
