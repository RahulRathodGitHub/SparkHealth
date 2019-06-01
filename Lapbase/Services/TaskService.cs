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

        public async Task<List<Models.Task>> GetTasks()
        {
            return await lapbaseContext.Task.ToListAsync();
        }

        public async Task<Models.Task> GetTaskById(int id)
        {
            return await lapbaseContext.Task.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<Models.Task> CreateTask(Models.Task task)
        {
            var result = await lapbaseContext.Task.AddAsync(task);

            await lapbaseContext.SaveChangesAsync();

            return result.Entity;
        }
    }
}
