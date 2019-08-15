using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblPatientConsultFollowup
    {
        public int OrganizationCode { get; set; }
        public int PatientId { get; set; }
        public string FollowupAppointment { get; set; }
        public string FollowupPhone { get; set; }
        public string FollowupLetterPatient { get; set; }
        public string FollowupLetterPhysician { get; set; }
        public string FollowupTransfer { get; set; }
        public string FollowupRefuse { get; set; }
        public string FollowupLost { get; set; }
        public string FollowupTransferName { get; set; }
        public bool? FollowupDoNotContact { get; set; }
        public DateTime? FollowupDate { get; set; }
    }
}
