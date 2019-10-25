using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lapbase.LapbaseModels;
using Lapbase.OutputModels;
using Lapbase.Models;
using Lapbase.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Lapbase.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ReportService reportService;

        public ReportController(ReportService reportService)
        {
            this.reportService = reportService;
        }

        // GET: api/Report
        /*[HttpGet]
        public async Task<ActionResult<WeightReport>> GetReports()
        {
            return await reportService.GetReports();
        }*/

        // GET: api/Report/5
        [HttpGet("{id}/{organizationCode}")] 
        public async Task<Report> GetReport([FromRoute] int id, int organizationCode, [FromQuery] DateTime startDate, DateTime endDate, ReportType reportType)
        {
            return await reportService.GetReportById(id, organizationCode, startDate, endDate, reportType);
        }


        [HttpGet("lastDate/{id}/{organizationCode}")]
        public async Task<DateTime?> GetReportLastAvailableDate([FromRoute] int id, int organizationCode, [FromQuery] ReportType reportType)
        {
            return await reportService.GetReportLastAvailableDate(id, organizationCode, reportType);
        }


    }
}
