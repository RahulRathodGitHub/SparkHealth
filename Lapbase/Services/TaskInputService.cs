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
    public class TaskInputService
    {

        private readonly LapbaseNewContext lapbaseNewContext;
        private readonly IConfiguration config;

        // The maximum days the user can go back and change/fill their data.
        private static readonly int daysAllowedToInput = 3;

        public TaskInputService( IConfiguration config, LapbaseNewContext lapbaseNewContext)
        {
            this.lapbaseNewContext = lapbaseNewContext;
            this.config = config;
        }

        // Returns all the TaskInputs for the users to enter or check.
        public async Task<List<TaskInputDto>> GetTaskInputs(int patientId, int organizationCode)
        {
            Console.WriteLine("Inside GetTaskInputs service");
            // Today's Date
            DateTimeOffset today = DateTimeOffset.UtcNow;

            // Load the inputs of the users from the last 3 days.

            var taskInputs = await lapbaseNewContext.TaskInput.Where(x => x.PatientId == patientId &&
                                                                          x.OrganizationCode == organizationCode &&
                                                                          //  x.DateAssigned >= today.AddDays(- daysAllowedToInput) &&
                                                                          x.DateAssigned <= today

                                                                     ).DefaultIfEmpty().ToListAsync();

            // If "taskInputs" does not contain enough tasks upto today's task, then it means the user has not opened the task today.
            DateTimeOffset lastDateOfInput = today.AddDays(-daysAllowedToInput);

            if ((taskInputs != null) && (!taskInputs.Any()))
            {
                lastDateOfInput = taskInputs.Last().DateAssigned;
            }
            else
            {
                taskInputs = new List<TaskInput>();
            }

            /* If the user is new, then the last date of input would be null, in that case,
             * We will set the last date of input to 3 days in past (which is currently the 
             * max days user can enter data in past),
             * 
             * By doing that the next chunk of code will notice that there are gaps between
             * the last day of input and today, Thus those gaps would be filled by pushing 
             * taskInputs in our "taskInputs" array.
             */


            /* While there are gaps between the last date of input and today, fill the gap up.
             */

         

            while (taskInputs.Count() == 0 || taskInputs.Last().DateAssigned < today)
            {
                TaskInput newTaskInput = new TaskInput(patientId, organizationCode, lastDateOfInput.AddDays(1));
                taskInputs.Add(await CreateTaskInput(newTaskInput));
                lastDateOfInput = taskInputs.Last().DateAssigned;
            }

            List<TaskInputDto> taskInputDtos = new List<TaskInputDto>();


            foreach(TaskInput t in taskInputs)
            {
                taskInputDtos.Add(new TaskInputDto(t));
            }

            return taskInputDtos;

        }

        public async Task<TaskInput> CreateTaskInput(TaskInput taskInput)
        {
            var result = await lapbaseNewContext.TaskInput.AddAsync(taskInput);
            await lapbaseNewContext.SaveChangesAsync();
            return result.Entity;
        }

        // Get Tasks by the task's Id (May be for development purposes)
        public async Task<TaskInputDto> GetTaskInputById(Guid taskId)
        {
            return new TaskInputDto(await lapbaseNewContext.TaskInput.Where(t => t.Id == taskId).FirstOrDefaultAsync());
        }

        // Get Task Inputs by date and patientId.
        public async Task<TaskInputDto> GetTaskInputByDate(DateTimeOffset date, int patientId, int organizationCode)
        {
            
            TaskInput taskInput = await lapbaseNewContext.TaskInput.Where(t => t.DateAssigned.Date.Equals(date) && t.PatientId.Equals(patientId) && t.OrganizationCode.Equals(organizationCode)).FirstOrDefaultAsync();

            if(taskInput == default)
            {
                taskInput = await CreateTaskInput(new TaskInput(patientId, organizationCode, date));
            }

            TaskInputDto taskInputDto =  new TaskInputDto(taskInput);

            return taskInputDto;
        }

        // Creates a TaskInput by taking a taskInput instance as an argumnet.
        public async Task<TaskInputDto> UpdateTaskInput(TaskInput taskInput)
        {
            var result = lapbaseNewContext.TaskInput.Update(taskInput);
            await lapbaseNewContext.SaveChangesAsync();
            return new TaskInputDto(result.Entity); 
        }

        // Creates a TaskInput by taking a taskInput instance as an argumnet.
        public async Task<TaskInputDto> UpdateTaskInput(TaskInputDto taskInputDto)
        {
            TaskInput taskInput = new TaskInput(taskInputDto);

            var result = lapbaseNewContext.TaskInput.Update(taskInput);
            await lapbaseNewContext.SaveChangesAsync();
            return new TaskInputDto(result.Entity);
        }

    }
}
