using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Lapbase.Models;

namespace Lapbase.Services
{
    public class PatientService
    {
        private readonly LapbaseContext lapbaseContext;

        public PatientService(LapbaseContext lapbaseContext)
        {
            this.lapbaseContext = lapbaseContext;
        }

        public Task<List<Patient>> GetPatients()
        {
            return lapbaseContext.Patient.ToListAsync();
        }

        public async Task<Patient> GetPatientById(Guid id)
        {
            return await lapbaseContext.Patient.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Patient> CreatePatient(Patient patient)
        {
            patient.WhenCreated = DateTimeOffset.UtcNow;
            var result = await lapbaseContext.Patient.AddAsync(patient);

            await lapbaseContext.SaveChangesAsync();

            return result.Entity;
        }
    }
}
