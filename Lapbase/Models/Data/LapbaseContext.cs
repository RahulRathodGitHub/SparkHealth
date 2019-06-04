using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lapbase.Models
{
    public class LapbaseContext : DbContext
    {
        public LapbaseContext(DbContextOptions<LapbaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Advisor>().HasData(new Advisor
            {
                Id = 1
            });
            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                Id = 1,
                Username = "test@test.com",
                AdvisorId = 1,
                Deleted = false
            });
            modelBuilder.Entity<Models.Task>().HasData(new Models.Task
            {
                Id = Guid.NewGuid(),
                StartDate = new DateTimeOffset(2019, 05, 05, 0, 0, 0, new TimeSpan()),
                Repetition = RepetitionType.Weekly,
                RepetitionInterval = 1,
                Type = TaskType.FoodIntakeInput,
                PatientId = 1,
                AdvisorId = 1
            });

            var foodList = new List<Food>
            {
                new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Burger",
                    CalorieCount = 295,
                    Unit = "piece",
                    PatientId = 1,
                },
                new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Onion",
                    CalorieCount = 40,
                    Unit = "piece",
                    PatientId = 1,
                },
                new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Uncle Keith's Kappuccino",
                    CalorieCount = 90,
                    Unit = "cup",
                    PatientId = 1,
                }
            };
            modelBuilder.Entity<Food>().HasData(foodList);
        }

        public DbSet<Advisor> Advisor { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<ExerciseList> ExerciseList { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<FoodIntakeList> FoodIntakeList { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Models.Task> Task { get; set; }
        public DbSet<TaskInput> TaskInput { get; set; }
    }
}
