using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblUsysUserObjectLogs
    {
        public int TblUsysUserObjectLogsSno { get; set; }
        public string ComputerName { get; set; }
        public int UserPracticeCode { get; set; }
        public string SystemUsername { get; set; }
        public string AccessUsername { get; set; }
        public string ObjectName { get; set; }
        public byte? ObjectType { get; set; }
        public string ActionName { get; set; }
        public string SchemaName { get; set; }
        public string SchemaCode { get; set; }
        public DateTime? OpenTime { get; set; }
    }
}
