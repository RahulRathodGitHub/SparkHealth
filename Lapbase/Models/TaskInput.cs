using System;

namespace Lapbase.Models
{
    public class TaskInput
    {
        public Guid Id { get; set; }
        public int PatientId { get; set; }
        public int OrganizationCode { get; set; }
        public DateTimeOffset DateAssigned { get; set; }
        public bool Completed { get; set; }

        public decimal Calories { get; set; }
        public decimal Weight { get; set; }

        public string Foods { get; set; }
        public string FoodQuantities { get; set; }
        public string MealTimes { get; set; }
        public string Exercises { get; set; }
        public string ExerciseReps { get; set; }
    }
}
