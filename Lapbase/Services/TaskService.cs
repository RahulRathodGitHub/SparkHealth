using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Lapbase.Models;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Lapbase.Services
{
    public class TaskService
    {
        private readonly LapbaseContext lapbaseContext;
        private readonly IConfiguration config;

        public TaskService(
            IConfiguration config,
            LapbaseContext lapbaseContext)
        {
            this.lapbaseContext = lapbaseContext;
            this.config = config;
        }

        public async Task<List<Models.TaskDto>> GetTasks(int patientId,int advisorId)
        {
            var taskDtos = ToTaskDto(await lapbaseContext.Task.Where(x => x.PatientId == patientId && x.AdvisorId == advisorId).ToListAsync());
            taskDtos.Sort((x, y) => (x.DueDate >= y.DueDate) ? -1 : 1);
            return taskDtos;
        }

        public async Task<Models.Task> GetTaskById(Guid id)
        {
            return await lapbaseContext.Task.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        private DateTimeOffset IncrementDate(DateTimeOffset date, RepetitionType repetitionType, int interval)
        {
            switch (repetitionType)
            {
                case Lapbase.Models.RepetitionType.Monthly:
                    return date.AddMonths(1 * interval);
                case Lapbase.Models.RepetitionType.Weekly:
                    return date.AddDays(7 * interval);
                case Lapbase.Models.RepetitionType.Daily:
                    return date.AddDays(1 * interval);
                case Lapbase.Models.RepetitionType.Yearly:
                    return date.AddYears(1 * interval);
                default:
                    return date;
            }
        }

        public List<TaskDto> ToTaskDto(List<Models.Task> tasks)
        {
            List<TaskDto> taskDtos = new List<TaskDto>();

            foreach(Models.Task task in tasks)
            {
                var startDate = task.StartDate;
                while(startDate < DateTimeOffset.UtcNow)
                {
                    var endDate = IncrementDate(startDate, task.Repetition, task.RepetitionInterval);
                    var enteredTask = lapbaseContext.TaskInput.SingleOrDefault(s => s.TaskId == task.Id && s.DateEntered > startDate && s.DateEntered < endDate);

                    if (enteredTask != null)
                    {
                        taskDtos.Add(new TaskDto
                        {
                            DueDate = endDate,
                            Overdue = false,
                            Completed = true,
                            Type = task.Type,
                            Id = task.Id,
                            PatientId = task.PatientId,
                            AdvisorId = task.AdvisorId,
                        });
                    }
                    else if(enteredTask == null && endDate > DateTimeOffset.UtcNow)
                    {
                        taskDtos.Add(new TaskDto{
                            DueDate = endDate,
                            Overdue = false,
                            Completed = false,
                            Type = task.Type,
                            Id = task.Id,
                            PatientId = task.PatientId,
                            AdvisorId = task.AdvisorId,
                        });
                    }
                    else
                    {
                        taskDtos.Add(new TaskDto
                        {
                            DueDate = endDate,
                            Overdue = true,
                            Completed = false,
                            Type = task.Type,
                            Id = task.Id,
                            PatientId = task.PatientId,
                            AdvisorId = task.AdvisorId,

                        });
                    }
                    startDate = endDate;
                }
            }
            return taskDtos;
        }

        public async Task<Models.Task> CreateTask(Models.Task task)
        {
            var result = await lapbaseContext.Task.AddAsync(task);
            await lapbaseContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<FoodIntakeList> GetFoodIntake(int id)
        {
            return await lapbaseContext.FoodIntakeList.SingleOrDefaultAsync(x => x.TaskId.Equals(id));
        }

        public async Task<FoodIntakeList> CreateFoodIntake(FoodIntakeList foodIntakeList)
        {
            var result = await lapbaseContext.FoodIntakeList.AddAsync(foodIntakeList);

            await lapbaseContext.SaveChangesAsync();

            return result.Entity;
        }
    }
}
