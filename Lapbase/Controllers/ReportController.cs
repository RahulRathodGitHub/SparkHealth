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


        // GET: api/Report/2756/2
        [HttpGet("{id}/{organizationCode}")] 
        public async Task<Report> GetReport([FromRoute] int id, int organizationCode, [FromQuery] DateTime startDate, DateTime endDate, ReportType reportType)
        {
            return await reportService.GetReportById(id, organizationCode, startDate, endDate, reportType);
        }

        // GET: api/Report/lastDate/2756/2
        [HttpGet("lastDate/{id}/{organizationCode}")]
        public async Task<DateTime?> GetReportLastAvailableDate([FromRoute] int id, int organizationCode, [FromQuery] ReportType reportType)
        {
            return await reportService.GetReportLastAvailableDate(id, organizationCode, reportType);
        }

        // GET: api/Report/healthStats/2756/2
        [HttpGet("healthStats/{id}/{organizationCode}")]
        public async Task<EWL_WL_GraphReport> GetPatientHealthStats([FromRoute] int id, int organizationCode, [FromQuery] DateTime startDate, DateTime endDate, ReportType reportType)
        {
            return await reportService.GetPatientHealthStats(id, organizationCode);
        }


    }
}
