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
            return ToTaskDto(await lapbaseContext.Task.Where(x => x.PatientId == patientId && x.AdvisorId == advisorId).ToListAsync());
        }

        public async Task<Models.Task> GetTaskById(int id)
        {
            return await lapbaseContext.Task.SingleOrDefaultAsync(p => p.Id.Equals(id));
        } //This code is to get the actual task by id

        public async Task<List<Models.TaskDto>> GetTasksById(int id)
        {
            return ToTaskDto(await lapbaseContext.Task.SingleOrDefaultAsync(p => p.Id.Equals(id)));
        }//This code is to get the taskDtos of that particular task Id

        private DateTimeOffset IncrementDate(DateTimeOffset date, Lapbase.Models.RepetitionType interval)
        {
            switch (interval)
            {
                case Lapbase.Models.RepetitionType.Monthly:
                    return date.AddMonths(1);
                case Lapbase.Models.RepetitionType.Weekly:
                    return date.AddDays(7);
                case Lapbase.Models.RepetitionType.Daily:
                    return date.AddDays(1);
                case Lapbase.Models.RepetitionType.Yearly:
                    return date.AddYears(1);
                default:
                    return date;
            }
        }

        public List<Models.TaskDto> ToTaskDto(Models.Task task)
        {
            List<Models.TaskDto> taskdtos = new List<TaskDto>();
            var startDate = task.StartDate;

            while (startDate < DateTimeOffset.UtcNow)
            {
                var endDate = IncrementDate(startDate, task.Repetition);
                var enteredTask = lapbaseContext.TaskInput.SingleOrDefault(s => s.TaskId == task.Id && s.DateEntered > startDate && s.DateEntered < endDate);

                if (enteredTask != null)
                {
                    taskdtos.Add(new TaskDto
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
                else if (enteredTask == null && endDate > DateTimeOffset.UtcNow)
                {
                    taskdtos.Add(new TaskDto
                    {
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
                    taskdtos.Add(new TaskDto
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

            return taskdtos;
        }

        public List<Models.TaskDto> ToTaskDto(List<Models.Task> tasks)
        {
            List<Models.TaskDto> taskdtos = new List<TaskDto>();

            foreach(Models.Task task in tasks)
            {
                var startDate = task.StartDate;
                while(startDate < DateTimeOffset.UtcNow)
                {
                    var endDate = IncrementDate(startDate, task.Repetition);
                    var enteredTask = lapbaseContext.TaskInput.SingleOrDefault(s => s.TaskId == task.Id && s.DateEntered > startDate && s.DateEntered < endDate);

                    if (enteredTask != null)
                    {
                        taskdtos.Add(new TaskDto
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
                        taskdtos.Add(new TaskDto{
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
                        taskdtos.Add(new TaskDto
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
            return taskdtos;
        }

        public async Task<Models.Task> CreateTask(Models.Task task)
        {
            var result = await lapbaseContext.Task.AddAsync(task);

            await lapbaseContext.SaveChangesAsync();

            return result.Entity;
        }
    }
}
