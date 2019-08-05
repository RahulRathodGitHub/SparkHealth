using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblSystemDetails
    {
        public int SystemId { get; set; }
        public string SystemName { get; set; }
        public string SystemType { get; set; }
        public DateTime? DateInstalled { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CountryCode { get; set; }
        public string SystemCode { get; set; }
        public bool? Imperial { get; set; }
        public string Woscale { get; set; }
        public decimal TargetBmi { get; set; }
        public decimal ReferenceBmi { get; set; }
        public string BackUpLocation { get; set; }
        public string Mfu3 { get; set; }
        public string Mfu6 { get; set; }
        public string Mfu12 { get; set; }
        public string Fu1y { get; set; }
        public string Fu2y { get; set; }
        public string Fu3y { get; set; }
        public string Fu4y { get; set; }
        public short Fu1 { get; set; }
        public short Fu2 { get; set; }
        public short Fu3 { get; set; }
        public short Rd1 { get; set; }
        public short Rd2 { get; set; }
        public short Cv { get; set; }
        public short UseRace { get; set; }
        public string EwperCent { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedByUser { get; set; }
        public string CreatedByComputer { get; set; }
        public DateTime? LastModified { get; set; }
        public string ModifiedByUser { get; set; }
        public string ModifiedByComputer { get; set; }
        public short? ComordityVisitMonths { get; set; }
        public bool? IdealOnBmi { get; set; }
        public bool? Fupnotes { get; set; }
        public bool? Fucom { get; set; }
        public bool? Fuinv { get; set; }
        public bool? PatCom { get; set; }
        public bool? PatInv { get; set; }
        public int UserPracticeCode { get; set; }
        public int VisitWeeksFlag { get; set; }
        public int? OrganizationCode { get; set; }
        public int? LetterheadMargin { get; set; }
        public bool? AutoSave { get; set; }
        public string FacilityName { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public short? TargetExcessWeight { get; set; }
    }
}
