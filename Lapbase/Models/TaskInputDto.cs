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

        public List<FoodInfo> Foods { get; set; }
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
            this.Foods = new List<FoodInfo>();
            this.Exercises = new List<ExerciseInfo>();

            String[] foodName = taskInput.Foods.Split(",");
            String[] foodQuantities = taskInput.FoodQuantities.Split(",");

            String[] exerciseNames = taskInput.Exercises.Split(",");
            String[] exerciseQuantities = taskInput.ExerciseReps.Split(",");

            String breakfastFoods = "";
            String breakfastFoodQuantities = "";

            String lunchFoods = "";
            String lunchFoodQuantities = "";

            String dinnerFoods = "";
            String dinnerFoodQuantities = "";


            int i = 0;
            foreach (String s in taskInput.IntakeTimes.Split(","))
            {
                if (s.ToLower().Equals("breakfast"))
                {
                    breakfastFoods += "," + foodName[i];
                    breakfastFoodQuantities += "," + foodQuantities[i];
                }
                else if (s.ToLower().Equals("lunch"))
                {
                    lunchFoods += "," + foodName[i];
                    lunchFoodQuantities += "," + foodQuantities[i];
                }
                else if (s.ToLower().Equals("dinner"))
                { 
                    dinnerFoods += "," + foodName[i];
                    dinnerFoodQuantities += "," + foodQuantities[i];
                }
               

                i++;
            }

            if(!breakfastFoods.Equals(""))
            this.Foods.Add(new FoodInfo(breakfastFoods.Substring(1), breakfastFoodQuantities.Substring(1), IntakeTime.BREAKFAST));

            if(!lunchFoods.Equals(""))
            this.Foods.Add(new FoodInfo(lunchFoods.Substring(1), lunchFoodQuantities.Substring(1), IntakeTime.LUNCH));

            if(!dinnerFoods.Equals(""))
            this.Foods.Add(new FoodInfo(dinnerFoods.Substring(1), dinnerFoodQuantities.Substring(1), IntakeTime.DINNER));

            this.Exercises.Add(new ExerciseInfo(taskInput.Exercises, taskInput.ExerciseReps));
        }



    }

}
