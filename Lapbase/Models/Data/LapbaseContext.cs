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

            modelBuilder.Entity<Advisor>().HasData(
            new { Id = 1 });
        }

        public DbSet<Advisor> Advisor { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<ExerciseList> ExerciseList { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<FoodIntakeList> FoodIntakeList { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<TaskInput> TaskInput { get; set; }
    }
}
