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

        // POST api/Patient
        [HttpPost]
        public async Task<ActionResult> CreatePatient([FromBody]Patient patient)
        {
            if (String.IsNullOrEmpty(patient.Username))
            {
                return BadRequest();
            }

            var result = await patientService.CreatePatient(patient);

            return CreatedAtAction(nameof(GetPatient), new { result.Id }, result);
        }

    }
}
