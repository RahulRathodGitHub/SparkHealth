using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{
    /*public enum AppointmentType
    {
        //As in the lapbase website there were various visit types
    }*/

    public class Appointment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public int PatientId { get; set; }
        public string description { get; set; }

    }

}
