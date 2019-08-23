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
            //if (reportType == ReportType.Weight)
            //{
                return await GetWeightReport(patientId, startDate, endDate);
            //}
            //else if (reportType == ReportType.PatientProgress)
            //{
            //    return await GetPatientProgressReport(2, 418, "2", "mel", null, null, 0, 0, 100, 0, 1000, "9", "BAA1061", "", "BAA1061", "1", "2", 1)
            //}




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

        public async Task<List<PatientProgressReport>> GetPatientProgressReport(string OrganizationCode, decimal SurgeonId, 
                                                                                string HospitalCode,     string RegionId, 
                                                                                string FDate,            string TDate, 
                                                                                byte ImperialFlag,       decimal FAge, 
                                                                                decimal TAge,            decimal FBMI, 
                                                                                decimal TBMI,            string GroupCode, 
                                                                                string SurgeryType,      string BandType, 
                                                                                string Approach,         string Category, 
                                                                                string BandSize,         int reportType)
        {
            List<PatientProgressReport> patientProgressReport = lapbaseNewContext.PatientProgressReport.FromSql("Lapbase.RPT.sp_Rep_PatientProgress @p0, @p1, @p2, " +
                                                                                                                "@p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, " +
                                                                                                                "@p13, @p14, @p15, @p16, @p17", 

                                                                                                                new object[] { OrganizationCode, SurgeonId, HospitalCode,
                                                                                                                               RegionId, FDate, TDate, ImperialFlag, FAge,
                                                                                                                               TAge,FBMI, TBMI, GroupCode, SurgeryType,
                                                                                                                               BandType, Approach, Category, BandSize, reportType }

                                                                                                                ).ToList();
            patientProgressReport.ForEach(p => Console.WriteLine(">>>>> " + p.ToString()));

            return patientProgressReport;

            //  Following is the dummy data being used.
            //  OrganizationCode, SurgeonId, HospitalCode, RegionId, FDate, TDate, ImperialFlag, FAge, TAge, FBMI, TBMI, GroupCode, SurgeryType, BandType, Approach, Category, BandSize, ReportType
            //  @OrganizationCode, @SurgeonId, @HospitalCode, @RegionId, @FDate, @TDate, "@ImperialFlag, @FAge,@TAge,@FBMI,@TBMI,@GroupCode,@SurgeryType,@BandType,@Approach, @Category,@BandSize,@ReportType
            //  2 , 418, "2", "mel",null , null , 0, 0, 100, 0, 1000, "9", "BAA1061", "", "BAA1061", "1", "2", 1

            //  The function below returns an integer.
            //  Console.WriteLine("ahhahahah: "+lapbaseContext.Database.ExecuteSqlCommand("RPT.sp_Rep_PatientProgress @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17", parameters: new object[] { 2, 418, "2", "mel", null, null, 0, 0, 100, 0, 1000, "9", "BAA1061", "", "BAA1061", "1", "2", 1 }));

        }

    }
}
