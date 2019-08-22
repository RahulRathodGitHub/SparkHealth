using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lapbase.LapbaseModels;
using Lapbase.Models;
using Lapbase.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Lapbase.Controllers
{
    [Route("api/[controller]")]
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
        [HttpGet("{id}")]
        public async Task<IReport> GetReport([FromRoute] int id, [FromQuery] DateTime startDate, DateTime endDate, ReportType reportType)
        {
            return await reportService.GetReportById(id, startDate, endDate, reportType);
        }

    }
}
