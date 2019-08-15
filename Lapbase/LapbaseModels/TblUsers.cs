using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblUsers
    {
        public int UserPracticeCode { get; set; }
        public string Userid { get; set; }
        public byte[] Userpw { get; set; }
        public int PermissionFlag { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string UserSirname { get; set; }
        public string LanguageCode { get; set; }
        public string CultureInfo { get; set; }
        public DateTime ActivateDate { get; set; }
        public string PermissionLevel { get; set; }
        public int? SurgeonId { get; set; }
        public bool? ShowLog { get; set; }
        public bool? ShowRegistry { get; set; }
        public bool? ShowDownloadExcelGraph { get; set; }
        public bool? UserMustChangePasswordFlag { get; set; }
        public string MobileNumber { get; set; }
    }
}
