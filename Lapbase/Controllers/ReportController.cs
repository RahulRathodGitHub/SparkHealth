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
    /*
     * Controller to expose all the endpoints regarding the reports.
     */
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReportController : ControllerBase
    {
        private readonly ReportService reportService;

        public ReportController(ReportService reportService)
        {
            this.reportService = reportService;
        }


        // GET: api/Report/
        [HttpGet] 
        public async Task<Report> GetReport([FromQuery] DateTime startDate, DateTime endDate, ReportType reportType)
        {
            return await reportService.GetReport(User.Identity.Name, startDate, endDate, reportType);
        }

        // GET: api/Report/lastDate
        [HttpGet("lastDate")]
        public async Task<DateTime?> GetReportLastAvailableDate([FromQuery] ReportType reportType)
        {
            return await reportService.GetReportLastAvailableDate(User.Identity.Name, reportType);
        }

        // GET: api/Report/healthStats
        [HttpGet("healthStats")]
        public async Task<EWL_WL_GraphReport> GetPatientHealthStats()
        {
            return await reportService.GetPatientHealthStats(User.Identity.Name);
        }


    }
}
