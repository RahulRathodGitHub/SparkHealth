using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using Lapbase.Models;

namespace Lapbase.Services
{
    public class TaskInputService
    {
        private readonly LapbaseNewContext lapbaseNewContext;
        private readonly IConfiguration config;

        public TaskInputService(IConfiguration config, LapbaseNewContext lapbaseNewContext)
        {
            this.lapbaseNewContext = lapbaseNewContext;
            this.config = config;
        }

        public async Task<TaskInputDto> GetTaskInputByDate(DateTimeOffset date, int patientId, int organizationCode)
        {

            TaskInput taskInput = await lapbaseNewContext.TaskInput.Where(t =>
                t.DateAssigned.Date.ToShortDateString().Equals(date.Date.ToShortDateString()) &&
                t.PatientId.Equals(patientId) &&
                t.OrganizationCode.Equals(organizationCode)
            ).FirstOrDefaultAsync();

            if (taskInput == default)
            {
                return new TaskInputDto(date);
            }

            return new TaskInputDto(taskInput);
        }

        // Creates a TaskInput by taking a taskInput instance as an argumnet.
        public async Task<TaskInputDto> UpdateTaskInput(TaskInputDto taskInputDto)
        {
            Guid id;
            var result = lapbaseNewContext.TaskInput.FirstOrDefault(f => f.Id == taskInputDto.Id);

            if (result == null)
            {
                id = Guid.Empty;
                result = lapbaseNewContext.TaskInput.Add(GetTaskInputFromDto(taskInputDto, id)).Entity;
            }
            else
            {
                id = result.Id;
                adaptTaskInput(result, taskInputDto);
            }

            await lapbaseNewContext.SaveChangesAsync();
            return new TaskInputDto(result);
        }

        #region Helper Methods

        private TaskInput GetTaskInputFromDto(TaskInputDto dto, Guid id)
        {
            var result = new TaskInput();
            result.Id = id;

            adaptTaskInput(result, dto);

            return result;
        }

        private void adaptTaskInput(TaskInput result, TaskInputDto dto) {

            // TODO PatientId & OrganizationCode should come from token
            result.PatientId = 1;
            result.OrganizationCode = 1;
            result.DateAssigned = dto.DateAssigned;
            result.Calories = dto.Calories;
            result.Weight = dto.Weight;


            string extractedFoodIds = "";
            string extractedFoodQuantity = "";

            string extractedExerciseIds = "";
            string extractedExerciseQuantity = "";

            string extractedMealTime = "";

            foreach (FoodInfo foodInfo in dto.Meals)
            {
                for (int i = 0; i < foodInfo.Foods.Count; i++)
                {
                    extractedFoodIds += foodInfo.Foods[i].Id.ToString() + ",";
                    extractedFoodQuantity += foodInfo.Foods[i].Quantity + ",";
                    extractedMealTime += (int)foodInfo.MealTime + ",";
                }
            };

            if (!string.IsNullOrEmpty(extractedFoodIds))
            {
                extractedFoodIds = extractedFoodIds.Remove(extractedFoodIds.Length - 1);
                extractedFoodQuantity = extractedFoodQuantity.Remove(extractedFoodQuantity.Length - 1);
                extractedMealTime = extractedMealTime.Remove(extractedMealTime.Length - 1);
            }

            result.Foods = extractedFoodIds;
            result.FoodQuantities = extractedFoodQuantity;
            result.MealTimes = extractedMealTime;

            foreach(ExerciseInfo exerciseInfo in dto.Exercises)
            {
               
                extractedExerciseIds += exerciseInfo.Id.ToString() + ",";
                extractedExerciseQuantity += exerciseInfo.Quantity + ",";  
                
            }

            if (!string.IsNullOrEmpty(extractedExerciseIds))
            {
                extractedExerciseIds = extractedExerciseIds.Remove(extractedExerciseIds.Length - 1);
                extractedExerciseQuantity = extractedExerciseQuantity.Remove(extractedExerciseQuantity.Length - 1);
            }

            result.Exercises = extractedExerciseIds;
            result.ExerciseReps = extractedExerciseQuantity;
        }
        #endregion
    }
}
