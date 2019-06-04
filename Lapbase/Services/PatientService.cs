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
        private readonly IConfiguration config;

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

        public async Task<List<Food>> GetPatientFood(int id)
        {
            return await lapbaseContext.Food.Where(x => x.PatientId == id).ToListAsync();
        }

        public async Task<FoodIntakeList> GetFoodIntake(int id)
        {
            return await lapbaseContext.FoodIntakeList.SingleOrDefaultAsync(x => x.TaskId.Equals(id));
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

        public async Task<Patient> GetPatientById(int id)
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

        public async Task<FoodIntakeList> CreateFoodIntake(FoodIntakeList foodIntakeList)
        {
            var result = await lapbaseContext.FoodIntakeList.AddAsync(foodIntakeList);

            await lapbaseContext.SaveChangesAsync();

            return result.Entity;
        }


        public async Task<Food> CreatePatientFood(Food food)
        {
            var result = await lapbaseContext.Food.AddAsync(food);

            await lapbaseContext.SaveChangesAsync();

            return result.Entity;
        }
    }
}
