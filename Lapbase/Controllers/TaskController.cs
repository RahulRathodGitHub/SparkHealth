//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//using Lapbase.Models;
//using Lapbase.Services;

//namespace Lapbase.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TaskController : Controller
//    {
//        private readonly TaskService taskService;

//        public TaskController(TaskService taskService)
//        {
//            this.taskService = taskService;
//        }

//        // GET: api/Task
//        [HttpGet]
//        public async Task<ActionResult<List<Models.TaskDto>>> GetTasks()
//        {
//            return await taskService.GetTasks(1, 1);
//        }

//        // GET api/Task/{int}
//        [HttpGet("{id}")]
//        public async Task<ActionResult<Models.Task>> GetTask(Guid id)
//        {
//            if (id == default)
//            {
//                return BadRequest();
//            }

//            var task = await taskService.GetTaskById(id);

//            if (task == null)
//            {
//                return NotFound();
//            }

//            return Ok(task);
//        }

//        // POST api/Task
//        [HttpPost]
//        public async Task<ActionResult> CreateTask([FromBody]Models.Task task)
//        {
//            var result = await taskService.CreateTask(task);

//            return CreatedAtAction(nameof(GetTask), new { result.Id }, result);
//        }

//        // GET api/Task/FoodIntake
//        [HttpGet("GetFoodIntake/{id}")]
//        public async Task<ActionResult<FoodIntakeList>> GetFoodIntake(int id)
//        {
//            if (id == default)
//            {
//                return BadRequest();
//            }

//            var patientSelectedFood = await taskService.GetFoodIntake(id);

//            if (patientSelectedFood == null)
//            {
//                return NotFound();
//            }

//            return Ok(patientSelectedFood);

//        }

//        // POST api/Task/FoodIntake
//        [HttpPost("FoodIntake")]
//        public async Task<ActionResult> CreateFoodIntake([FromBody]FoodIntakeList foodIntakeList)
//        {
//            if (string.IsNullOrEmpty(foodIntakeList.Id.ToString()))
//            {
//                return BadRequest();
//            }

//            var result = await taskService.CreateFoodIntake(foodIntakeList);

//            return CreatedAtAction(nameof(GetFoodIntake), new { result.Id }, result);

//        }
//    }
//}