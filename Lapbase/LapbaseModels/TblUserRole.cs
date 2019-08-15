using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblUserRole
    {
        public int TblUserRolesId { get; set; }
        public int OrganizationCode { get; set; }
        public int UserPracticeCode { get; set; }
        public int TblRoleId { get; set; }
    }
}
