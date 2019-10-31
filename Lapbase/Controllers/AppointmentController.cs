using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Lapbase.LapbaseModels;
using Lapbase.Models;
using Lapbase.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lapbase.Controllers
{
    /*
         Controller to expose all the endpoints for Appointments
     */
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AppointmentController : Controller
    {
        private readonly AppointmentService appointmentService;

        public AppointmentController(AppointmentService appointmentService)
        {
            this.appointmentService = appointmentService;
        }

        // GET: api/Appointment/
        [HttpGet]
        public async Task<ActionResult<List<Appointment>>> GetAppointments()
        {
            return await appointmentService.GetAppointments(User.Identity.Name);
        }

        // GET: api/Next/Appointment/
        [HttpGet("Next")]
        public async Task<ActionResult<Appointment>> GetNextAppointment()
        {
            return await appointmentService.GetNextAppointment(User.Identity.Name);
        }

    }
}
