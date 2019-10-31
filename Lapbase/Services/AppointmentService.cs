using Lapbase.LapbaseModels;
using Lapbase.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Services
{
    /*
     *  Services to facilitate processings related to the Appointment requests.
     */
    public class AppointmentService
    {
        private readonly LapbaseContext lapbaseContext;
        private readonly LapbaseNewContext lapbaseNewContext;
        private readonly IConfiguration config;

        public AppointmentService(
            IConfiguration config,
            LapbaseContext lapbaseContext,
            LapbaseNewContext lapbaseNewContext)
        {
            this.lapbaseContext = lapbaseContext;
            this.lapbaseNewContext = lapbaseNewContext;
            this.config = config;
        }

        /*
         *  Provides a List of Appointment Objects corresponding to the logged in Patient’s Id
         *  and his/her Organization Code.
         */
        public async Task<List<Appointment>> GetAppointments(string userName)
        {
            var patientDetails = lapbaseNewContext.Patient.Where(p => p.Username == userName).FirstOrDefault();
            var patientAppointments = lapbaseContext.TblPatientConsult.Where(c => c.PatientId == patientDetails.PatientCode &&
                c.OrganizationCode == patientDetails.OrganisationCode);
            var result = await patientAppointments.Join(
                    lapbaseContext.TblDoctors,
                    c => c.Seenby,
                    d => d.DoctorId,
                    (consult, doctor) => new Appointment()
                    {
                        Id = consult.ConsultId,
                        Title = "Appointment",
                        PatientId = consult.PatientId,
                        Start = consult.DateSeen,
                        End = consult.DateSeen,
                        Description = consult.Notes,
                        DoctorName = doctor.DoctorName,
                        Location = doctor.Address1 + ", " + doctor.Suburb + ", " + doctor.Country,
                        Weight = consult.Weight,
                        Bmi = consult.Bmiweight
                    }
                ).ToListAsync();

            TblPatientConsult lastConsult = patientAppointments.Last();
            Appointment futureAppointment = new Appointment(result.Last());
            futureAppointment.Start = lastConsult.DateNextVisit;
            futureAppointment.End = lastConsult.DateNextVisit;
            futureAppointment.Description = "";
            futureAppointment.Weight = 0;
            futureAppointment.Bmi = 0;

            result.Add(futureAppointment);
            return result;
        }

        /*
         * Provides the logged in Patient’s Next Appointment on being called.
         */
        public async Task<Appointment> GetNextAppointment(string userName)
        {
            var patientDetails = lapbaseNewContext.Patient.Where(p => p.Username == userName).FirstOrDefault();
            var patientAppointments = lapbaseContext.TblPatientConsult.Where(c => c.PatientId == patientDetails.PatientCode &&
                c.OrganizationCode == patientDetails.OrganisationCode);
            var result = await patientAppointments.Join(
                    lapbaseContext.TblDoctors,
                    c => c.Seenby,
                    d => d.DoctorId,
                    (consult, doctor) => new Appointment()
                    {
                        Id = consult.ConsultId,
                        Title = "Appointment",
                        PatientId = consult.PatientId,
                        Start = consult.DateSeen,
                        End = consult.DateSeen,
                        Description = consult.Notes,
                        DoctorName = doctor.DoctorName,
                        Location = doctor.Address1 + ", " + doctor.Suburb + ", " + doctor.Country,
                        Weight = consult.Weight,
                        Bmi = consult.Bmiweight
                    }
                ).ToListAsync();

            TblPatientConsult lastConsult = patientAppointments.Last();
            Appointment futureAppointment = new Appointment(result.Last());
            futureAppointment.Start = lastConsult.DateNextVisit;
            futureAppointment.End = lastConsult.DateNextVisit;
            futureAppointment.Description = "";
            futureAppointment.Weight = 0;
            futureAppointment.Bmi = 0;

            return futureAppointment;
        }
    }
}
