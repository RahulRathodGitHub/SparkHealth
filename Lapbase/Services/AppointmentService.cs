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
                                 await lapbaseContext.TblDoctors.ToListAsync(), 
                                 await lapbaseContext.TblHospitals.ToListAsync());
        }

        public async Task<List<Appointment>> GetAppointmentById(int id)
        {
            return ToAppointment(await lapbaseContext.TblPatientConsult.Where(p => p.PatientId == id).ToListAsync(),
                                 await lapbaseContext.TblDoctors.ToListAsync(), 
                                 await lapbaseContext.TblHospitals.ToListAsync());
        }

        public List<Appointment> ToAppointment(List<TblPatientConsult> PatientConsults,
                                               List<TblDoctors> Doctors,
                                               List<TblHospitals> Hospitals)
        {
            var query =  from consult in PatientConsults
                         join doctor in Doctors
                         on consult.Seenby equals doctor.DoctorId into docPatientConsult // I want to add another condition for matching Organisation Code
                         from dpconsult in docPatientConsult.DefaultIfEmpty()
                         join hospital in Hospitals
                         on dpconsult.OrganizationCode equals hospital.OrganizationCode into mergedConsult
                         from mconsult in mergedConsult.DefaultIfEmpty()
                         select new Appointment
                         {
                             Id = consult.ConsultId,
                             Title = "Appointment",
                             PatientId = consult.PatientId,
                             Start = consult.DateSeen,
                             End = consult.DateSeen,
                             Description = consult.Notes,// == null ? "No Notes were provided" : consult.Notes,
                             DoctorName = dpconsult.DoctorName,
                             Location = mconsult.HospitalName
                         };

            //List<TblPatientConsult> patientConsults = PatientConsults.OrderBy(TblPatientConsult[0]);
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

        /*public List<Appointment> ToAppointment2(List<TblPatientConsult> PatientConsults, 
                                               List<TblDoctors> Doctors, 
                                               List<TblOrganization> Organisations)
        {
            //The join has a problem.
            var query =  from consult in PatientConsults
                         join doctor in Doctors
                         on consult.Seenby equals doctor.DoctorId into docPatientConsult
                         from dpconsult in docPatientConsult.DefaultIfEmpty(null)
                         join organisation in Organisations 
                         on dpconsult.OrganizationCode equals organisation.Code into mergedConsult
                         from mconsult in mergedConsult.DefaultIfEmpty(null)
                         select new Appointment
                         {
                            Id = consult.ConsultId,
                            Title = "Appointment",
                            PatientId = consult.PatientId,
                            Start = consult.DateSeen,
                            End = consult.DateSeen,
                            Description = consult.Notes,
                            DoctorName = dpconsult.DoctorName,
                            Location = mconsult.OrgDomainName
                        };

            var query2 = from consult in PatientConsults
                        select new Appointment
                        {
                            Id = consult.ConsultId,
                            Title = "Appointment",
                            PatientId = consult.PatientId,
                            Start = consult.DateSeen,
                            End = consult.DateSeen,
                            Description = consult.Notes,
                            DoctorName = "Doctor hahahha",
                            Location = "hahahahahahahahah"
                        };



            //for the next Visit just extract the last entry copy it and modify the start to the next date. then add it to the list.
            //List<TblPatientConsult> patientConsults = PatientConsults.OrderBy(TblPatientConsult[0]);
            List<Appointment> appointments = new List<Appointment>();

            foreach (TblPatientConsult consult in PatientConsults)
            {

                Appointment appointment = new Appointment();
                appointment.Id = consult.ConsultId;
                appointment.Title = "Appointment";
                appointment.PatientId = consult.PatientId;
                appointment.Start = consult.DateSeen;
                appointment.End = consult.DateSeen;
                appointment.Description = consult.Notes;

                appointments.Add(appointment);

            }

            TblPatientConsult lastConsult = PatientConsults.Last();
            Appointment futureAppointment = new Appointment();
            futureAppointment.Id = lastConsult.ConsultId;
            futureAppointment.Title = "Appointment";
            futureAppointment.PatientId = lastConsult.PatientId;
            futureAppointment.Start = lastConsult.DateNextVisit;
            futureAppointment.End = lastConsult.DateNextVisit;
            futureAppointment.Description = lastConsult.Notes;


            appointments.Add(futureAppointment);

            return appointments;

        }
        */
    }
}
