using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{

    public class Appointment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public int PatientId { get; set; }
        public string Description { get; set; }
        public string DoctorName { get; set; }
        public string Location { get; set; }
        public decimal Weight { get; set; }
        public decimal Bmi { get; set; }

        public Appointment(Appointment anotherAppointment)
        {
            this.Id = 0;
            this.Title = anotherAppointment.Title;
            this.Start = anotherAppointment.Start;
            this.End = anotherAppointment.End;
            this.PatientId = anotherAppointment.PatientId;
            this.Description = anotherAppointment.Description;
            this.DoctorName = anotherAppointment.DoctorName;
            this.Location = anotherAppointment.Location;
            this.Weight = anotherAppointment.Weight;
            this.Bmi = anotherAppointment.Bmi;
        }

        public Appointment()
        {
            
        }

    }

}
