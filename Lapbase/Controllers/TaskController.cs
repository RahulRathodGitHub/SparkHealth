﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Lapbase.Models;
using Lapbase.Services;

namespace Lapbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : Controller
    {
        private readonly TaskService taskService;

        public TaskController(TaskService taskService)
        {
            this.taskService = taskService;
        }

        // GET: api/Task
        [HttpGet]
        public async Task<ActionResult<List<Models.Task>>> GetTasks()
        {
            return await taskService.GetTasks();
        }

        // GET api/Task/{int}
        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Task>> GetTask(int id)
        {
            if (id == default)
            {
                return BadRequest();
            }

            var task = await taskService.GetTaskById(id);

            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        // POST api/Task
        [HttpPost]
        public async Task<ActionResult> CreateTask([FromBody]Models.Task task)
        {
            var result = await taskService.CreateTask(task);

            return CreatedAtAction(nameof(GetTask), new { result.Id }, result);
        }
    }
}