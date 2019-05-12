using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Lapbase.Models;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Lapbase.Services
{
    public class PatientService
    {
        private readonly LapbaseContext lapbaseContext;
        private IConfiguration config;

        public PatientService(
            IConfiguration config,
            LapbaseContext lapbaseContext)
        {
            this.lapbaseContext = lapbaseContext;
            this.config = config;
        }

        public async Task<List<Patient>> GetPatients()
        {
            return await lapbaseContext.Patient.ToListAsync();
        }

        public async Task<Object> GetPatientsLapbase()
        {
            using (SqlConnection conn = new SqlConnection(config.GetConnectionString("Lapbase")))
            {
                conn.Open(); // opens the database connection
                SqlCommand command = new SqlCommand("select * from tblPatients;", conn);
                SqlDataReader reader = command.ExecuteReader();

                List<Object> list = new List<Object>();
                while (await reader.ReadAsync())
                {
                    list.Add(reader["Firstname"]);
                }

                return list;
            }
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
