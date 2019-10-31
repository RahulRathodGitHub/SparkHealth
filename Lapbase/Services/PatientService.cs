using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Lapbase.Models;
using Lapbase.LapbaseModels;
using Microsoft.Extensions.Configuration;

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
         * Get a particular patient from the list of patients
         */
        public async Task<Patient> GetPatient(string userName)
        {
            return await lapbaseNewContext.Patient.SingleOrDefaultAsync(p => p.Username == userName);
        }

        /*
         * Get the required set of details for the logged in Patient.
         */
        public async Task<PatientDto> GetPatientLapbase(string userName)
        {
            var patientDetails = lapbaseNewContext.Patient.Where(p => p.Username == userName).FirstOrDefault();
            var patientDto = await (from p in lapbaseContext.TblPatients
                          join d in lapbaseContext.TblDoctors on p.DoctorId equals d.DoctorId
                          join pw in lapbaseContext.TblPatientWeightData on new { p.PatientId, p.OrganizationCode } equals new { pw.PatientId, pw.OrganizationCode }
                          where p.PatientId == patientDetails.PatientCode && p.OrganizationCode == patientDetails.OrganisationCode
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
                              LapbandSize = pw.LapbandSize
                          }).FirstOrDefaultAsync();
            return patientDto;
        }

        #region Helper Methods
        /*
         * Get the imperial flag for the logged in Patient
         */
        public async Task<bool?> GetPatientImperial(string userName)
        {
            var patientDetails = lapbaseNewContext.Patient.Where(p => p.Username == userName).FirstOrDefault();
            return await lapbaseContext.TblUserApplicationData.Where(u => u.PatientId == patientDetails.PatientCode &&
                u.OrganizationCode == patientDetails.OrganisationCode).Select(P => P.Imperial).FirstOrDefaultAsync();
        }

        /*
        * Get the Height for the logged in Patient
        */
        public async Task<decimal?> GetPatientHeight(string userName)
        {
            var patientDetails = lapbaseNewContext.Patient.Where(p => p.Username == userName).FirstOrDefault();
            return await lapbaseContext.TblPatientWeightData.Where(p => p.PatientId == patientDetails.PatientCode &&
                p.OrganizationCode == patientDetails.OrganisationCode).Select(p => p.Height).FirstOrDefaultAsync();
        }
        #endregion

        /*
         *  Creates a patient (Can be used by admins to create a new patient in database)
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
