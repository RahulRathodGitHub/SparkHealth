using Lapbase.LapbaseModels;
using Lapbase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Services
{
    public class ReportService
    {
        private readonly LapbaseContext lapbaseContext;
        private readonly LapbaseNewContext lapbaseNewContext;
        private readonly IConfiguration config;

        public ReportService(
            IConfiguration config,
            LapbaseContext lapbaseContext,
            LapbaseNewContext lapbaseNewContext)
        {
            this.lapbaseContext = lapbaseContext;
            this.lapbaseNewContext = lapbaseNewContext;
            this.config = config;
        }

        
        public async Task<List<decimal>> GetReports()
        {
            //This is the demo list of the weights
            return await lapbaseContext.TblPatientConsult.Select(p => p.Weight).ToListAsync();
        }

        /*
         
        public async Task<List<>> GetReportById(int id)
        {
            return await lapbaseContext.TblPatientConsult.Where(p => p.PatientId == id).ToListAsync();
        }
        */
    }
}
