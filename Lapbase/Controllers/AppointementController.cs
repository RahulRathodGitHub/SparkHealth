using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lapbase.LapbaseModels;
using Lapbase.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lapbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointementController : Controller
    {
        private readonly AppointmentService appointmentService;

        public AppointementController(AppointmentService appointmentService)
        {
            this.appointmentService = appointmentService;
        }

        // GET: api/Appointement
        [HttpGet]
        public async Task<ActionResult<List<TblPatientConsult>>> GetPatients()
        {
            return await appointmentService.GetAppointments();
        }

        // GET: api/Appointement/5
        [HttpGet("{id}")]
        public async Task<TblPatientConsult> GetAsync(int id)
        {
            return await appointmentService.GetAppointmentById(id);
        }

        // POST: api/Appointement
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
