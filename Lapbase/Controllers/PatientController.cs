using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Lapbase.Models;
using Lapbase.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lapbase.Controllers
{
    [Route("api/[controller]")]
    public class PatientController : Controller
    {
        private readonly PatientService patientService;

        public PatientController(PatientService patientService)
        {
            this.patientService = patientService;
        }

        // GET: api/Patient
        [HttpGet]
        public async Task<ActionResult<List<Patient>>> GetPatients()
        {
            return await patientService.GetPatients();
        }

        // GET: api/Patient/GetPatientsLapbase
        [HttpGet("[Action]")]
        public async Task<Object> GetPatientsLapbase()
        {
            return await patientService.GetPatientsLapbase();
        }

        // GET api/Patient/{int}
        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatient(int id)
        {
            if (id == default)
            {
                return BadRequest();
            }

            var patient = await patientService.GetPatientById(id);

            if (patient == null)
            {
                return NotFound();
            }

            return Ok(patient);
        }

        [HttpGet("FQ/{id}")]
        public async Task<ActionResult<FoodIntakeList>> GetFoodIntake(int id)
        {
            if(id == default)
            {
                return BadRequest();
            }

            var patientSelectedFood = await patientService.GetFoodIntake(id);

            if (patientSelectedFood == null)
            {
                return NotFound();
            }

            return Ok(patientSelectedFood);

        }

        // GET api/Patient/Food/{int}
        [HttpGet("Food/{id}")]
        public async Task<ActionResult<Food>> GetPatientFood(int id)
        {
            if (id == default)
            {
                return BadRequest();
            }

            var patientFood = await patientService.GetPatientFood(id);

            if (patientFood == null)
            {
                return NotFound();
            }

            return Ok(patientFood);
        }

        [HttpPost("Food")]
        public async Task<ActionResult> CreatePatientFood([FromBody]Food food)
        {
            if(string.IsNullOrEmpty(food.Name))
            {
                return BadRequest();
            }

            var result = await patientService.CreatePatientFood(food);

            return CreatedAtAction(nameof(GetPatientFood), new { result.Id }, result);
        }

        // POST api/Patient
        [HttpPost]
        public async Task<ActionResult> CreatePatient([FromBody]Patient patient)
        {
            if (string.IsNullOrEmpty(patient.Username))
            {
                return BadRequest();
            }

            var result = await patientService.CreatePatient(patient);

            return CreatedAtAction(nameof(GetPatient), new { result.Id }, result);
        }

        [HttpPost("FoodIntake")]
        public async Task<ActionResult> CreateFoodIntake([FromBody]FoodIntakeList foodIntakeList)
        {
            if(string.IsNullOrEmpty(foodIntakeList.Id.ToString()))
            {
                return BadRequest();
            }

            var result = await patientService.CreateFoodIntake(foodIntakeList);

            return CreatedAtAction(nameof(GetFoodIntake), new { result.Id }, result);

        }


    }
}
