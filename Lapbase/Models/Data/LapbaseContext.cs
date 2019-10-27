using System;
using System.Collections.Generic;
using System.Linq;
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

            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                Id = 1,
                Username = "Test@SparkHealthhotmailcom.onmicrosoft.com",
                PatientCode = 2756,
                OrganisationCode = 1,
                Deleted = false
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            { 
                Id = Guid.NewGuid(),
                Name = "PUSHUPS",
                CalorieCount = 54
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
                },
                new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Roti",
                    CalorieCount = 50,
                    Unit = "slice"
                },
                new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Rice",
                    CalorieCount = 40,
                    Unit = "cup"
                },
                new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Halal Pork",
                    CalorieCount = 600,
                    Unit = "piece"
                },
                new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Habib-Style Shwarma",
                    CalorieCount = 300,
                    Unit = "shwarma"
                },new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Meat Platter",
                    CalorieCount = 300,
                    Unit = "platter"
                },new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "Mooncake",
                    CalorieCount = 350,
                    Unit = "mooncake"
                },new Food
                {
                    Id = Guid.NewGuid(),
                    Name = "HSP",
                    CalorieCount = 400,
                    Unit = "box"
                }
            };
            modelBuilder.Entity<Food>().HasData(foodList);
        }

        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<TaskInput> TaskInput { get; set; }

    }
}
