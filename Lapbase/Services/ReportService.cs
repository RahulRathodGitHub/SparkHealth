using Lapbase.LapbaseModels;
using Lapbase.Models;
using Lapbase.OutputModels;
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
       WeightLoss,
       EWL,
       BMI,
       Calorie
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


        public async Task<DateTime?> GetReportLastAvailableDate(int patientId, int organizationCode, ReportType reportType)
        {
            byte imperialFlag = 0;

            DateTime? result = new DateTime?();

            if (reportType == ReportType.EWL)
            {


                return await lapbaseContext.Query<EWL_WL_GraphReport>().FromSql("RPT.sp_Rep_EWL_WLGraphFullPage @p0, @p1, @p2",
                                                                           new object[] { organizationCode, patientId, imperialFlag })
                                                                           .Select(p => p.DateSeen)
                                                                           .OrderByDescending(p => p.Value)
                                                                           .FirstOrDefaultAsync();

            }
            else if (reportType == ReportType.BMI)
            {

                return await lapbaseContext.TblPatientConsult.Where(p => p.PatientId == patientId && p.OrganizationCode == organizationCode)
                                                       .Select(p => p.DateSeen)
                                                       .OrderByDescending(p => p.Value)
                                                       .FirstOrDefaultAsync();

            }
            

            return new DateTime();

        }


        public async Task<Report> GetReportById(int patientId, int organizationCode, DateTime startDate, DateTime endDate, ReportType reportType)
        {
            byte imperialFlag = 0;
            Report result = new Report();
            if (reportType == ReportType.EWL)
            {
                var graphDetails = await GetPatientEWL_WL_GraphReport(patientId, organizationCode, startDate, endDate, imperialFlag);
                graphDetails.ForEach(res => result.AddEntry(res.EWL, res.strDateSeen)); //ToList<IReport>();
                return result;
            }
            else if (reportType == ReportType.BMI)
            {
                 await lapbaseContext.TblPatientConsult.Where(p => p.PatientId == patientId && p.OrganizationCode == organizationCode && p.DateSeen >= startDate && p.DateSeen <= endDate)
                                                       .OrderBy(p => p.DateSeen)
                                                       .ForEachAsync(res => result.AddEntry(res.Bmiweight, res.DateSeen.ToString()));
                //GetPatientEWL_WL_GraphReport(patientId, organizationCode, startDate, endDate, imperialFlag)
                return result;
            }
            else if (reportType == ReportType.Calorie)
            {
                await lapbaseNewContext.TaskInput.Where(p => p.PatientId == patientId && p.OrganizationCode == organizationCode && p.DateAssigned >= startDate && p.DateAssigned <= endDate)
                                                 .OrderBy(p => p.DateAssigned)
                                                 .ForEachAsync(res => result.AddEntry(res.Calories, res.DateAssigned.ToString()));

                return result;
                                                 
            }
            else// (reportType == ReportType.WeightLoss)
            {
                var graphDetails = await GetPatientEWL_WL_GraphReport(patientId, organizationCode, startDate, endDate, imperialFlag);
                graphDetails.ForEach(res => result.AddEntry(res.Weight, res.strDateSeen)); //ToList<IReport>();
                return result;
                //    return await GetWeightReport(patientId, organizationCode, startDate, endDate);
            }

        }

        public async Task<WeightReport> GetWeightReport(int patientId, int organizationCode, DateTime startDate, DateTime endDate)
        {
            //This is the demo list of the weights
            WeightReport weightReport = new WeightReport();
            //var consults = await lapbaseContext.TblPatientConsult.Where(p => p.PatientId == patientId && (p.DateSeen >= startDate && p.DateSeen <= endDate)).ToListAsync();
            await lapbaseContext.TblPatientConsult.Where(p => (p.PatientId == patientId && p.OrganizationCode == organizationCode) && (p.DateSeen >= startDate && p.DateSeen <= endDate))
                                                  .ForEachAsync(p => {

                                                      weightReport.Weight.Add(p.Weight);
                                                      weightReport.weightRecordedTime.Add(p.DateSeen);

                                                  });

            return weightReport;
        }

        

        public async Task<List<EWL_WL_GraphReport>> GetPatientEWL_WL_GraphReport(int patientId, int organizationCode, DateTime startDate, DateTime endDate, byte imperialFlag)
        {
            //Create a var that stores the output from the logic and then run a foreach loop 

            return await lapbaseContext.Query<EWL_WL_GraphReport>().FromSql("RPT.sp_Rep_EWL_WLGraphFullPage @p0, @p1, @p2",
                                                                       new object[] { organizationCode, patientId, imperialFlag})
                                                                       .Where(p => p.DateSeen >= startDate && p.DateSeen <= endDate)
                                                                       .OrderBy(p => p.DateSeen)
                                                                       .ToListAsync();
        }

        public async Task<List<Decimal>> GetCalorieReport(int patientId, int organizationCode, DateTime startDate, DateTime endDate, byte imperialFlag)
        {
            return await lapbaseNewContext.TaskInput.Where(p => p.PatientId == patientId && p.OrganizationCode == organizationCode)
                                                    .Select(p => p.Calories)
                                                    .ToListAsync();
        }

    }
}
