using Lapbase.LapbaseModels;
using Lapbase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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

        public async Task<List<Appointment>> GetAppointments()
        {
            return ToAppointment(await lapbaseContext.TblPatientConsult.ToListAsync(), 
                                 await lapbaseContext.TblDoctors.ToListAsync());
        }

        public async Task<List<Appointment>> GetAppointmentById(int id)
        {
            return ToAppointment(await lapbaseContext.TblPatientConsult.Where(p => p.PatientId == id).ToListAsync(),
                                 await lapbaseContext.TblDoctors.ToListAsync());
        }

        public List<Appointment> ToAppointment(List<TblPatientConsult> PatientConsults, List<TblDoctors> Doctors)
        {
            PatientConsults.OrderBy(t => t.DateSeen);

            var query =  from consult in PatientConsults
                         join doctor in Doctors
                         on consult.Seenby equals doctor.DoctorId into docPatientConsult // I want to add another condition for matching Organisation Code
                         from dpconsult in docPatientConsult.DefaultIfEmpty()
                         select new Appointment
                         {
                             Id = consult.ConsultId,
                             Title = "Appointment",
                             PatientId = consult.PatientId,
                             Start = consult.DateSeen,
                             End = consult.DateSeen,
                             Description = consult.Notes,// == null ? "No Notes were provided" : consult.Notes,
                             DoctorName = dpconsult.DoctorName,
                             Location = dpconsult.Address1+", "+dpconsult.Suburb+", "+dpconsult.Country
                         };

            List<Appointment> appointments = query.ToList();

            //Below logic needs to be cleaned
            TblPatientConsult lastConsult = PatientConsults.Last();
            Appointment futureAppointment = appointments.Last();
            futureAppointment.Start = lastConsult.DateNextVisit;
            futureAppointment.End = lastConsult.DateNextVisit;
            futureAppointment.Description = "";

            appointments.Add(futureAppointment);

            return appointments;
        }

    }
}
