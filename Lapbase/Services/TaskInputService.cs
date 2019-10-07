﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using Lapbase.Models;
using System.Collections.Generic;

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

        public Guid GetFoodOfTheMonth(int patientId, int organizationCode) // TODO make it to be used for the food of the month/day/week.. etc
        {
            // A Dictionary to store key value pairs of foods and quantities
            Dictionary<Guid, int> FoodQuantityOfMonthDictionary = new Dictionary<Guid, int>();

            // List of TaskInputDtos
            List<TaskInputDto> listOfTaskInputDtos = new List<TaskInputDto>();

            // Get all the task inputs in the whole month.
            var listOfFoodandQuantityStrings = lapbaseNewContext.TaskInput.Where(t => t.DateAssigned.CompareTo(DateTime.Now.AddDays(-30)) >= 0 &&
                t.PatientId.Equals(patientId) &&
                t.OrganizationCode.Equals(organizationCode));

            // Loop through each of them and make a list of taskInputDtos.
            foreach(var taskInputObject in listOfFoodandQuantityStrings)
            {
                listOfTaskInputDtos.Add(new TaskInputDto(taskInputObject));
            }

            // For each task inout dto, add/Update the dictionary
            foreach(var taskInputDtoObject in listOfTaskInputDtos)
            {
                taskInputDtoObject.Meals.ForEach(meal => meal.Foods.ForEach(food => {

                    FoodQuantityOfMonthDictionary = incrementFoodQuantity(FoodQuantityOfMonthDictionary, food.Id, food.Quantity);

                }));
            }

            // return the key with max value.
            if(FoodQuantityOfMonthDictionary.Count() > 0)
                return FoodQuantityOfMonthDictionary.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            return default;
                                       
        }

        private Dictionary<Guid,int> incrementFoodQuantity(Dictionary<Guid, int> dict, Guid food, int quantity)
        {
            if (!dict.ContainsKey(food))
                dict.Add(food, quantity);
            else
                dict[food] += quantity;

            return dict;

        }


        private void adaptTaskInput(TaskInput result, TaskInputDto dto) {

            // TODO PatientId & OrganizationCode should come from token
            result.PatientId = 1;
            result.OrganizationCode = 1;
            result.DateAssigned = dto.DateAssigned;
            result.CaloriesGained = dto.CaloriesGained;
            result.CaloriesLost = dto.CaloriesLost;
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
