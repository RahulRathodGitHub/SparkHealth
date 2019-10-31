using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Lapbase.Models;
using Lapbase.Services;
using Microsoft.AspNetCore.Authorization;

namespace Lapbase.Controllers
{
    /*
     * Controller to expose all the endpoints corresponding to a patient.
     */
    [Route("api/[controller]")]
    [Authorize]
    public class PatientController : Controller
    {
        private readonly PatientService patientService;

        public PatientController(PatientService patientService)
        {
            this.patientService = patientService;
        }

        [HttpGet("[Action]")]
        public async Task<PatientDto> GetPatientLapbase()
        {
            return await patientService.GetPatientLapbase(User.Identity.Name);
        }

        // GET api/Patient/
        [HttpGet]
        public async Task<ActionResult<Patient>> GetPatient(int id)
        {
            if (id == default)
            {
                return BadRequest();
            }

            var patient = await patientService.GetPatient(User.Identity.Name);

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

        // GET api/Patient/Height
        [HttpGet("Height")]
        public async Task<ActionResult<decimal>> GetPatientHeight()
        {
            var Height = await patientService.GetPatientHeight(User.Identity.Name);

            if (Height == null)
            {
                return 0;
            }

            return Ok(Height);
        }

        [HttpGet("Imperial")]
        public async Task<ActionResult<bool?>> GetPatientImperial()
        {
            var ImperialFlag = await patientService.GetPatientImperial(User.Identity.Name);

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
