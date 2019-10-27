using System;
using System.Threading.Tasks;
using Lapbase.Services;
using Microsoft.AspNetCore.Mvc;
using Lapbase.Models;
using Microsoft.AspNetCore.Authorization;

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

        // GET api/TaskInput/{date}
        [HttpGet("{date}")]
        public async Task<ActionResult<TaskInputDto>> GetByDate(DateTimeOffset date)
        {
            int patientId = 2756;
            int organizationCode = 2;

            if (date == default)
            {
                return BadRequest();
            }

            var task = await taskInputService.GetTaskInputByDate(date, patientId, organizationCode);

            return Ok(task);
        }

        [HttpGet("foodOfTheMonth")]
        public Guid GetFoodOfTheMonth()
        {
            int patientId = 2756;
            int organizationCode = 2;

            var foodOfTheMonth =  taskInputService.GetFoodOfTheMonth(patientId, organizationCode);

            return foodOfTheMonth;
        }

        // POST api/TaskInput
        [HttpPost]
        public async Task<ActionResult> Update([FromBody]TaskInputDto taskInputDto)
        {
            return Ok(await taskInputService.UpdateTaskInput(taskInputDto));
        }
    }
 }

