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
    public enum ReportType
    {
       Weight
    }

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

        
        //public async Task<WeightReport> GetReports()
        //{
        //    //This is the demo list of the weights
        //    var patientId = 1;
        //    WeightReport weightReport = new WeightReport(1, DateTime.UtcNow, patientId);
        //    await lapbaseContext.TblPatientConsult.Where(p => p.PatientId == 1).ForEachAsync(p =>{

        //        weightReport.Weight.Add(p.Weight);
        //        weightReport.weightRecordedTime.Add(p.DateSeen);

        //    });

        //    return weightReport;

        //    /*
        //    List<WeightTime> wtArray =  await lapbaseContext.TblPatientConsult.Select(p => new WeightTime(p.Weight, p.DateSeen)).ToListAsync();
        //    return new WeightReport(1, DateTime.UtcNow, 1, wtArray );
        //    */
            
        //}
         
        public async Task<IReport> GetReportById(int patientId, DateTime startDate, DateTime endDate, ReportType reportType)
        {
            //if (reportType == ReportType.Weight) {
                return await GetWeightReport(patientId, startDate, endDate);
           // }
           // else

           // return null;
            

        }

        public async Task<WeightReport> GetWeightReport(int patientId, DateTime startDate, DateTime endDate)
        {
            //This is the demo list of the weights
            WeightReport weightReport = new WeightReport();
            //var consults = await lapbaseContext.TblPatientConsult.Where(p => p.PatientId == patientId && (p.DateSeen >= startDate && p.DateSeen <= endDate)).ToListAsync();
            await lapbaseContext.TblPatientConsult.Where(p => p.PatientId == patientId && (p.DateSeen >= startDate && p.DateSeen <= endDate))
                                                  .ForEachAsync(p => {

                                                      weightReport.Weight.Add(p.Weight);
                                                      weightReport.weightRecordedTime.Add(p.DateSeen);

                                                  });

            return weightReport;
        }
        
    }
}
