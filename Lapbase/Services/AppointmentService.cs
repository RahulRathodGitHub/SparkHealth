using Lapbase.LapbaseModels;
using Lapbase.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Services
{
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

        public async Task<List<Appointment>> GetAppointmentById(int id, int organizationCode)
        {
            var patientAppointments = lapbaseContext.TblPatientConsult.Where(c => c.PatientId == id && c.OrganizationCode == organizationCode);
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
                        Description = consult.Notes,// == null ? "No Notes were provided" : consult.Notes,
                        DoctorName = doctor.DoctorName,
                        Location = doctor.Address1 + ", " + doctor.Suburb + ", " + doctor.Country
                    }
                ).ToListAsync();

            //Below logic needs to be cleaned
            TblPatientConsult lastConsult = patientAppointments.Last();
            Appointment futureAppointment = result.Last();
            futureAppointment.Start = lastConsult.DateNextVisit;
            futureAppointment.End = lastConsult.DateNextVisit;
            futureAppointment.Description = "";

            result.Add(futureAppointment);

            return result;
        }
    }
}
