using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lapbase.Models
{
    public class LapbaseNewContext : DbContext
    {
        public LapbaseNewContext(DbContextOptions<LapbaseNewContext> options) : base(options)
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

            modelBuilder.Entity<TaskInput>().HasData(new TaskInput
            {
                Id = Guid.NewGuid(),
                DateAssigned = new DateTimeOffset(2019, 07, 05, 0, 0, 0, new TimeSpan()),
                PatientId = 1,
                OrganizationCode = 1,
                Calories = 100,
                Weight = 10,
                Completed= false,
                FoodQuantities = "1 2 1",
                Foods="Onion Burger Apple",
                IntakeTimes="Breakfast, Lunch, Dinner",
                Exercises="pushups",
                ExerciseReps="1",
            });

            var foodList = new List<Food>
            {
                new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Burger",
                    CalorieCount = 295,
                    Unit = "piece"
                },
                new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Onion",
                    CalorieCount = 40,
                    Unit = "piece"
                },
                new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Uncle Keith's Kappuccino",
                    CalorieCount = 90,
                    Unit = "cup"
                },
                new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "White bread",
                    CalorieCount = 96,
                    Unit = "slice"
                },
                new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Apple",
                    CalorieCount = 44,
                    Unit = "apple"
                },
                new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Banana",
                    CalorieCount = 107,
                    Unit = "banana"
                },
                new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Tomato",
                    CalorieCount = 30,
                    Unit = "tomato"
                }
            };
            modelBuilder.Entity<Food>().HasData(foodList);
        }

        public DbSet<Advisor> Advisor { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<TaskInput> TaskInput { get; set; }

    }
}
