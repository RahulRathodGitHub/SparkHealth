using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Lapbase.Models;
using Lapbase.LapbaseModels;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Lapbase.OutputModels;

namespace Lapbase.Services
{
    public class PatientService
    {
        private readonly LapbaseContext lapbaseContext;
        private readonly LapbaseNewContext lapbaseNewContext;
        private readonly IConfiguration config;

        public PatientService(
            IConfiguration config,
            LapbaseContext lapbaseContext,
            LapbaseNewContext lapbaseNewContext)
        {
            this.lapbaseContext = lapbaseContext;
            this.lapbaseNewContext = lapbaseNewContext;
            this.config = config;
        }

        public async Task<List<Patient>> GetPatients()
        {
            return await lapbaseNewContext.Patient.ToListAsync();
        }

        /*
         * Obtain all available foods for a particular patient
         */ 
        public async Task<List<Food>> GetPatientFood()
        {
            return await lapbaseNewContext.Food.ToListAsync();
        }

        /*
         * Obtain all the available exercises for a particular patient
         */ 
        public async Task<List<Exercise>> GetPatientExercise()
        {
            return await lapbaseNewContext.Exercise.ToListAsync();
        }

        /*
         * Obtain all the available data for a particular patient
         */ 
        public async Task<List<string>> GetPatientsLapbase()
        {
            return await lapbaseContext.TblPatients.Select(p => p.Firstname).ToListAsync();
        }

        /*
         * Get a particular patient from the list of patients
         */ 
        public async Task<Patient> GetPatientById(int id)
        {
            return await lapbaseNewContext.Patient.SingleOrDefaultAsync(p => p.Id == id);
        }

        /*
         * Get the required set of details for the logged in Patient.
         */ 
        public async Task<PatientDto> GetPatientLapbaseById(int id, int organizationCode)
        {
            return await (from p in lapbaseContext.TblPatients
                            join d in lapbaseContext.TblDoctors on p.DoctorId equals d.DoctorId
                            join pw in lapbaseContext.TblPatientWeightData on new { p.PatientId, p.OrganizationCode} equals new { pw.PatientId, pw.OrganizationCode }
                            where  p.PatientId == id && p.OrganizationCode == organizationCode
                            select new PatientDto
                            {
                                Firstname = p.Firstname,
                                Surname = p.Surname,
                                Title = p.Title,
                                WorkPhone = p.WorkPhone,
                                Suburb = p.Suburb,
                                Street = p.Street,
                                State = p.State,
                                Sex = p.Sex,
                                Race = p.Race,
                                Postcode = p.Postcode,
                                MobilePhone = p.MobilePhone,
                                HomePhone = p.HomePhone,
                                EmailAddress = p.EmailAddress,
                                Birthdate = p.Birthdate,
                                DateFirstVisit = p.DateFirstVisit,
                                DateLastVisit = p.DateLastVisit,
                                MaritalStatus = p.MaritalStatus,
                                MedicalSummary = p.MedicalSummary,
                                Insurance = p.Insurance,
                                DoctorName = d.DoctorName,
                                DoctorFax = d.Fax,
                                DoctorTelephone = d.Telephone,
                                LapBandDate = pw.LapBandDate,
                                Notes = pw.Notes,
                                Height = pw.Height,
                                StartWeight = pw.StartWeight,
                                StartWeightDate = pw.StartWeightDate,
                                IdealWeight = pw.IdealWeight,
                                CurrentWeight = pw.CurrentWeight,
                                OpWeight = pw.OpWeight,
                                TargetWeight = pw.TargetWeight,
                                SurgeryType = pw.SurgeryType,
                                Approach = pw.Approach,
                                StartBmiweight = pw.StartBmiweight,
                                VisitWeeksFlag = pw.VisitWeeksFlag,
                                LapbandType = pw.LapbandType,
                                LapbandSize =pw.LapbandSize
                            }).FirstOrDefaultAsync();


        }

        #region Helper Methods
        /*
         * Get the imperial flag for the logged in Patient
         */
        public async Task<Boolean?> GetPatientImperial(int id, int organizationCode)
        {
            return await lapbaseContext.TblUserApplicationData.Where(u => u.PatientId == id && u.OrganizationCode == organizationCode).Select(P => P.Imperial).FirstOrDefaultAsync();
        }

        /*
        * Get the Height for the logged in Patient
        */
        public async Task<Decimal?> GetPatientHeight(int id, int organizationCode)
        {
            return await lapbaseContext.TblPatientWeightData.Where(p => p.PatientId == id && p.OrganizationCode == organizationCode).Select(p => p.Height).FirstOrDefaultAsync();
           
        }
        #endregion


        /*
         *  Creates a patient
         */
        public async Task<Patient> CreatePatient(Patient patient)
        {
            patient.WhenCreated = DateTimeOffset.UtcNow;
            var result = await lapbaseNewContext.Patient.AddAsync(patient);

            await lapbaseNewContext.SaveChangesAsync();

            return result.Entity;
        }

    }
}
