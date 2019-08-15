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
            return ToAppointment(await lapbaseContext.TblPatientConsult.ToListAsync());
        }

        public async Task<List<Appointment>> GetAppointmentById(int id)
        {
            return ToAppointment(await lapbaseContext.TblPatientConsult.Where(p => p.PatientId == id).ToListAsync());
        }

        public Appointment ToAppointment(TblPatientConsult PatientConsult)
        {
            Appointment appointment = new Appointment();
            appointment.Id = PatientConsult.ConsultId;
            appointment.Title = PatientConsult.ConsultType;
            appointment.PatientId = PatientConsult.PatientId;
            appointment.Start = PatientConsult.DateSeen;
            appointment.End = PatientConsult.DateSeen;

            return appointment;
        }

        public List<Appointment> ToAppointment(List<TblPatientConsult> PatientConsults)
        {
            //List<TblPatientConsult> patientConsults = PatientConsults.OrderBy(TblPatientConsult[0]);
            List<Appointment> appointments = new List<Appointment>();

            foreach(TblPatientConsult consult in PatientConsults){

                Appointment appointment = new Appointment();
                appointment.Id = consult.ConsultId;
                appointment.Title = "Appointment";
                appointment.PatientId = consult.PatientId;
                appointment.Start = consult.DateSeen;
                appointment.End = consult.DateSeen;

                appointments.Add(appointment);   

            }

            TblPatientConsult lastConsult = PatientConsults.Last();
            Appointment futureAppointment = new Appointment();
            futureAppointment.Id = lastConsult.ConsultId;
            futureAppointment.Title = "Appointment";
            futureAppointment.PatientId = lastConsult.PatientId;
            futureAppointment.Start = lastConsult.DateNextVisit;
            futureAppointment.End = lastConsult.DateNextVisit;

            appointments.Add(futureAppointment);

            return appointments;
        }
    }
}
