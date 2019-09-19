using System;
using System.Collections.Generic;

namespace Lapbase.Models
{
    public class TaskInput
    {

        public Guid Id { get; set; }
        public int PatientId { get; set; }
        public int OrganizationCode { get; set; }
        public DateTimeOffset DateAssigned { get; set; }
        public Boolean Completed { get; set; }

        public decimal Calories { get; set; }
        public decimal Weight { get; set; }

        public string Foods { get; set; }
        public string FoodQuantities { get; set; }
        public string IntakeTimes { get; set; }
        public string Exercises { get; set; }
        public string ExerciseReps { get; set; }


        //public IDictionary<Exercise, Decimal> Exercises { get; set; }
        //public IDictionary<Food, Decimal> Breakfast { get; set; }
        //public IDictionary<Food, Decimal> Lunch { get; set; }
        //public IDictionary<Food, Decimal> Dinner { get; set; }

        // Instead of Food Intake Lists, can we have key value pairs inside the FoodIntakeList
        // public IDictionary<Food, Integer> Breakfast {get; set;}
        //public FoodIntakeList FoodIntakes { get; set; }
        //public ExerciseList Exercises { get; set; }

        // We wont need this variable as we will return only few tasks for the user to look at.
        // public Boolean Overdue { get; set; }

        public TaskInput()
        {

        }

        public TaskInput(int patientId, int organizationCode, DateTimeOffset dateAssigned)
        {
            this.PatientId = patientId;
            this.OrganizationCode = organizationCode;
            this.DateAssigned = dateAssigned;
            this.Completed = false;

            this.Calories = 0;
            this.Weight = 0;

            this.Foods = "";
            this.FoodQuantities = "";
            this.IntakeTimes = "";
            this.Exercises = "";
            this.ExerciseReps = "";


            //this.FoodIntakes = null;
            //this.Exercises = null;

            //this.Breakfast = new Dictionary<Food, Decimal>();
            //this.Lunch = new Dictionary<Food, Decimal>();
            //this.Dinner = new Dictionary<Food, Decimal>();
            //this.Exercises = new Dictionary<Exercise, Decimal>();

        }

        public TaskInput(TaskInputDto taskInputDto)
        {
            this.Id = taskInputDto.Id;
            this.PatientId = taskInputDto.PatientId;
            this.OrganizationCode = taskInputDto.OrganizationCode;
            this.Weight = taskInputDto.Weight;
            this.Calories = taskInputDto.Calories;
            this.Completed = taskInputDto.Completed;
            this.DateAssigned = taskInputDto.DateAssigned;
            this.Foods = "";
            this.FoodQuantities = "";
            this.IntakeTimes = "";
            this.Exercises = "";
            this.ExerciseReps = "";

            taskInputDto.Foods.ForEach(t =>
            {
                this.Foods = this.Foods + "," + t.getFoodString();
                this.FoodQuantities = this.FoodQuantities + "," + t.getFoodQuantityString();
                this.IntakeTimes = this.IntakeTimes + "," + t.getIntakeTimeString();
            });
            this.Foods = this.Foods.Substring(1); // To remove the comma at the front of the sring.
            this.FoodQuantities = this.FoodQuantities.Substring(1);
            this.IntakeTimes = this.IntakeTimes.Substring(1);


            taskInputDto.Exercises.ForEach(e =>
            {
                this.Exercises += this.Exercises + "," + e.getExerciseString();
                this.ExerciseReps += this.ExerciseReps + "," + e.getExerciseReps();
            });
            this.Exercises = this.Exercises.Substring(1);
            this.ExerciseReps = this.ExerciseReps.Substring(1);


        }

    }
   
}
