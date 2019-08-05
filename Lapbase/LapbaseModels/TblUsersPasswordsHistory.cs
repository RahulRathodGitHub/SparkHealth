using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblUsersPasswordsHistory
    {
        public int TblUsersPasswordsHistoryId { get; set; }
        public int UserPracticeCode { get; set; }
        public byte[] OldPassword { get; set; }
        public DateTime OldActivateDate { get; set; }
    }
}
