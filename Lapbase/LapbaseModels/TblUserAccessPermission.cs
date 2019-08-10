using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblUserAccessPermission
    {
        public int TblUserAccessPermissionId { get; set; }
        public int? TblAppschemaCode { get; set; }
        public int? AccessPermissionCode { get; set; }
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
    }
}
