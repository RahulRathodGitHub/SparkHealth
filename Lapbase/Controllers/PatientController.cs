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
        public async Task<List<string>> GetPatientsLapbase()
        {
            return await patientService.GetPatientsLapbase();
        }

        [HttpGet("[Action]/{id}/{organizationCode}")]
        public async Task<PatientDto> GetPatientLapbaseById(int id ,int organizationCode)
        {
            return await patientService.GetPatientLapbaseById(id, organizationCode);
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

        // GET api/Patient/Food
        [HttpGet("Food")]
        public async Task<ActionResult<Food>> GetFoodList()
        {

            var FoodList = await patientService.GetPatientFood();

            if (FoodList == null)
            {
                return NotFound();
            }

            return Ok(FoodList);
        }

        // GET api/Patient/Exercise
        [HttpGet("Exercise")]
        public async Task<ActionResult<Exercise>> GetExerciseList()
        {

            var ExerciseList = await patientService.GetPatientExercise();

            if (ExerciseList == null)
            {
                return NotFound();
            }

            return Ok(ExerciseList);
        }

        [HttpGet("Height")]
        public async Task<ActionResult<Decimal>> GetPatientHeight()
        {
            var Height = await patientService.GetPatientHeight(2756, 2);

            if(Height == null)
            {
                return 0;
            }

            return Ok(Height);
        }

        [HttpGet("Imperial")]
        public async Task<ActionResult<Boolean?>> GetPatientImperial()
        {
            var ImperialFlag = await patientService.GetPatientImperial(2756, 2);

            if (ImperialFlag == null) return false;

            return Ok(ImperialFlag);


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
    }
}
