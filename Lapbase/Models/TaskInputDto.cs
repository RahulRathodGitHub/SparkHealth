using System;
using System.Collections.Generic;

namespace Lapbase.Models
{
    public class TaskInputDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset DateAssigned { get; set; }

        public decimal Calories { get; set; }
        public decimal Weight { get; set; }

        public List<FoodInfo> Meals { get; set; }
        public List<ExerciseInfo> Exercises { get; set; }

        public TaskInputDto() { }

        public TaskInputDto(DateTimeOffset dateAssigned)
        {
            Id = Guid.Empty;
            DateAssigned = dateAssigned;
            Calories = 0;
            Weight = 0;
            Meals = new List<FoodInfo>() {
                new FoodInfo() {
                    Foods = new List<FoodQuantity>(),
                    MealTime = MealTime.BREAKFAST
                },
                new FoodInfo() {
                    Foods = new List<FoodQuantity>(),
                    MealTime = MealTime.LUNCH
                },
                new FoodInfo() {
                    Foods = new List<FoodQuantity>(),
                    MealTime = MealTime.DINNER
                }
            };
            Exercises = new List<ExerciseInfo>();
        }

        public TaskInputDto(TaskInput taskInput)
        {
            Id = taskInput.Id;
            DateAssigned = taskInput.DateAssigned;
            Calories = taskInput.Calories;
            Weight = taskInput.Weight;
            Meals = GetMeals(taskInput);
            // TODO Create helper method once exercises are done
            Exercises = new List<ExerciseInfo>();
        }

        #region Helper Methods
        private List<FoodInfo> GetMeals(TaskInput taskInput)
        {
            var Foods = new List<FoodInfo>() {
                new FoodInfo() {
                    Foods = new List<FoodQuantity>(),
                    MealTime = MealTime.BREAKFAST
                },
                new FoodInfo() {
                    Foods = new List<FoodQuantity>(),
                    MealTime = MealTime.LUNCH
                },
                new FoodInfo() {
                    Foods = new List<FoodQuantity>(),
                    MealTime = MealTime.DINNER
                }
            };

            var extractedFoodIds = taskInput.Foods.Split(',');
            var extractedFoodQuantity = taskInput.FoodQuantities.Split(',');
            var extractedMealTime = taskInput.MealTimes.Split(',');

            for (int i = 0; i < extractedFoodIds.Length; i++)
            {
                switch ((MealTime)int.Parse(extractedMealTime[i]))
                {
                    case MealTime.BREAKFAST:
                        Foods.Find(f => f.MealTime == MealTime.BREAKFAST).Foods.Add(new FoodQuantity()
                        {
                            Id = Guid.Parse(extractedFoodIds[i]),
                            Quantity = int.Parse(extractedFoodQuantity[i])
                        });
                        break;
                    case MealTime.LUNCH:
                        Foods.Find(f => f.MealTime == MealTime.LUNCH).Foods.Add(new FoodQuantity()
                        {
                            Id = Guid.Parse(extractedFoodIds[i]),
                            Quantity = int.Parse(extractedFoodQuantity[i])
                        });
                        break;
                    case MealTime.DINNER:
                        Foods.Find(f => f.MealTime == MealTime.DINNER).Foods.Add(new FoodQuantity()
                        {
                            Id = Guid.Parse(extractedFoodIds[i]),
                            Quantity = int.Parse(extractedFoodQuantity[i])
                        });
                        break;
                }
            }
            return Foods;
        }
        #endregion
    }
}
