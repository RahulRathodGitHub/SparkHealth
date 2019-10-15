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

        public async Task<List<Food>> GetPatientFood()
        {
            return await lapbaseNewContext.Food.ToListAsync();
        }

        public async Task<List<Exercise>> GetPatientExercise()
        {
            return await lapbaseNewContext.Exercise.ToListAsync();
        }

        public async Task<List<string>> GetPatientsLapbase()
        {
            return await lapbaseContext.TblPatients.Select(p => p.Firstname).ToListAsync();
        }

        public async Task<Patient> GetPatientById(int id)
        {
            return await lapbaseNewContext.Patient.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<string[]> GetPatientLapbaseById(int id, int organizationCode)
        {
            string[] patientFullName = new string[2];

            await lapbaseContext.TblPatients.Where(p => p.PatientId == id && p.OrganizationCode == organizationCode).ForEachAsync(p =>
            {
                patientFullName[0] = p.Firstname;
                patientFullName[1] = p.Surname;
                
            });  

            return patientFullName;

        }

        public async Task<Boolean?> GetPatientImperial(int id, int organizationCode)
        {
            return await lapbaseContext.TblUserApplicationData.Where(u => u.PatientId == id && u.OrganizationCode == organizationCode).Select(P => P.Imperial).FirstOrDefaultAsync();
        }

        public async Task<Decimal?> GetPatientHeight(int id, int organizationCode)
        {
            return await lapbaseContext.TblPatientWeightData.Where(p => p.PatientId == id && p.OrganizationCode == organizationCode).Select(p => p.Height).FirstOrDefaultAsync();
           
        }
       


        public async Task<Patient> CreatePatient(Patient patient)
        {
            patient.WhenCreated = DateTimeOffset.UtcNow;
            var result = await lapbaseNewContext.Patient.AddAsync(patient);

            await lapbaseNewContext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<Food> CreatePatientFood(Food food)
        {
            var result = await lapbaseNewContext.Food.AddAsync(food);

            await lapbaseNewContext.SaveChangesAsync();

            return result.Entity;
        }
    }
}
