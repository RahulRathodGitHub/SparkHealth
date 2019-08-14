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
    public class AppointmentService
    {
        private readonly LapbaseContext lapbaseContext;
        private readonly LapbaseNewContext lapbaseNewContext;
        private readonly IConfiguration config;

        public AppointmentService(
            IConfiguration config,
            LapbaseContext lapbaseContext,
            LapbaseNewContext lapbaseNewContext)
        {
            this.lapbaseContext = lapbaseContext;
            this.lapbaseNewContext = lapbaseNewContext;
            this.config = config;
        }

        public async Task<List<TblPatientConsult>> GetAppointments()
        {
            return await lapbaseContext.TblPatientConsult.ToListAsync();
        }

        public async Task<TblPatientConsult> GetAppointmentById(int id)
        {
            return await lapbaseContext.TblPatientConsult.SingleOrDefaultAsync(p => p.ConsultId == id);
        }
    }
}
