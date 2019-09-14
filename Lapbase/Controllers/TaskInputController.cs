using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lapbase.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lapbase.Models;

namespace Lapbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskInputController : ControllerBase
    {

        private readonly TaskInputService taskInputService;

        public TaskInputController(TaskInputService taskInputService)
        {
            this.taskInputService = taskInputService;
        }

        // GET: api/TaskInput
        [HttpGet]
        public async Task<ActionResult<List<TaskInput>>> GetTaskInputs() // should this take parameteres of patientId and organization code.
        {
            int patientId = 1;
            int organizationCode = 1;
            return await taskInputService.GetTaskInputs(patientId, organizationCode);
        }

        // GET api/TaskInput/{int}
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskInput>> GetTaskInputById(Guid id)
        {
            if (id == default)
            {
                return BadRequest();
            }

            var task = await taskInputService.GetTaskInputById(id);

            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        // POST api/TaskInput
        [HttpPost]
        public async Task<ActionResult> UpdateTaskInput([FromBody]TaskInput taskInput)
        {
            var result = await taskInputService.UpdateTaskInput(taskInput);

            return CreatedAtAction(nameof(GetTaskInputById), new { result.Id }, result);
        } // Working
    }
 }

