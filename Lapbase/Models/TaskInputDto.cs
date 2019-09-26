using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{
    public class TaskInputDto
    {
        public Guid Id { get; set; }
        public int PatientId { get; set; }
        public int OrganizationCode { get; set; }
        public DateTimeOffset DateAssigned { get; set; }
        public Boolean Completed { get; set; }

        public decimal Calories { get; set; }
        public decimal Weight { get; set; }

        public List<FoodInfo> Meals { get; set; }
        public List<ExerciseInfo> Exercises { get; set; }


        public TaskInputDto()
        {

        }

        public TaskInputDto(TaskInput taskInput)
        {
            this.Id = taskInput.Id;
            this.PatientId = taskInput.PatientId;
            this.OrganizationCode = taskInput.OrganizationCode;
            this.DateAssigned = taskInput.DateAssigned;
            this.Completed = taskInput.Completed;
            this.Calories = taskInput.Calories;
            this.Weight = taskInput.Weight;
            this.Meals = new List<FoodInfo>();
            this.Exercises = new List<ExerciseInfo>();

            String[] foodIds = taskInput.Meals.Split(",");
            String[] foodQuantities = taskInput.FoodQuantities.Split(",");

            String[] exerciseNames = taskInput.Exercises.Split(",");
            String[] exerciseQuantities = taskInput.ExerciseReps.Split(",");

            String breakfastMeals = "";
            String breakfastFoodQuantities = "";

            String lunchMeals = "";
            String lunchFoodQuantities = "";

            String dinnerMeals = "";
            String dinnerFoodQuantities = "";


            int i = 0;
            foreach (String s in taskInput.IntakeTimes.Split(","))
            {
                if (s.ToLower().Equals("breakfast"))
                {
                    breakfastMeals += "," + foodIds[i];
                    breakfastFoodQuantities += "," + foodQuantities[i];
                }
                else if (s.ToLower().Equals("lunch"))
                {
                    lunchMeals += "," + foodIds[i];
                    lunchFoodQuantities += "," + foodQuantities[i];
                }
                else if (s.ToLower().Equals("dinner"))
                { 
                    dinnerMeals += "," + foodIds[i];
                    dinnerFoodQuantities += "," + foodQuantities[i];
                }
               

                i++;
            }

            if(!breakfastMeals.Equals(""))
            this.Meals.Add(new FoodInfo(breakfastMeals.Substring(1), breakfastFoodQuantities.Substring(1), IntakeTime.BREAKFAST));

            if(!lunchMeals.Equals(""))
            this.Meals.Add(new FoodInfo(lunchMeals.Substring(1), lunchFoodQuantities.Substring(1), IntakeTime.LUNCH));

            if(!dinnerMeals.Equals(""))
            this.Meals.Add(new FoodInfo(dinnerMeals.Substring(1), dinnerFoodQuantities.Substring(1), IntakeTime.DINNER));

            this.Exercises.Add(new ExerciseInfo(taskInput.Exercises, taskInput.ExerciseReps));
        }



    }

}
