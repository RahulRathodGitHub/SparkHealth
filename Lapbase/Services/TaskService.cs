//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;

//using Lapbase.Models;
//using System.Data.SqlClient;
//using Microsoft.Extensions.Configuration;

//namespace Lapbase.Services
//{
//    public class TaskService
//    {
//        private readonly LapbaseNewContext lapbaseNewContext;
//        private readonly IConfiguration config;

//        public TaskService(
//            IConfiguration config,
//            LapbaseNewContext lapbaseNewContext)
//        {
//            this.lapbaseNewContext = lapbaseNewContext;
//            this.config = config;
//        }

//        public async Task<List<Models.TaskDto>> GetTasks(int patientId,int advisorId)
//        {
//            var taskDtos = ToTaskDto(await lapbaseNewContext.Task.Where(x => x.PatientId == patientId && x.AdvisorId == advisorId).ToListAsync());
//            taskDtos.Sort((x, y) => (x.DueDate >= y.DueDate) ? -1 : 1);
//            return taskDtos;
//        }

//        public async Task<Models.Task> GetTaskById(Guid id)
//        {
//            return await lapbaseNewContext.Task.SingleOrDefaultAsync(p => p.Id.Equals(id));
//        }

//        private DateTimeOffset IncrementDate(DateTimeOffset date, RepetitionType repetitionType, int interval)
//        {
//            switch (repetitionType)
//            {
//                case Lapbase.Models.RepetitionType.Monthly:
//                    return date.AddMonths(1 * interval);
//                case Lapbase.Models.RepetitionType.Weekly:
//                    return date.AddDays(7 * interval);
//                case Lapbase.Models.RepetitionType.Daily:
//                    return date.AddDays(1 * interval);
//                case Lapbase.Models.RepetitionType.Yearly:
//                    return date.AddYears(1 * interval);
//                default:
//                    return date;
//            }
//        }

//        public List<TaskDto> ToTaskDto(List<Models.Task> tasks)
//        {
//            List<TaskDto> taskDtos = new List<TaskDto>();

//            foreach(Models.Task task in tasks)
//            {
//                var startDate = task.StartDate;
//                while(startDate < DateTimeOffset.UtcNow)
//                {
//                    var endDate = IncrementDate(startDate, task.Repetition, task.RepetitionInterval);
//                    var enteredTask = lapbaseNewContext.TaskInput.SingleOrDefault(s => s.TaskId == task.Id && s.DateEntered > startDate && s.DateEntered < endDate);

//                    if (enteredTask != null)
//                    {
//                        taskDtos.Add(new TaskDto
//                        {
//                            DueDate = endDate,
//                            Overdue = false,
//                            Completed = true,
//                            Type = task.Type,
//                            Id = task.Id,
//                            PatientId = task.PatientId,
//                            AdvisorId = task.AdvisorId,
//                        });
//                    }
//                    else if(enteredTask == null && endDate > DateTimeOffset.UtcNow)
//                    {
//                        taskDtos.Add(new TaskDto{
//                            DueDate = endDate,
//                            Overdue = false,
//                            Completed = false,
//                            Type = task.Type,
//                            Id = task.Id,
//                            PatientId = task.PatientId,
//                            AdvisorId = task.AdvisorId,
//                        });
//                    }
//                    else
//                    {
//                        taskDtos.Add(new TaskDto
//                        {
//                            DueDate = endDate,
//                            Overdue = true,
//                            Completed = false,
//                            Type = task.Type,
//                            Id = task.Id,
//                            PatientId = task.PatientId,
//                            AdvisorId = task.AdvisorId,

//                        });
//                    }
//                    startDate = endDate;
//                }
//            }
//            return taskDtos;
//        }

//        public async Task<Models.Task> CreateTask(Models.Task task)
//        {
//            if (task.StartDate < DateTimeOffset.UtcNow) return null;

//            var result = await lapbaseNewContext.Task.AddAsync(task);
//            await lapbaseNewContext.SaveChangesAsync();
//            return result.Entity;
//        }

//        public async Task<FoodIntakeList> GetFoodIntake(int id)
//        {
//            return await lapbaseNewContext.FoodIntakeList.SingleOrDefaultAsync(x => x.TaskId.Equals(id));
//        }

//        public async Task<FoodIntakeList> CreateFoodIntake(FoodIntakeList foodIntakeList)
//        {
//            var result = await lapbaseNewContext.FoodIntakeList.AddAsync(foodIntakeList);

//            await lapbaseNewContext.SaveChangesAsync();

//            return result.Entity;
//        }
//    }
//}
