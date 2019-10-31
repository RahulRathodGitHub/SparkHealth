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
    /*
     *  Currently Supported Report Types
     */
    public enum ReportType
    {
        EWL_WL,
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

        /*
         *  Returns the date which has the last recorded data for a particular Report Type corresponding to the 
         *  currently logged in Patient
         */
        public async Task<DateTime?> GetReportLastAvailableDate(string userName, ReportType reportType)
        {
            var patientDetails = lapbaseNewContext.Patient.Where(p => p.Username == userName).FirstOrDefault();
            byte imperialFlag = Convert.ToByte(lapbaseContext.TblUserApplicationData.Where(u => u.PatientId == patientDetails.PatientCode &&
                u.OrganizationCode == patientDetails.OrganisationCode).Select(P => P.Imperial).FirstOrDefault());
            if (reportType == ReportType.EWL_WL)
            {


                return await lapbaseContext.Query<EWL_WL_GraphReport>().FromSql("RPT.sp_Rep_EWL_WLGraphFullPage @p0, @p1, @p2",
                                                                           new object[] { patientDetails.OrganisationCode, patientDetails.PatientCode, imperialFlag })
                                                                           .Select(p => p.DateSeen)
                                                                           .OrderByDescending(p => p.Value)
                                                                           .FirstOrDefaultAsync();

            }
            else if (reportType == ReportType.BMI)
            {

                return await lapbaseContext.TblPatientConsult.Where(p => p.PatientId == patientDetails.PatientCode && p.OrganizationCode == patientDetails.OrganisationCode)
                                                       .Select(p => p.DateSeen)
                                                       .OrderByDescending(p => p.Value)
                                                       .FirstOrDefaultAsync();

            }

            else if (reportType == ReportType.Calorie)
            {
                return await lapbaseNewContext.TaskInput.Where(p => p.PatientId == patientDetails.PatientCode &&
                    p.OrganizationCode == patientDetails.OrganisationCode && (p.CaloriesGained > 0 || p.CaloriesLost > 0))
                                                    .Select(p => new DateTime(p.DateAssigned.Ticks))
                                                    .FirstOrDefaultAsync();
            }


            return new DateTime();

        }

        /*
         *  Gets a requested report provided a given filter for the data corresponding to the 
         *  logged in patient
         */
        public async Task<Report> GetReport(string userName, DateTime startDate, DateTime endDate, ReportType reportType)
        {
            var patientDetails = lapbaseNewContext.Patient.Where(p => p.Username == userName).FirstOrDefault();
            byte imperialFlag = Convert.ToByte(lapbaseContext.TblUserApplicationData.Where(u => u.PatientId == patientDetails.PatientCode &&
                u.OrganizationCode == patientDetails.OrganisationCode).Select(P => P.Imperial).FirstOrDefault());

            Report result = new Report();
            if (reportType == ReportType.EWL_WL)
            {
                var graphDetails = await GetPatientEWL_WL_GraphReport(patientDetails.PatientCode, patientDetails.OrganisationCode, startDate, endDate, imperialFlag);
                graphDetails.ForEach(res => result.AddEntry(res.EWL, "EWL (" + res.WeightMeasurment + ")", res.Weight, "Weight (" + res.WeightMeasurment + ")", res.strDateSeen)); //ToList<IReport>();
                return result;
            }
            else if (reportType == ReportType.BMI)
            {
                await lapbaseContext.TblPatientConsult.Where(p => p.PatientId == patientDetails.PatientCode && p.OrganizationCode == patientDetails.OrganisationCode &&
                    p.DateSeen >= startDate && p.DateSeen <= endDate)
                                                      .OrderBy(p => p.DateSeen)
                                                      .ForEachAsync(res => result.AddEntry(res.Bmiweight, ReportType.BMI.ToString(), new DateTimeOffset((DateTime)res.DateSeen).ToString("dd MMM yyyy")));
                return result;
            }
            else if (reportType == ReportType.Calorie)
            {
                await lapbaseNewContext.TaskInput.Where(p => p.PatientId == patientDetails.PatientCode && p.OrganizationCode == patientDetails.OrganisationCode &&
                    p.DateAssigned >= startDate && p.DateAssigned.Date <= endDate.Date)
                                                 .OrderBy(p => p.DateAssigned)
                                                 .ForEachAsync(res => result.AddEntry(res.CaloriesGained, "Calories Gained (kJ)",
                                                    res.CaloriesLost, "Calories Lost (kJ)", res.DateAssigned.Date.ToString("dd MMM yyyy")));

                return result;

            }
            else// (reportType == ReportType.WeightLoss) UNUSED BLOCK
            {
                var graphDetails = await GetPatientEWL_WL_GraphReport(patientDetails.PatientCode, patientDetails.OrganisationCode, startDate, endDate, imperialFlag);
                graphDetails.ForEach(res => result.AddEntry(res.Weight, "Weight (" + res.WeightMeasurment + ")", res.strDateSeen)); //ToList<IReport>();
                return result;
                //    return await GetWeightReport(patientId, organizationCode, startDate, endDate);
            }

        }

        public async Task<EWL_WL_GraphReport> GetPatientHealthStats(string userName)
        {
            var patientDetails = lapbaseNewContext.Patient.Where(p => p.Username == userName).FirstOrDefault();
            byte imperialFlag = Convert.ToByte(lapbaseContext.TblUserApplicationData.Where(u => u.PatientId == patientDetails.PatientCode &&
                u.OrganizationCode == patientDetails.OrganisationCode).Select(P => P.Imperial).FirstOrDefault());

            return await lapbaseContext.Query<EWL_WL_GraphReport>().FromSql("RPT.sp_Rep_EWL_WLGraphFullPage @p0, @p1, @p2",
                                                                          new object[] { patientDetails.OrganisationCode, patientDetails.PatientCode, imperialFlag })
                                                                          .OrderByDescending(p => p.DateSeen)
                                                                          .FirstOrDefaultAsync();

        }

        private async Task<List<EWL_WL_GraphReport>> GetPatientEWL_WL_GraphReport(int patientId, int organizationCode, DateTime startDate, DateTime endDate, byte imperialFlag)
        {
            return await lapbaseContext.Query<EWL_WL_GraphReport>().FromSql("RPT.sp_Rep_EWL_WLGraphFullPage @p0, @p1, @p2",
                                                                       new object[] { organizationCode, patientId, imperialFlag })
                                                                       .Where(p => p.DateSeen >= startDate && p.DateSeen <= endDate)
                                                                       .OrderBy(p => p.DateSeen)
                                                                       .ToListAsync();
        }
    }
}
