using System;
using Lapbase.OutputModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lapbase.LapbaseModels
{
    public partial class LapbaseContext : DbContext
    {
        public LapbaseContext()
        {
        }

        public LapbaseContext(DbContextOptions<LapbaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblActionLog> TblActionLog { get; set; }
        public virtual DbSet<TblAppSchema> TblAppSchema { get; set; }
        public virtual DbSet<TblAppSchemaFields> TblAppSchemaFields { get; set; }
        public virtual DbSet<TblAppSchemaListItems> TblAppSchemaListItems { get; set; }
        public virtual DbSet<TblApplicationVersion> TblApplicationVersion { get; set; }
        public virtual DbSet<TblBiochemistry> TblBiochemistry { get; set; }
        public virtual DbSet<TblBiochemistryChoice> TblBiochemistryChoice { get; set; }
        public virtual DbSet<TblCharacters> TblCharacters { get; set; }
        public virtual DbSet<TblCodes> TblCodes { get; set; }
        public virtual DbSet<TblComplications> TblComplications { get; set; }
        public virtual DbSet<TblComplicationsBold> TblComplicationsBold { get; set; }
        public virtual DbSet<TblComplicationsLog> TblComplicationsLog { get; set; }
        public virtual DbSet<TblDiretaryWeightLossDuration> TblDiretaryWeightLossDuration { get; set; }
        public virtual DbSet<TblDoctors> TblDoctors { get; set; }
        public virtual DbSet<TblEmrnotes> TblEmrnotes { get; set; }
        public virtual DbSet<TblErrorLogFile> TblErrorLogFile { get; set; }
        public virtual DbSet<TblFileCategory> TblFileCategory { get; set; }
        public virtual DbSet<TblFollowUpNotes> TblFollowUpNotes { get; set; }
        public virtual DbSet<TblHospitals> TblHospitals { get; set; }
        public virtual DbSet<TblIdealWeights> TblIdealWeights { get; set; }
        public virtual DbSet<TblImportDataLog> TblImportDataLog { get; set; }
        public virtual DbSet<TblLanguages> TblLanguages { get; set; }
        public virtual DbSet<TblLogos> TblLogos { get; set; }
        public virtual DbSet<TblOpEvents> TblOpEvents { get; set; }
        public virtual DbSet<TblOpEventsBold> TblOpEventsBold { get; set; }
        public virtual DbSet<TblOpEventsLog> TblOpEventsLog { get; set; }
        public virtual DbSet<TblOpEventsLogBold> TblOpEventsLogBold { get; set; }
        public virtual DbSet<TblOrganization> TblOrganization { get; set; }
        public virtual DbSet<TblOrganizationBiochemistry> TblOrganizationBiochemistry { get; set; }
        public virtual DbSet<TblPatientAcsform> TblPatientAcsform { get; set; }
        public virtual DbSet<TblPatientBioChemistry> TblPatientBioChemistry { get; set; }
        public virtual DbSet<TblPatientBioChemistryLog> TblPatientBioChemistryLog { get; set; }
        public virtual DbSet<TblPatientBsform> TblPatientBsform { get; set; }
        public virtual DbSet<TblPatientComment> TblPatientComment { get; set; }
        public virtual DbSet<TblPatientCommentLog> TblPatientCommentLog { get; set; }
        public virtual DbSet<TblPatientComorbidityCheck> TblPatientComorbidityCheck { get; set; }
        public virtual DbSet<TblPatientComorbidityCheckLog> TblPatientComorbidityCheckLog { get; set; }
        public virtual DbSet<TblPatientComorbidityNotesBold> TblPatientComorbidityNotesBold { get; set; }
        public virtual DbSet<TblPatientConsult> TblPatientConsult { get; set; }
        public virtual DbSet<TblPatientConsultBold> TblPatientConsultBold { get; set; }
        public virtual DbSet<TblPatientConsultBoldNotes> TblPatientConsultBoldNotes { get; set; }
        public virtual DbSet<TblPatientConsultFollowup> TblPatientConsultFollowup { get; set; }
        public virtual DbSet<TblPatientConsultLog> TblPatientConsultLog { get; set; }
        public virtual DbSet<TblPatientConsultLogBold> TblPatientConsultLogBold { get; set; }
        public virtual DbSet<TblPatientDocuments> TblPatientDocuments { get; set; }
        public virtual DbSet<TblPatientDocumentsContent> TblPatientDocumentsContent { get; set; }
        public virtual DbSet<TblPatientDocumentsEventLog> TblPatientDocumentsEventLog { get; set; }
        public virtual DbSet<TblPatientEmr> TblPatientEmr { get; set; }
        public virtual DbSet<TblPatientEmrlog> TblPatientEmrlog { get; set; }
        public virtual DbSet<TblPatientPathology> TblPatientPathology { get; set; }
        public virtual DbSet<TblPatientPathologyData> TblPatientPathologyData { get; set; }
        public virtual DbSet<TblPatientWeightData> TblPatientWeightData { get; set; }
        public virtual DbSet<TblPatientWeightDataLog> TblPatientWeightDataLog { get; set; }
        public virtual DbSet<TblPatients> TblPatients { get; set; }
        public virtual DbSet<TblPatientsBold> TblPatientsBold { get; set; }
        public virtual DbSet<TblPatientsBoldlog> TblPatientsBoldlog { get; set; }
        public virtual DbSet<TblPatientsLog> TblPatientsLog { get; set; }
        public virtual DbSet<TblPermissionLevel> TblPermissionLevel { get; set; }
        public virtual DbSet<TblPrevOp> TblPrevOp { get; set; }
        public virtual DbSet<TblReferringDoctors> TblReferringDoctors { get; set; }
        public virtual DbSet<TblRegions> TblRegions { get; set; }
        public virtual DbSet<TblReportTemplates> TblReportTemplates { get; set; }
        public virtual DbSet<TblRole> TblRole { get; set; }
        public virtual DbSet<TblSrcsystemCode> TblSrcsystemCode { get; set; }
        public virtual DbSet<TblSystemCodes> TblSystemCodes { get; set; }
        public virtual DbSet<TblSystemCodesBold> TblSystemCodesBold { get; set; }
        public virtual DbSet<TblSystemDetails> TblSystemDetails { get; set; }
        public virtual DbSet<TblSystemNormals> TblSystemNormals { get; set; }
        public virtual DbSet<TblTempWeightLossReport> TblTempWeightLossReport { get; set; }
        public virtual DbSet<TblUserAccessPermission> TblUserAccessPermission { get; set; }
        public virtual DbSet<TblUserActivationCode> TblUserActivationCode { get; set; }
        public virtual DbSet<TblUserApplicationData> TblUserApplicationData { get; set; }
        public virtual DbSet<TblUserRole> TblUserRole { get; set; }
        public virtual DbSet<TblUserTrust> TblUserTrust { get; set; }
        public virtual DbSet<TblUsers> TblUsers { get; set; }
        public virtual DbSet<TblUsersPasswordsHistory> TblUsersPasswordsHistory { get; set; }
        public virtual DbSet<TblUsysUserObjectLogs> TblUsysUserObjectLogs { get; set; }
        public virtual DbSet<TblVersionLog> TblVersionLog { get; set; }

        // Unable to generate entity type for table 'dbo.tblPatientConsult_Staging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblSystemCodes_Staging'. Please see the warning messages.
        // Unable to generate entity type for table 'ETL.tblImportDataException'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblPatientWeightData_Staging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblPatients_Staging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblReferringDoctors_Staging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblTemplates'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblSystemNormals_Staging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblHospitals_Staging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblIdealWeights_Staging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblERRORS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblDocumentType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblDocumentEventCategory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblDoctors_Staging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblOpEvents_Staging'. Please see the warning messages.
        // Unable to generate entity type for table 'BSR.BSROrganization'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblComplications_Staging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblCodes_Staging'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Lapbase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            // Custom queries
            #region Custom Queries
            modelBuilder.Query<EWL_WL_GraphReport>();
            #endregion

            modelBuilder.Entity<TblActionLog>(entity =>
            {
                entity.ToTable("tblActionLog");

                entity.Property(e => e.TblActionLogId).HasColumnName("tblActionLogID");

                entity.Property(e => e.Action)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ActionDetail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Page)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId)
                    .HasColumnName("PatientID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAppSchema>(entity =>
            {
                entity.HasKey(e => e.TblAppschemaCode);

                entity.ToTable("tblAppSchema");

                entity.Property(e => e.TblAppschemaCode).HasColumnName("tblAPPSCHEMA_CODE");

                entity.Property(e => e.AppschemaId)
                    .HasColumnName("APPSCHEMA_ID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchemaType)
                    .IsRequired()
                    .HasColumnName("SCHEMA_TYPE")
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TblAppSchemaFields>(entity =>
            {
                entity.HasKey(e => new { e.TblAppschemaCode, e.FieldId })
                    .HasName("PK_tblAppSchemaFields_1");

                entity.ToTable("tblAppSchemaFields");

                entity.Property(e => e.TblAppschemaCode).HasColumnName("tblAPPSCHEMA_CODE");

                entity.Property(e => e.FieldId)
                    .HasColumnName("Field_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldNameArabic)
                    .HasColumnName("Field_Name_ARABIC")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FieldNameAustralian)
                    .HasColumnName("Field_Name_Australian")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FieldNameEnglish)
                    .HasColumnName("Field_Name_English")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FieldNameFrench)
                    .HasColumnName("Field_Name_French")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FieldNameGerman)
                    .HasColumnName("Field_Name_German")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FieldNamePortugese)
                    .HasColumnName("Field_Name_Portugese")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FieldNameSpanish)
                    .HasColumnName("Field_Name_Spanish")
                    .HasMaxLength(1024)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAppSchemaListItems>(entity =>
            {
                entity.ToTable("tblAppSchemaListItems");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FieldId)
                    .IsRequired()
                    .HasColumnName("Field_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListTextArabic)
                    .HasColumnName("List_Text_Arabic")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListTextEnglish)
                    .HasColumnName("List_Text_English")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListTextPortugese)
                    .HasColumnName("List_Text_Portugese")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListTextSpanish)
                    .HasColumnName("List_Text_Spanish")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListValue).HasColumnName("List_Value");

                entity.Property(e => e.TblAppschemaCode).HasColumnName("tblAPPSCHEMA_CODE");
            });

            modelBuilder.Entity<TblApplicationVersion>(entity =>
            {
                entity.HasKey(e => e.VersionNo);

                entity.ToTable("tblApplicationVersion");

                entity.HasIndex(e => e.ApplicationUrl)
                    .HasName("IX_tblApplicationVersion")
                    .IsUnique();

                entity.Property(e => e.VersionNo).HasColumnType("decimal(3, 1)");

                entity.Property(e => e.ApplicationUrl)
                    .HasColumnName("ApplicationURL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblBiochemistry>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_tblBioChemistry");

                entity.ToTable("tblBiochemistry");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('I')");
            });

            modelBuilder.Entity<TblBiochemistryChoice>(entity =>
            {
                entity.HasKey(e => e.BiochemistryChoiceId)
                    .HasName("PK_tblBioChemistryChoice");

                entity.ToTable("tblBiochemistryChoice");

                entity.Property(e => e.BiochemistryChoiceId).HasColumnName("BiochemistryChoiceID");

                entity.Property(e => e.BiochemistryCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChoiceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChoiceDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCharacters>(entity =>
            {
                entity.HasKey(e => e.TblCharacterSno);

                entity.ToTable("tblCharacters");

                entity.Property(e => e.TblCharacterSno).HasColumnName("tblCharacter_SNo");

                entity.Property(e => e.CharacterCaption)
                    .HasColumnName("Character_Caption")
                    .HasMaxLength(1);

                entity.Property(e => e.CharacterOrderNo).HasColumnName("Character_OrderNo");

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCodes>(entity =>
            {
                entity.HasKey(e => new { e.UserPracticeCode, e.Code, e.CategoryCode });

                entity.ToTable("tblCodes");

                entity.Property(e => e.Code)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Field2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblComplications>(entity =>
            {
                entity.HasKey(e => new { e.ComplicationNum, e.OrganizationCode });

                entity.ToTable("tblComplications");

                entity.Property(e => e.ComplicationNum).ValueGeneratedOnAdd();

                entity.Property(e => e.AdmitDate).HasColumnType("datetime");

                entity.Property(e => e.AdverseSurgery)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Complication)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComplicationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComplicationDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.FacilityCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityOther)
                    .HasColumnName("Facility_Other")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PerformDate).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblComplicationsBold>(entity =>
            {
                entity.HasKey(e => new { e.TblComplicationsId, e.OrganizationCode });

                entity.ToTable("tblComplications_Bold");

                entity.Property(e => e.TblComplicationsId)
                    .HasColumnName("tblComplications_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdverseSurgery)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BoldAdverseEventId)
                    .HasColumnName("BoldAdverseEventID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BoldFlag).HasColumnName("Bold_Flag");

                entity.Property(e => e.ComplicationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComplicationDate).HasColumnType("datetime");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.FacilityCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblComplicationsLog>(entity =>
            {
                entity.HasKey(e => e.ComplicationLogId);

                entity.ToTable("tblComplicationsLog");

                entity.Property(e => e.ComplicationLogId).HasColumnName("ComplicationLogID");

                entity.Property(e => e.AdmitDate).HasColumnType("datetime");

                entity.Property(e => e.AdverseSurgery)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Complication)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComplicationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComplicationDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.FacilityCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityOther)
                    .HasColumnName("Facility_Other")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LogDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PerformDate).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDiretaryWeightLossDuration>(entity =>
            {
                entity.HasKey(e => e.DietaryWeightLossDurationId);

                entity.ToTable("tblDiretaryWeightLossDuration");

                entity.Property(e => e.DietaryWeightLossDurationId).HasColumnName("DietaryWeightLossDurationID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblDoctors>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.UserPracticeCode, e.DoctorId });

                entity.ToTable("tblDoctors");

                entity.HasIndex(e => new { e.OrganizationCode, e.DoctorId })
                    .HasName("IX_tblDoctors_WeightLoss1");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("DoctorID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Degrees)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorBoldCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Initial)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IsSurgeon).HasDefaultValueSql("((0))");

                entity.Property(e => e.LapBandCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OtherType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefApproach).HasMaxLength(50);

                entity.Property(e => e.PrefCategory)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrefSurgeryType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Speciality)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseOwnLetterHead).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblEmrnotes>(entity =>
            {
                entity.HasKey(e => e.NotesId);

                entity.ToTable("tblEMRNotes");

                entity.Property(e => e.NotesId).HasColumnName("NotesID");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblErrorLogFile>(entity =>
            {
                entity.ToTable("tblErrorLogFile");

                entity.Property(e => e.TblErrorLogFileId).HasColumnName("tblErrorLogFileID");

                entity.Property(e => e.ClientIp)
                    .HasColumnName("ClientIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorMessage).HasColumnType("text");

                entity.Property(e => e.LogDateTime)
                    .HasColumnName("logDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFileCategory>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("tblFileCategory");

                entity.HasIndex(e => new { e.FacilityId, e.TypeName })
                    .HasName("IX_tblFileCategory")
                    .IsUnique();

                entity.Property(e => e.TypeId).HasColumnName("Type_ID");

                entity.Property(e => e.FacilityId).HasColumnName("Facility_ID");

                entity.Property(e => e.OrderNo).HasColumnName("Order_No");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnName("Type_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFollowUpNotes>(entity =>
            {
                entity.HasKey(e => new { e.UserPracticeCode, e.OrganizationCode })
                    .HasName("PK_tblVisitNotes");

                entity.ToTable("tblFollowUpNotes");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblHospitals>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.HospitalId })
                    .HasName("PK_tblHospitals_1");

                entity.ToTable("tblHospitals");

                entity.HasIndex(e => new { e.OrganizationCode, e.HospitalId, e.RegionId })
                    .HasName("IX_tblHospitals_WeightLoss1");

                entity.Property(e => e.HospitalId)
                    .HasColumnName("Hospital Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalBoldCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalName)
                    .IsRequired()
                    .HasColumnName("Hospital Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RegionId)
                    .HasColumnName("Region Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblIdealWeights>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.UserPracticeCode, e.Height });

                entity.ToTable("tblIdealWeights");

                entity.Property(e => e.IdealWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdealWeightFemale).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblImportDataLog>(entity =>
            {
                entity.ToTable("tblImportDataLog", "ETL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.InputFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLanguages>(entity =>
            {
                entity.HasKey(e => e.LanguageCode);

                entity.ToTable("tblLanguages");

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CultureInfo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Direction)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasColumnName("Language_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLogos>(entity =>
            {
                entity.HasKey(e => e.LogoId);

                entity.ToTable("tblLogos");

                entity.Property(e => e.LogoName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogoPath)
                    .HasMaxLength(2048)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOpEvents>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.AdmitId });

                entity.ToTable("tblOpEvents");

                entity.HasIndex(e => new { e.OrganizationCode, e.AdmitId, e.PatientId, e.DateDeleted, e.OperationDate })
                    .HasName("IX_tblOpEvents_WeightLoss1");

                entity.HasIndex(e => new { e.OrganizationCode, e.AdmitId, e.PatientId, e.OperationDate, e.HospitalCode, e.DateDeleted })
                    .HasName("IX_tblOpEvents_WeightLoss2");

                entity.HasIndex(e => new { e.OrganizationCode, e.AdmitId, e.PatientId, e.OperationDate, e.SurgeonId, e.DateDeleted })
                    .HasName("IX_tblOpEvents_WeightLoss3");

                entity.HasIndex(e => new { e.OrganizationCode, e.AdmitId, e.PatientId, e.OperationDate, e.HospitalCode, e.SurgeonId, e.DateDeleted })
                    .HasName("IX_tblOpEvents_WeightLoss4");

                entity.Property(e => e.AdmitId).ValueGeneratedOnAdd();

                entity.Property(e => e.AdmitDate).HasColumnType("datetime");

                entity.Property(e => e.Approach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BalloonVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BandSize)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BloodLoss).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bougie)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BpdchannelLength)
                    .HasColumnName("BPDChannelLength")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BpdduodenalSwitch).HasColumnName("BPDDuodenalSwitch");

                entity.Property(e => e.BpdilealLength)
                    .HasColumnName("BPDIlealLength")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BpdstomachSize)
                    .HasColumnName("BPDStomachSize")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Category)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Closure)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ComcomitantSurgery1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComcomitantSurgery2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComcomitantSurgery3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComcomitantSurgeryNotes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Findings)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FirstAssistant)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralNotes)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Group)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InRoomTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Indication)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LapbandType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpWeight)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.OtherProcedure).IsUnicode(false);

                entity.Property(e => e.OutRoomTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Pathway)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreopAlbumin)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PreopAlbuminDate).HasColumnType("datetime");

                entity.Property(e => e.PreopHematocrit)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PreopHematocritDate).HasColumnType("datetime");

                entity.Property(e => e.PrevAbdoSurgery1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrevAbdoSurgery2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrevAbdoSurgery3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrevAbdoSurgeryNotes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrevPelvicSurgery1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrevPelvicSurgery2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrevPelvicSurgery3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrevPelvicSurgeryNotes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Procedure)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReservoirSite)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RouxColic)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RouxEnterostomy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RouxGastric)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RouxLimbLength)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StartHip).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartNeck).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartWaist).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SurgeryEndTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeryStartTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeryType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TubeSize)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VbgstomaSize)
                    .HasColumnName("VBGStomaSize")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VbgstomaWrap)
                    .HasColumnName("VBGStomaWrap")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOpEventsBold>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.AdmitId });

                entity.ToTable("tblOpEvents_Bold");

                entity.Property(e => e.AdmitDate).HasColumnType("datetime");

                entity.Property(e => e.AnesthesiaDuration).HasDefaultValueSql("((0))");

                entity.Property(e => e.Approach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Asacode)
                    .HasColumnName("ASACode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BandType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BloodLoss).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BloodTransfusion)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BoldFlag)
                    .HasColumnName("Bold_Flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BoldSent).HasColumnName("Bold_Sent");

                entity.Property(e => e.Concurrent).IsUnicode(false);

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.DischargeTo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dvtantigloculan).HasColumnName("DVTAntigloculan");

                entity.Property(e => e.Dvtcode)
                    .HasColumnName("DVTCode")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dvtcompress).HasColumnName("DVTCompress");

                entity.Property(e => e.DvtfootPump).HasColumnName("DVTFootPump");

                entity.Property(e => e.Dvtted).HasColumnName("DVTTED");

                entity.Property(e => e.HospitalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalId)
                    .HasColumnName("HospitalID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntraEvents).IsUnicode(false);

                entity.Property(e => e.LastConsultIdbeforeOperation).HasColumnName("LastConsultIDBeforeOperation");

                entity.Property(e => e.LastSeen).HasColumnType("datetime");

                entity.Property(e => e.LastWeight).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.PreDischargeEvents).IsUnicode(false);

                entity.Property(e => e.PreDischargeSurgery)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryProcedure)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeryType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SurgicalAssistance)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeAfterSurgeryMeasurement)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOpEventsLog>(entity =>
            {
                entity.HasKey(e => e.OpEventsLogId)
                    .HasName("PK_tblOpEventsLog_1")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblOpEventsLog");

                entity.Property(e => e.OpEventsLogId).HasColumnName("OpEventsLogID");

                entity.Property(e => e.AdmitDate).HasColumnType("datetime");

                entity.Property(e => e.Approach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BalloonVolume).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BandSize)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BloodLoss).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bougie)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BpdchannelLength)
                    .HasColumnName("BPDChannelLength")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BpdduodenalSwitch).HasColumnName("BPDDuodenalSwitch");

                entity.Property(e => e.BpdilealLength)
                    .HasColumnName("BPDIlealLength")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BpdstomachSize)
                    .HasColumnName("BPDStomachSize")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Category)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Closure)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ComcomitantSurgery1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComcomitantSurgery2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComcomitantSurgery3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComcomitantSurgeryNotes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Findings)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FirstAssistant)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralNotes)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Group)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InRoomTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Indication)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LapbandType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LogDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OpWeight)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.OtherProcedure).IsUnicode(false);

                entity.Property(e => e.OutRoomTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Pathway)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreopAlbumin)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PreopAlbuminDate).HasColumnType("datetime");

                entity.Property(e => e.PreopHematocrit)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PreopHematocritDate).HasColumnType("datetime");

                entity.Property(e => e.PrevAbdoSurgery1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrevAbdoSurgery2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrevAbdoSurgery3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrevAbdoSurgeryNotes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrevPelvicSurgery1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrevPelvicSurgery2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrevPelvicSurgery3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrevPelvicSurgeryNotes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Procedure)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReservoirSite)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RouxColic)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RouxEnterostomy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RouxGastric)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RouxLimbLength)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StartHip).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartNeck).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartWaist).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SurgeryEndTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeryStartTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeryType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TubeSize)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VbgstomaSize)
                    .HasColumnName("VBGStomaSize")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VbgstomaWrap)
                    .HasColumnName("VBGStomaWrap")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOpEventsLogBold>(entity =>
            {
                entity.HasKey(e => e.OpEventsBoldLogId);

                entity.ToTable("tblOpEventsLog_Bold");

                entity.Property(e => e.OpEventsBoldLogId).HasColumnName("OpEventsBoldLogID");

                entity.Property(e => e.AdmitDate).HasColumnType("datetime");

                entity.Property(e => e.AnesthesiaDuration).HasDefaultValueSql("((0))");

                entity.Property(e => e.Approach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Asacode)
                    .HasColumnName("ASACode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BandType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BloodLoss).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BloodTransfusion)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BoldFlag)
                    .HasColumnName("Bold_Flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BoldSent).HasColumnName("Bold_Sent");

                entity.Property(e => e.Concurrent).IsUnicode(false);

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.DischargeTo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dvtantigloculan).HasColumnName("DVTAntigloculan");

                entity.Property(e => e.Dvtcode)
                    .HasColumnName("DVTCode")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dvtcompress).HasColumnName("DVTCompress");

                entity.Property(e => e.DvtfootPump).HasColumnName("DVTFootPump");

                entity.Property(e => e.Dvtted).HasColumnName("DVTTED");

                entity.Property(e => e.HospitalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalId)
                    .HasColumnName("HospitalID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntraEvents).IsUnicode(false);

                entity.Property(e => e.LastConsultIdbeforeOperation).HasColumnName("LastConsultIDBeforeOperation");

                entity.Property(e => e.LastSeen).HasColumnType("datetime");

                entity.Property(e => e.LastWeight).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.LogDateTime).HasColumnType("datetime");

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.PreDischargeEvents).IsUnicode(false);

                entity.Property(e => e.PreDischargeSurgery)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryProcedure)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeryType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SurgicalAssistance)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeAfterSurgeryMeasurement)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOrganization>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK_tblOrganization_1");

                entity.ToTable("tblOrganization");

                entity.HasIndex(e => e.OrgDomainName)
                    .HasName("IX_OrganizationCode");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.AdminEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationMode).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bsrexport).HasColumnName("BSRExport");

                entity.Property(e => e.ConnectionString)
                    .HasColumnName("connectionString")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CultureInfo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultSort)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.Emr)
                    .HasColumnName("EMR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ifsocode)
                    .HasColumnName("IFSOCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActivated).HasDefaultValueSql("((1))");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrgDomainName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PracticeBoldCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitData)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo)
                    .HasColumnType("decimal(3, 1)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblOrganizationBiochemistry>(entity =>
            {
                entity.HasKey(e => e.OrgBiochemId);

                entity.ToTable("tblOrganizationBiochemistry");

                entity.Property(e => e.BiochemistryCode)
                    .HasMaxLength(1024)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPatientAcsform>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.PatientId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientACSForm");

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.Form1).HasColumnType("datetime");

                entity.Property(e => e.Form2).HasColumnType("datetime");

                entity.Property(e => e.Form3).HasColumnType("datetime");

                entity.Property(e => e.Form4).HasColumnType("datetime");

                entity.Property(e => e.Form5).HasColumnType("datetime");

                entity.Property(e => e.Form6).HasColumnType("datetime");

                entity.Property(e => e.Form7).HasColumnType("datetime");

                entity.Property(e => e.Form8).HasColumnType("datetime");

                entity.Property(e => e.Form9).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPatientBioChemistry>(entity =>
            {
                entity.HasKey(e => new { e.BiochemistryNum, e.OrganizationCode });

                entity.ToTable("tblPatientBioChemistry");

                entity.Property(e => e.BiochemistryNum).ValueGeneratedOnAdd();

                entity.Property(e => e.BiochemistryDate).HasColumnType("datetime");

                entity.Property(e => e.BiochemistryValue)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPatientBioChemistryLog>(entity =>
            {
                entity.HasKey(e => e.BiochemistryNumLogId);

                entity.ToTable("tblPatientBioChemistryLog");

                entity.Property(e => e.BiochemistryNumLogId).HasColumnName("BiochemistryNumLogID");

                entity.Property(e => e.BiochemistryDate).HasColumnType("datetime");

                entity.Property(e => e.BiochemistryValue)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LogDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPatientBsform>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.PatientId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientBSForm");

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.Reg1Y1).HasColumnType("datetime");

                entity.Property(e => e.Reg2Y1).HasColumnType("datetime");

                entity.Property(e => e.Reg2Y2).HasColumnType("datetime");

                entity.Property(e => e.Reg2Y3).HasColumnType("datetime");

                entity.Property(e => e.Reg2Y4).HasColumnType("datetime");

                entity.Property(e => e.Reg2Y5).HasColumnType("datetime");

                entity.Property(e => e.Reg2Y6).HasColumnType("datetime");

                entity.Property(e => e.Reg2Y7).HasColumnType("datetime");

                entity.Property(e => e.Reg2Y8).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPatientComment>(entity =>
            {
                entity.HasKey(e => new { e.CommentId, e.OrganizationCode, e.PatientId })
                    .HasName("PK_tblPatientComment_1")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientComment");

                entity.Property(e => e.CommentId)
                    .HasColumnName("CommentID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.CreatedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateSeen).HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(2048)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPatientCommentLog>(entity =>
            {
                entity.HasKey(e => e.CommentLogId)
                    .HasName("PK_tblPatientCommentLog_1")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientCommentLog");

                entity.Property(e => e.CommentLogId).HasColumnName("CommentLogID");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CreatedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateSeen).HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LogDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");
            });

            modelBuilder.Entity<TblPatientComorbidityCheck>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.PatientId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientComorbidityCheck");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.AusCvsAnti).HasColumnName("AUS_CvsAnti");

                entity.Property(e => e.AusCvsBlood).HasColumnName("AUS_CvsBlood");

                entity.Property(e => e.AusCvsCol).HasColumnName("AUS_CvsCol");

                entity.Property(e => e.AusCvsDvt).HasColumnName("AUS_CvsDVT");

                entity.Property(e => e.AusCvsIsc).HasColumnName("AUS_CvsIsc");

                entity.Property(e => e.AusCvsOther).HasColumnName("AUS_CvsOther");

                entity.Property(e => e.AusCvsVen).HasColumnName("AUS_CvsVen");

                entity.Property(e => e.AusEndDiab).HasColumnName("AUS_EndDiab");

                entity.Property(e => e.AusEndOther).HasColumnName("AUS_EndOther");

                entity.Property(e => e.AusEndThy).HasColumnName("AUS_EndThy");

                entity.Property(e => e.AusGasGall).HasColumnName("AUS_GasGall");

                entity.Property(e => e.AusGasHep).HasColumnName("AUS_GasHep");

                entity.Property(e => e.AusGasOther).HasColumnName("AUS_GasOther");

                entity.Property(e => e.AusGasRef).HasColumnName("AUS_GasRef");

                entity.Property(e => e.AusGasUlc).HasColumnName("AUS_GasUlc");

                entity.Property(e => e.AusGenInf).HasColumnName("AUS_GenInf");

                entity.Property(e => e.AusGenRen).HasColumnName("AUS_GenRen");

                entity.Property(e => e.AusGenUri).HasColumnName("AUS_GenUri");

                entity.Property(e => e.AusMuscBack).HasColumnName("AUS_MuscBack");

                entity.Property(e => e.AusMuscFeet).HasColumnName("AUS_MuscFeet");

                entity.Property(e => e.AusMuscFibr).HasColumnName("AUS_MuscFibr");

                entity.Property(e => e.AusMuscHip).HasColumnName("AUS_MuscHip");

                entity.Property(e => e.AusMuscKnee).HasColumnName("AUS_MuscKnee");

                entity.Property(e => e.AusMuscOther).HasColumnName("AUS_MuscOther");

                entity.Property(e => e.AusOtherAnemia).HasColumnName("AUS_OtherAnemia");

                entity.Property(e => e.AusOtherCancer).HasColumnName("AUS_OtherCancer");

                entity.Property(e => e.AusOtherOther).HasColumnName("AUS_OtherOther");

                entity.Property(e => e.AusOtherPso).HasColumnName("AUS_OtherPso");

                entity.Property(e => e.AusOtherSkin).HasColumnName("AUS_OtherSkin");

                entity.Property(e => e.AusPsyAnx).HasColumnName("AUS_PsyAnx");

                entity.Property(e => e.AusPsyDep).HasColumnName("AUS_PsyDep");

                entity.Property(e => e.AusPsyEat).HasColumnName("AUS_PsyEat");

                entity.Property(e => e.AusPsyHead).HasColumnName("AUS_PsyHead");

                entity.Property(e => e.AusPsyOther).HasColumnName("AUS_PsyOther");

                entity.Property(e => e.AusPsyPhob).HasColumnName("AUS_PsyPhob");

                entity.Property(e => e.AusPsyStroke).HasColumnName("AUS_PsyStroke");

                entity.Property(e => e.AusPulApnea).HasColumnName("AUS_PulApnea");

                entity.Property(e => e.AusPulAsthma).HasColumnName("AUS_PulAsthma");

                entity.Property(e => e.AusPulEmb).HasColumnName("AUS_PulEmb");

                entity.Property(e => e.AusPulOther).HasColumnName("AUS_PulOther");
            });

            modelBuilder.Entity<TblPatientComorbidityCheckLog>(entity =>
            {
                entity.HasKey(e => e.PatientComorbidityCheckLogId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientComorbidityCheckLog");

                entity.Property(e => e.PatientComorbidityCheckLogId).HasColumnName("PatientComorbidityCheckLogID");

                entity.Property(e => e.AusCvsAnti).HasColumnName("AUS_CvsAnti");

                entity.Property(e => e.AusCvsBlood).HasColumnName("AUS_CvsBlood");

                entity.Property(e => e.AusCvsCol).HasColumnName("AUS_CvsCol");

                entity.Property(e => e.AusCvsDvt).HasColumnName("AUS_CvsDVT");

                entity.Property(e => e.AusCvsIsc).HasColumnName("AUS_CvsIsc");

                entity.Property(e => e.AusCvsOther).HasColumnName("AUS_CvsOther");

                entity.Property(e => e.AusCvsVen).HasColumnName("AUS_CvsVen");

                entity.Property(e => e.AusEndDiab).HasColumnName("AUS_EndDiab");

                entity.Property(e => e.AusEndOther).HasColumnName("AUS_EndOther");

                entity.Property(e => e.AusEndThy).HasColumnName("AUS_EndThy");

                entity.Property(e => e.AusGasGall).HasColumnName("AUS_GasGall");

                entity.Property(e => e.AusGasHep).HasColumnName("AUS_GasHep");

                entity.Property(e => e.AusGasOther).HasColumnName("AUS_GasOther");

                entity.Property(e => e.AusGasRef).HasColumnName("AUS_GasRef");

                entity.Property(e => e.AusGasUlc).HasColumnName("AUS_GasUlc");

                entity.Property(e => e.AusGenInf).HasColumnName("AUS_GenInf");

                entity.Property(e => e.AusGenRen).HasColumnName("AUS_GenRen");

                entity.Property(e => e.AusGenUri).HasColumnName("AUS_GenUri");

                entity.Property(e => e.AusMuscBack).HasColumnName("AUS_MuscBack");

                entity.Property(e => e.AusMuscFeet).HasColumnName("AUS_MuscFeet");

                entity.Property(e => e.AusMuscFibr).HasColumnName("AUS_MuscFibr");

                entity.Property(e => e.AusMuscHip).HasColumnName("AUS_MuscHip");

                entity.Property(e => e.AusMuscKnee).HasColumnName("AUS_MuscKnee");

                entity.Property(e => e.AusMuscOther).HasColumnName("AUS_MuscOther");

                entity.Property(e => e.AusOtherAnemia).HasColumnName("AUS_OtherAnemia");

                entity.Property(e => e.AusOtherCancer).HasColumnName("AUS_OtherCancer");

                entity.Property(e => e.AusOtherOther).HasColumnName("AUS_OtherOther");

                entity.Property(e => e.AusOtherPso).HasColumnName("AUS_OtherPso");

                entity.Property(e => e.AusOtherSkin).HasColumnName("AUS_OtherSkin");

                entity.Property(e => e.AusPsyAnx).HasColumnName("AUS_PsyAnx");

                entity.Property(e => e.AusPsyDep).HasColumnName("AUS_PsyDep");

                entity.Property(e => e.AusPsyEat).HasColumnName("AUS_PsyEat");

                entity.Property(e => e.AusPsyHead).HasColumnName("AUS_PsyHead");

                entity.Property(e => e.AusPsyOther).HasColumnName("AUS_PsyOther");

                entity.Property(e => e.AusPsyPhob).HasColumnName("AUS_PsyPhob");

                entity.Property(e => e.AusPsyStroke).HasColumnName("AUS_PsyStroke");

                entity.Property(e => e.AusPulApnea).HasColumnName("AUS_PulApnea");

                entity.Property(e => e.AusPulAsthma).HasColumnName("AUS_PulAsthma");

                entity.Property(e => e.AusPulEmb).HasColumnName("AUS_PulEmb");

                entity.Property(e => e.AusPulOther).HasColumnName("AUS_PulOther");

                entity.Property(e => e.LogDateTime).HasColumnType("datetime");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");
            });

            modelBuilder.Entity<TblPatientComorbidityNotesBold>(entity =>
            {
                entity.HasKey(e => new { e.TblComorbidityNotesId, e.OrganizationCode })
                    .HasName("PK_tblPatientComorbidityNotes");

                entity.ToTable("tblPatientComorbidityNotes_Bold");

                entity.Property(e => e.TblComorbidityNotesId)
                    .HasColumnName("tblComorbidityNotes_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ConsultId).HasColumnName("ConsultID");

                entity.Property(e => e.Cvs).HasColumnName("CVS");

                entity.Property(e => e.Gas).HasColumnName("GAS");

                entity.Property(e => e.Gen).HasColumnName("GEN");

                entity.Property(e => e.Met).HasColumnName("MET");

                entity.Property(e => e.Mus).HasColumnName("MUS");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Psy).HasColumnName("PSY");

                entity.Property(e => e.Pul).HasColumnName("PUL");

                entity.Property(e => e.Reprd).HasColumnName("REPRD");
            });

            modelBuilder.Entity<TblPatientConsult>(entity =>
            {
                entity.HasKey(e => new { e.ConsultId, e.OrganizationCode, e.PatientId })
                    .HasName("PK_tblPatientConsult_1")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientConsult");

                entity.HasIndex(e => new { e.OrganizationCode, e.ConsultId })
                    .HasName("IX_tblPatientConsult")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrganizationCode, e.PatientId, e.DateSeen })
                    .HasName("IX_tblPatientConsult_OrganizationPatiendIdDateSeen");

                entity.HasIndex(e => new { e.ConsultId, e.PatientId, e.OrganizationCode, e.DateSeen, e.DateDeleted, e.Weight })
                    .HasName("IX_tblPatientConsult_WeightLoss");

                entity.Property(e => e.ConsultId)
                    .HasColumnName("ConsultID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.AdjAddVol).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdjAnesthesiaVol).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdjInitialVol).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdjRemoveVol).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Albumin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AlkPhos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Alt)
                    .HasColumnName("ALT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ArthritisLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArthritisProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ast)
                    .HasColumnName("AST")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AsthmaLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AsthmaProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.B12).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BackLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BackProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bicarbonate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BloodPressure)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BloodPressureRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bmiweight)
                    .HasColumnName("BMIWeight")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bmr)
                    .HasColumnName("BMR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BprxDetails)
                    .HasColumnName("BPRxDetails")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Calcium).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CardiovascularReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ChiefComplaint)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Chloride).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConsultType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Creatinine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cvdlevel)
                    .HasColumnName("CVDLevel")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateNextVisit).HasColumnType("datetime");

                entity.Property(e => e.DateSeen).HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiabetesProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiabetesRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiabetesRxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DiastolicBp).HasColumnName("DiastolicBP");

                entity.Property(e => e.EndocrineReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Entreview)
                    .HasColumnName("ENTReview")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExtremitiesReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.EyesReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.FatPerCent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FbloodGlucose)
                    .HasColumnName("FBloodGlucose")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ferritin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FertilityLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FertilityProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.FirstVisitWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Folate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FreeFatMass).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FserumInsulin)
                    .HasColumnName("FSerumInsulin")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GastroReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.GenitoReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Ggt)
                    .HasColumnName("GGT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hba1c)
                    .HasColumnName("HBA1C")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Hdlcholesterol).HasColumnName("HDLCholesterol");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.HematologicReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Hemoglobin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hip)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HipCircumference)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HypertensionProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ibc)
                    .HasColumnName("IBC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImageDate).HasColumnType("datetime");

                entity.Property(e => e.ImageDate1).HasColumnType("datetime");

                entity.Property(e => e.ImageDate2).HasColumnType("datetime");

                entity.Property(e => e.ImageLocation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLocation1)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLocation2)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Impedance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncontinenceLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IncontinenceProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.Iron).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LapbandAdjustment)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.Ldlcholesterol).HasColumnName("LDLCholesterol");

                entity.Property(e => e.LipidProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.LipidRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.LipidRxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MedicationsReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Months).HasDefaultValueSql("((0))");

                entity.Property(e => e.MusculoskeletalReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Neck)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NeurologicalReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Notes2)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.OtherRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherRxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pfshreview)
                    .HasColumnName("PFSHReview")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Phosphate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Platelets).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Potassium).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PsychiatricReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.RefluxLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefluxProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.RegistryDiabetes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryGerd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryHyperlipidemia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryHypertension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryReoperationNote)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrySedetail).HasColumnName("RegistrySEDetail");

                entity.Property(e => e.RegistrySelist)
                    .HasColumnName("RegistrySEList")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrySenote)
                    .HasColumnName("RegistrySENote")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrySleepApnea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReservoirVolume)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RespiratoryReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.SagittalDiameter)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SkinReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.SleepLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SleepProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sodium).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupportGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SystolicBp).HasColumnName("SystolicBP");

                entity.Property(e => e.TotalBodyWater).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tprotein).HasColumnName("TProtein");

                entity.Property(e => e.Transferrin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tsh).HasColumnName("TSH");

                entity.Property(e => e.Urea).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserField1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserField2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserField3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserField4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserField5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserMemoField1)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.UserMemoField2)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.VideoDate).HasColumnType("datetime");

                entity.Property(e => e.VideoLocation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VideoName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VideoResult)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VitD).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Waist)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WaistCircumference)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Wcc)
                    .HasColumnName("WCC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WeeksLastVisit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.WeightLastVisit).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblPatientConsultBold>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.TblPatientConsultComorbidityId })
                    .HasName("PK_tbl_ConsultComorbidity");

                entity.ToTable("tblPatientConsult_Bold");

                entity.Property(e => e.TblPatientConsultComorbidityId)
                    .HasColumnName("tblPatientConsultComorbidity_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AcsCopd)
                    .HasColumnName("ACS_Copd")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsCpap)
                    .HasColumnName("ACS_Cpap")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsCsurg)
                    .HasColumnName("ACS_Csurg")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsDiab)
                    .HasColumnName("ACS_Diab")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsDvt)
                    .HasColumnName("ACS_Dvt")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsEmbo)
                    .HasColumnName("ACS_Embo")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsFat)
                    .HasColumnName("ACS_Fat")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsGal)
                    .HasColumnName("ACS_Gal")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsGerd)
                    .HasColumnName("ACS_Gerd")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsHealth)
                    .HasColumnName("ACS_Health")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsHyper)
                    .HasColumnName("ACS_Hyper")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsLipid)
                    .HasColumnName("ACS_Lipid")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsMeds)
                    .HasColumnName("ACS_Meds")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsMob)
                    .HasColumnName("ACS_Mob")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsMuscd)
                    .HasColumnName("ACS_Muscd")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsMyo)
                    .HasColumnName("ACS_Myo")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsObese)
                    .HasColumnName("ACS_Obese")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsOxy)
                    .HasColumnName("ACS_Oxy")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsPain)
                    .HasColumnName("ACS_Pain")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsPci)
                    .HasColumnName("ACS_Pci")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsSho)
                    .HasColumnName("ACS_Sho")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsSmoke)
                    .HasColumnName("ACS_Smoke")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsSurg)
                    .HasColumnName("ACS_Surg")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsUri)
                    .HasColumnName("ACS_Uri")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsVenous)
                    .HasColumnName("ACS_Venous")
                    .HasMaxLength(50);

                entity.Property(e => e.AusCvsAnti)
                    .HasColumnName("AUS_CvsAnti")
                    .IsUnicode(false);

                entity.Property(e => e.AusCvsBlood)
                    .HasColumnName("AUS_CvsBlood")
                    .IsUnicode(false);

                entity.Property(e => e.AusCvsCol)
                    .HasColumnName("AUS_CvsCol")
                    .IsUnicode(false);

                entity.Property(e => e.AusCvsDvt)
                    .HasColumnName("AUS_CvsDVT")
                    .IsUnicode(false);

                entity.Property(e => e.AusCvsIsc)
                    .HasColumnName("AUS_CvsIsc")
                    .IsUnicode(false);

                entity.Property(e => e.AusCvsOtherDesc)
                    .HasColumnName("AUS_CvsOtherDesc")
                    .IsUnicode(false);

                entity.Property(e => e.AusCvsOtherName)
                    .HasColumnName("AUS_CvsOtherName")
                    .IsUnicode(false);

                entity.Property(e => e.AusCvsVen)
                    .HasColumnName("AUS_CvsVen")
                    .IsUnicode(false);

                entity.Property(e => e.AusEndDiab)
                    .HasColumnName("AUS_EndDiab")
                    .IsUnicode(false);

                entity.Property(e => e.AusEndOtherDesc)
                    .HasColumnName("AUS_EndOtherDesc")
                    .IsUnicode(false);

                entity.Property(e => e.AusEndOtherName)
                    .HasColumnName("AUS_EndOtherName")
                    .IsUnicode(false);

                entity.Property(e => e.AusEndThy)
                    .HasColumnName("AUS_EndThy")
                    .IsUnicode(false);

                entity.Property(e => e.AusGasGall)
                    .HasColumnName("AUS_GasGall")
                    .IsUnicode(false);

                entity.Property(e => e.AusGasHep)
                    .HasColumnName("AUS_GasHep")
                    .IsUnicode(false);

                entity.Property(e => e.AusGasOtherDesc)
                    .HasColumnName("AUS_GasOtherDesc")
                    .IsUnicode(false);

                entity.Property(e => e.AusGasOtherName)
                    .HasColumnName("AUS_GasOtherName")
                    .IsUnicode(false);

                entity.Property(e => e.AusGasRef)
                    .HasColumnName("AUS_GasRef")
                    .IsUnicode(false);

                entity.Property(e => e.AusGasUlc)
                    .HasColumnName("AUS_GasUlc")
                    .IsUnicode(false);

                entity.Property(e => e.AusGenInf)
                    .HasColumnName("AUS_GenInf")
                    .IsUnicode(false);

                entity.Property(e => e.AusGenRen)
                    .HasColumnName("AUS_GenRen")
                    .IsUnicode(false);

                entity.Property(e => e.AusGenUri)
                    .HasColumnName("AUS_GenUri")
                    .IsUnicode(false);

                entity.Property(e => e.AusMuscBack)
                    .HasColumnName("AUS_MuscBack")
                    .IsUnicode(false);

                entity.Property(e => e.AusMuscFeet)
                    .HasColumnName("AUS_MuscFeet")
                    .IsUnicode(false);

                entity.Property(e => e.AusMuscFibr)
                    .HasColumnName("AUS_MuscFibr")
                    .IsUnicode(false);

                entity.Property(e => e.AusMuscHip)
                    .HasColumnName("AUS_MuscHip")
                    .IsUnicode(false);

                entity.Property(e => e.AusMuscKnee)
                    .HasColumnName("AUS_MuscKnee")
                    .IsUnicode(false);

                entity.Property(e => e.AusMuscOtherDesc)
                    .HasColumnName("AUS_MuscOtherDesc")
                    .IsUnicode(false);

                entity.Property(e => e.AusMuscOtherName)
                    .HasColumnName("AUS_MuscOtherName")
                    .IsUnicode(false);

                entity.Property(e => e.AusOtherAnemia)
                    .HasColumnName("AUS_OtherAnemia")
                    .IsUnicode(false);

                entity.Property(e => e.AusOtherCancer)
                    .HasColumnName("AUS_OtherCancer")
                    .IsUnicode(false);

                entity.Property(e => e.AusOtherOtherDesc)
                    .HasColumnName("AUS_OtherOtherDesc")
                    .IsUnicode(false);

                entity.Property(e => e.AusOtherOtherName)
                    .HasColumnName("AUS_OtherOtherName")
                    .IsUnicode(false);

                entity.Property(e => e.AusOtherPso)
                    .HasColumnName("AUS_OtherPso")
                    .IsUnicode(false);

                entity.Property(e => e.AusOtherSkin)
                    .HasColumnName("AUS_OtherSkin")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyAnx)
                    .HasColumnName("AUS_PsyAnx")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyDep)
                    .HasColumnName("AUS_PsyDep")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyEat)
                    .HasColumnName("AUS_PsyEat")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyHead)
                    .HasColumnName("AUS_PsyHead")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyOtherDesc)
                    .HasColumnName("AUS_PsyOtherDesc")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyOtherName)
                    .HasColumnName("AUS_PsyOtherName")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyPhob)
                    .HasColumnName("AUS_PsyPhob")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyStroke)
                    .HasColumnName("AUS_PsyStroke")
                    .IsUnicode(false);

                entity.Property(e => e.AusPulApnea)
                    .HasColumnName("AUS_PulApnea")
                    .IsUnicode(false);

                entity.Property(e => e.AusPulAsthma)
                    .HasColumnName("AUS_PulAsthma")
                    .IsUnicode(false);

                entity.Property(e => e.AusPulEmb)
                    .HasColumnName("AUS_PulEmb")
                    .IsUnicode(false);

                entity.Property(e => e.AusPulOtherDesc)
                    .HasColumnName("AUS_PulOtherDesc")
                    .IsUnicode(false);

                entity.Property(e => e.AusPulOtherName)
                    .HasColumnName("AUS_PulOtherName")
                    .IsUnicode(false);

                entity.Property(e => e.BoldFlag).HasColumnName("Bold_Flag");

                entity.Property(e => e.BoldVisitId)
                    .HasColumnName("BoldVisitID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConsultId).HasColumnName("ConsultID");

                entity.Property(e => e.CvsAngina)
                    .HasColumnName("CVS_Angina")
                    .HasMaxLength(10);

                entity.Property(e => e.CvsCongestive)
                    .HasColumnName("CVS_Congestive")
                    .HasMaxLength(10);

                entity.Property(e => e.CvsDvt)
                    .HasColumnName("CVS_DVT")
                    .HasMaxLength(10);

                entity.Property(e => e.CvsHypertension)
                    .HasColumnName("CVS_Hypertension")
                    .HasMaxLength(10);

                entity.Property(e => e.CvsIschemic)
                    .HasColumnName("CVS_Ischemic")
                    .HasMaxLength(10);

                entity.Property(e => e.CvsLower)
                    .HasColumnName("CVS_Lower")
                    .HasMaxLength(10);

                entity.Property(e => e.CvsPeripheral)
                    .HasColumnName("CVS_Peripheral")
                    .HasMaxLength(10);

                entity.Property(e => e.GasCholelithiasis)
                    .HasColumnName("GAS_Cholelithiasis")
                    .HasMaxLength(10);

                entity.Property(e => e.GasGerd)
                    .HasColumnName("GAS_Gerd")
                    .HasMaxLength(10);

                entity.Property(e => e.GasLiver)
                    .HasColumnName("GAS_Liver")
                    .HasMaxLength(10);

                entity.Property(e => e.GenCerebri)
                    .HasColumnName("GEN_Cerebri")
                    .HasMaxLength(10);

                entity.Property(e => e.GenFunctional)
                    .HasColumnName("GEN_Functional")
                    .HasMaxLength(10);

                entity.Property(e => e.GenHernia)
                    .HasColumnName("GEN_Hernia")
                    .HasMaxLength(10);

                entity.Property(e => e.GenPrevPcisurgery)
                    .HasColumnName("GEN_PrevPCISurgery")
                    .HasMaxLength(10);

                entity.Property(e => e.GenRenalFail)
                    .HasColumnName("GEN_RenalFail")
                    .HasMaxLength(10);

                entity.Property(e => e.GenRenalInsuff)
                    .HasColumnName("GEN_RenalInsuff")
                    .HasMaxLength(10);

                entity.Property(e => e.GenSkin)
                    .HasColumnName("GEN_Skin")
                    .HasMaxLength(10);

                entity.Property(e => e.GenSteroid)
                    .HasColumnName("GEN_Steroid")
                    .HasMaxLength(10);

                entity.Property(e => e.GenStress)
                    .HasColumnName("GEN_Stress")
                    .HasMaxLength(10);

                entity.Property(e => e.GenTherapeutic)
                    .HasColumnName("GEN_Therapeutic")
                    .HasMaxLength(10);

                entity.Property(e => e.MedicationList).IsUnicode(false);

                entity.Property(e => e.MetGlucose)
                    .HasColumnName("MET_Glucose")
                    .HasMaxLength(10);

                entity.Property(e => e.MetGout)
                    .HasColumnName("MET_Gout")
                    .HasMaxLength(10);

                entity.Property(e => e.MetLipids)
                    .HasColumnName("MET_Lipids")
                    .HasMaxLength(10);

                entity.Property(e => e.MusBackPain)
                    .HasColumnName("MUS_BackPain")
                    .HasMaxLength(10);

                entity.Property(e => e.MusFibromyalgia)
                    .HasColumnName("MUS_Fibromyalgia")
                    .HasMaxLength(10);

                entity.Property(e => e.MusMusculoskeletal)
                    .HasColumnName("MUS_Musculoskeletal")
                    .HasMaxLength(10);

                entity.Property(e => e.PatientHeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PatientId)
                    .HasColumnName("PatientID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatientVisitDate).HasColumnType("datetime");

                entity.Property(e => e.PatientWeight).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.PsyAbuse)
                    .HasColumnName("PSY_Abuse")
                    .HasMaxLength(10);

                entity.Property(e => e.PsyAlcohol)
                    .HasColumnName("PSY_Alcohol")
                    .HasMaxLength(10);

                entity.Property(e => e.PsyDepression)
                    .HasColumnName("PSY_Depression")
                    .HasMaxLength(10);

                entity.Property(e => e.PsyImpairment)
                    .HasColumnName("PSY_Impairment")
                    .HasMaxLength(10);

                entity.Property(e => e.PsyMentalHealth)
                    .HasColumnName("PSY_MentalHealth")
                    .HasMaxLength(10);

                entity.Property(e => e.PsyTobacoo)
                    .HasColumnName("PSY_Tobacoo")
                    .HasMaxLength(10);

                entity.Property(e => e.PulAsthma)
                    .HasColumnName("PUL_Asthma")
                    .HasMaxLength(10);

                entity.Property(e => e.PulObesity)
                    .HasColumnName("PUL_Obesity")
                    .HasMaxLength(10);

                entity.Property(e => e.PulObstructive)
                    .HasColumnName("PUL_Obstructive")
                    .HasMaxLength(10);

                entity.Property(e => e.PulPulHypertension)
                    .HasColumnName("PUL_PulHypertension")
                    .HasMaxLength(10);

                entity.Property(e => e.ReprdMenstrual)
                    .HasColumnName("REPRD_Menstrual")
                    .HasMaxLength(10);

                entity.Property(e => e.ReprdPolycystic)
                    .HasColumnName("REPRD_Polycystic")
                    .HasMaxLength(10);

                entity.Property(e => e.SupportGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VitaminDescription)
                    .HasColumnName("Vitamin_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.VitaminList).HasMaxLength(50);
            });

            modelBuilder.Entity<TblPatientConsultBoldNotes>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.TblPatientConsultComorbidityNotesId })
                    .HasName("PK_tbl_ConsultComorbidityNotes");

                entity.ToTable("tblPatientConsult_Bold_Notes");

                entity.Property(e => e.TblPatientConsultComorbidityNotesId)
                    .HasColumnName("tblPatientConsultComorbidityNotes_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AcsCopdNotes).HasColumnName("ACS_Copd_Notes");

                entity.Property(e => e.AcsCpapNotes).HasColumnName("ACS_Cpap_Notes");

                entity.Property(e => e.AcsCsurgNotes).HasColumnName("ACS_Csurg_Notes");

                entity.Property(e => e.AcsDiabNotes).HasColumnName("ACS_Diab_Notes");

                entity.Property(e => e.AcsDvtNotes).HasColumnName("ACS_Dvt_Notes");

                entity.Property(e => e.AcsEmboNotes).HasColumnName("ACS_Embo_Notes");

                entity.Property(e => e.AcsFatNotes).HasColumnName("ACS_Fat_Notes");

                entity.Property(e => e.AcsGalNotes).HasColumnName("ACS_Gal_Notes");

                entity.Property(e => e.AcsGeneralNotes).HasColumnName("ACS_General_Notes");

                entity.Property(e => e.AcsGerdNotes).HasColumnName("ACS_Gerd_Notes");

                entity.Property(e => e.AcsHealthNotes).HasColumnName("ACS_Health_Notes");

                entity.Property(e => e.AcsHyperNotes).HasColumnName("ACS_Hyper_Notes");

                entity.Property(e => e.AcsLipidNotes).HasColumnName("ACS_Lipid_Notes");

                entity.Property(e => e.AcsMedsNotes).HasColumnName("ACS_Meds_Notes");

                entity.Property(e => e.AcsMobNotes).HasColumnName("ACS_Mob_Notes");

                entity.Property(e => e.AcsMuscdNotes).HasColumnName("ACS_Muscd_Notes");

                entity.Property(e => e.AcsMyoNotes).HasColumnName("ACS_Myo_Notes");

                entity.Property(e => e.AcsObeseNotes).HasColumnName("ACS_Obese_Notes");

                entity.Property(e => e.AcsOxyNotes).HasColumnName("ACS_Oxy_Notes");

                entity.Property(e => e.AcsPainNotes).HasColumnName("ACS_Pain_Notes");

                entity.Property(e => e.AcsPciNotes).HasColumnName("ACS_Pci_Notes");

                entity.Property(e => e.AcsShoNotes).HasColumnName("ACS_Sho_Notes");

                entity.Property(e => e.AcsSmokeNotes).HasColumnName("ACS_Smoke_Notes");

                entity.Property(e => e.AcsSurgNotes).HasColumnName("ACS_Surg_Notes");

                entity.Property(e => e.AcsUriNotes).HasColumnName("ACS_Uri_Notes");

                entity.Property(e => e.AcsVenousNotes).HasColumnName("ACS_Venous_Notes");

                entity.Property(e => e.ComorbidityReview)
                    .HasColumnName("Comorbidity_Review")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ConsultId).HasColumnName("ConsultID");

                entity.Property(e => e.CvsAnginaNotes).HasColumnName("CVS_Angina_Notes");

                entity.Property(e => e.CvsCongestiveNotes).HasColumnName("CVS_Congestive_Notes");

                entity.Property(e => e.CvsDvtNotes).HasColumnName("CVS_DVT_Notes");

                entity.Property(e => e.CvsHypertensionNotes).HasColumnName("CVS_Hypertension_Notes");

                entity.Property(e => e.CvsIschemicNotes).HasColumnName("CVS_Ischemic_Notes");

                entity.Property(e => e.CvsLowerNotes).HasColumnName("CVS_Lower_Notes");

                entity.Property(e => e.CvsPeripheralNotes).HasColumnName("CVS_Peripheral_Notes");

                entity.Property(e => e.ExtraComorbidity).HasColumnName("Extra_Comorbidity");

                entity.Property(e => e.GasCholelithiasisNotes).HasColumnName("GAS_Cholelithiasis_Notes");

                entity.Property(e => e.GasGerdNotes).HasColumnName("GAS_Gerd_Notes");

                entity.Property(e => e.GasLiverNotes).HasColumnName("GAS_Liver_Notes");

                entity.Property(e => e.GenCerebriNotes).HasColumnName("GEN_Cerebri_Notes");

                entity.Property(e => e.GenFunctionalNotes).HasColumnName("GEN_Functional_Notes");

                entity.Property(e => e.GenHerniaNotes).HasColumnName("GEN_Hernia_Notes");

                entity.Property(e => e.GenPrevPcisurgeryNotes).HasColumnName("GEN_PrevPCISurgery_Notes");

                entity.Property(e => e.GenRenalFailNotes).HasColumnName("GEN_RenalFail_Notes");

                entity.Property(e => e.GenRenalInsuffNotes).HasColumnName("GEN_RenalInsuff_Notes");

                entity.Property(e => e.GenSkinNotes).HasColumnName("GEN_Skin_Notes");

                entity.Property(e => e.GenSteroidNotes).HasColumnName("GEN_Steroid_Notes");

                entity.Property(e => e.GenStressNotes).HasColumnName("GEN_Stress_Notes");

                entity.Property(e => e.GenTherapeuticNotes).HasColumnName("GEN_Therapeutic_Notes");

                entity.Property(e => e.MetGlucoseNotes).HasColumnName("MET_Glucose_Notes");

                entity.Property(e => e.MetGoutNotes).HasColumnName("MET_Gout_Notes");

                entity.Property(e => e.MetLipidsNotes).HasColumnName("MET_Lipids_Notes");

                entity.Property(e => e.MusBackPainNotes).HasColumnName("MUS_BackPain_Notes");

                entity.Property(e => e.MusFibromyalgiaNotes).HasColumnName("MUS_Fibromyalgia_Notes");

                entity.Property(e => e.MusMusculoskeletalNotes).HasColumnName("MUS_Musculoskeletal_Notes");

                entity.Property(e => e.PatientId)
                    .HasColumnName("PatientID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PsyAbuseNotes).HasColumnName("PSY_Abuse_Notes");

                entity.Property(e => e.PsyAlcoholNotes).HasColumnName("PSY_Alcohol_Notes");

                entity.Property(e => e.PsyDepressionNotes).HasColumnName("PSY_Depression_Notes");

                entity.Property(e => e.PsyImpairmentNotes).HasColumnName("PSY_Impairment_Notes");

                entity.Property(e => e.PsyMentalHealthNotes).HasColumnName("PSY_MentalHealth_Notes");

                entity.Property(e => e.PsyTobacooNotes).HasColumnName("PSY_Tobacoo_Notes");

                entity.Property(e => e.PulAsthmaNotes).HasColumnName("PUL_Asthma_Notes");

                entity.Property(e => e.PulObesityNotes).HasColumnName("PUL_Obesity_Notes");

                entity.Property(e => e.PulObstructiveNotes).HasColumnName("PUL_Obstructive_Notes");

                entity.Property(e => e.PulPulHypertensionNotes).HasColumnName("PUL_PulHypertension_Notes");

                entity.Property(e => e.ReprdMenstrualNotes).HasColumnName("REPRD_Menstrual_Notes");

                entity.Property(e => e.ReprdPolycysticNotes).HasColumnName("REPRD_Polycystic_Notes");
            });

            modelBuilder.Entity<TblPatientConsultFollowup>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.PatientId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientConsult_Followup");

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.FollowupAppointment)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupDate).HasColumnType("datetime");

                entity.Property(e => e.FollowupLetterPatient)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupLetterPhysician)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupLost)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupRefuse)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupTransfer)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FollowupTransferName)
                    .HasMaxLength(1024)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPatientConsultLog>(entity =>
            {
                entity.HasKey(e => e.ConsultLogId)
                    .HasName("PK_tblPatientConsultLog_1")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientConsultLog");

                entity.Property(e => e.ConsultLogId).HasColumnName("ConsultLogID");

                entity.Property(e => e.AdjAddVol).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdjAnesthesiaVol).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdjInitialVol).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AdjRemoveVol).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Albumin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AlkPhos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Alt)
                    .HasColumnName("ALT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ArthritisLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArthritisProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ast)
                    .HasColumnName("AST")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AsthmaLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AsthmaProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.B12).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BackLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BackProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bicarbonate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BloodPressure)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BloodPressureRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bmiweight)
                    .HasColumnName("BMIWeight")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bmr)
                    .HasColumnName("BMR")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BprxDetails)
                    .HasColumnName("BPRxDetails")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Calcium).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CardiovascularReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ChiefComplaint)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Chloride).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConsultId).HasColumnName("ConsultID");

                entity.Property(e => e.ConsultType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Creatinine).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cvdlevel)
                    .HasColumnName("CVDLevel")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateNextVisit).HasColumnType("datetime");

                entity.Property(e => e.DateSeen).HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiabetesProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiabetesRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiabetesRxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DiastolicBp).HasColumnName("DiastolicBP");

                entity.Property(e => e.EndocrineReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Entreview)
                    .HasColumnName("ENTReview")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExtremitiesReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.EyesReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.FatPerCent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FbloodGlucose)
                    .HasColumnName("FBloodGlucose")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Ferritin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FertilityLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FertilityProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.FirstVisitWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Folate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FreeFatMass).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FserumInsulin)
                    .HasColumnName("FSerumInsulin")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GastroReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.GenitoReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Ggt)
                    .HasColumnName("GGT")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hba1c)
                    .HasColumnName("HBA1C")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Hdlcholesterol).HasColumnName("HDLCholesterol");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.HematologicReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Hemoglobin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hip)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HipCircumference)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.HypertensionProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ibc)
                    .HasColumnName("IBC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImageDate).HasColumnType("datetime");

                entity.Property(e => e.ImageDate1).HasColumnType("datetime");

                entity.Property(e => e.ImageDate2).HasColumnType("datetime");

                entity.Property(e => e.ImageLocation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLocation1)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLocation2)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Impedance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IncontinenceLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IncontinenceProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.Iron).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LapbandAdjustment)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.Ldlcholesterol).HasColumnName("LDLCholesterol");

                entity.Property(e => e.LipidProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.LipidRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.LipidRxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LogDateTime).HasColumnType("datetime");

                entity.Property(e => e.MedicationsReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Months).HasDefaultValueSql("((0))");

                entity.Property(e => e.MusculoskeletalReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Neck)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NeurologicalReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Notes2)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.OtherRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherRxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.Pfshreview)
                    .HasColumnName("PFSHReview")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Phosphate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Platelets).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Potassium).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PsychiatricReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.RefluxLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefluxProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.RegistryDiabetes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryGerd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryHyperlipidemia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryHypertension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryReoperationNote)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrySedetail).HasColumnName("RegistrySEDetail");

                entity.Property(e => e.RegistrySelist)
                    .HasColumnName("RegistrySEList")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrySenote)
                    .HasColumnName("RegistrySENote")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrySleepApnea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReservoirVolume)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RespiratoryReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.SagittalDiameter)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SkinReview)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.SleepLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SleepProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sodium).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupportGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SystolicBp).HasColumnName("SystolicBP");

                entity.Property(e => e.TotalBodyWater).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tprotein).HasColumnName("TProtein");

                entity.Property(e => e.Transferrin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tsh).HasColumnName("TSH");

                entity.Property(e => e.Urea).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserField1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserField2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserField3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserField4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserField5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserMemoField1)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.UserMemoField2)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.VideoDate).HasColumnType("datetime");

                entity.Property(e => e.VideoLocation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VideoName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VideoResult)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VitD).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Waist)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WaistCircumference)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Wcc)
                    .HasColumnName("WCC")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WeeksLastVisit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.WeightLastVisit).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblPatientConsultLogBold>(entity =>
            {
                entity.HasKey(e => e.TblPatientConsultComorbidityLogId)
                    .HasName("PK_tbl_ConsultComorbidityLog");

                entity.ToTable("tblPatientConsultLog_Bold");

                entity.Property(e => e.TblPatientConsultComorbidityLogId).HasColumnName("tblPatientConsultComorbidityLog_ID");

                entity.Property(e => e.AcsCopd)
                    .HasColumnName("ACS_Copd")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsCpap)
                    .HasColumnName("ACS_Cpap")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsCsurg)
                    .HasColumnName("ACS_Csurg")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsDiab)
                    .HasColumnName("ACS_Diab")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsDvt)
                    .HasColumnName("ACS_Dvt")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsEmbo)
                    .HasColumnName("ACS_Embo")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsFat)
                    .HasColumnName("ACS_Fat")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsGal)
                    .HasColumnName("ACS_Gal")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsGerd)
                    .HasColumnName("ACS_Gerd")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsHealth)
                    .HasColumnName("ACS_Health")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsHyper)
                    .HasColumnName("ACS_Hyper")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsLipid)
                    .HasColumnName("ACS_Lipid")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsMeds)
                    .HasColumnName("ACS_Meds")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsMob)
                    .HasColumnName("ACS_Mob")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsMuscd)
                    .HasColumnName("ACS_Muscd")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsMyo)
                    .HasColumnName("ACS_Myo")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsObese)
                    .HasColumnName("ACS_Obese")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsOxy)
                    .HasColumnName("ACS_Oxy")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsPain)
                    .HasColumnName("ACS_Pain")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsPci)
                    .HasColumnName("ACS_Pci")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsSho)
                    .HasColumnName("ACS_Sho")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsSmoke)
                    .HasColumnName("ACS_Smoke")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsSurg)
                    .HasColumnName("ACS_Surg")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsUri)
                    .HasColumnName("ACS_Uri")
                    .HasMaxLength(50);

                entity.Property(e => e.AcsVenous)
                    .HasColumnName("ACS_Venous")
                    .HasMaxLength(50);

                entity.Property(e => e.AusCvsAnti)
                    .HasColumnName("AUS_CvsAnti")
                    .IsUnicode(false);

                entity.Property(e => e.AusCvsBlood)
                    .HasColumnName("AUS_CvsBlood")
                    .IsUnicode(false);

                entity.Property(e => e.AusCvsCol)
                    .HasColumnName("AUS_CvsCol")
                    .IsUnicode(false);

                entity.Property(e => e.AusCvsDvt)
                    .HasColumnName("AUS_CvsDVT")
                    .IsUnicode(false);

                entity.Property(e => e.AusCvsIsc)
                    .HasColumnName("AUS_CvsIsc")
                    .IsUnicode(false);

                entity.Property(e => e.AusCvsOtherDesc)
                    .HasColumnName("AUS_CvsOtherDesc")
                    .IsUnicode(false);

                entity.Property(e => e.AusCvsOtherName)
                    .HasColumnName("AUS_CvsOtherName")
                    .IsUnicode(false);

                entity.Property(e => e.AusCvsVen)
                    .HasColumnName("AUS_CvsVen")
                    .IsUnicode(false);

                entity.Property(e => e.AusEndDiab)
                    .HasColumnName("AUS_EndDiab")
                    .IsUnicode(false);

                entity.Property(e => e.AusEndOtherDesc)
                    .HasColumnName("AUS_EndOtherDesc")
                    .IsUnicode(false);

                entity.Property(e => e.AusEndOtherName)
                    .HasColumnName("AUS_EndOtherName")
                    .IsUnicode(false);

                entity.Property(e => e.AusEndThy)
                    .HasColumnName("AUS_EndThy")
                    .IsUnicode(false);

                entity.Property(e => e.AusGasGall)
                    .HasColumnName("AUS_GasGall")
                    .IsUnicode(false);

                entity.Property(e => e.AusGasHep)
                    .HasColumnName("AUS_GasHep")
                    .IsUnicode(false);

                entity.Property(e => e.AusGasOtherDesc)
                    .HasColumnName("AUS_GasOtherDesc")
                    .IsUnicode(false);

                entity.Property(e => e.AusGasOtherName)
                    .HasColumnName("AUS_GasOtherName")
                    .IsUnicode(false);

                entity.Property(e => e.AusGasRef)
                    .HasColumnName("AUS_GasRef")
                    .IsUnicode(false);

                entity.Property(e => e.AusGasUlc)
                    .HasColumnName("AUS_GasUlc")
                    .IsUnicode(false);

                entity.Property(e => e.AusGenInf)
                    .HasColumnName("AUS_GenInf")
                    .IsUnicode(false);

                entity.Property(e => e.AusGenRen)
                    .HasColumnName("AUS_GenRen")
                    .IsUnicode(false);

                entity.Property(e => e.AusGenUri)
                    .HasColumnName("AUS_GenUri")
                    .IsUnicode(false);

                entity.Property(e => e.AusMuscBack)
                    .HasColumnName("AUS_MuscBack")
                    .IsUnicode(false);

                entity.Property(e => e.AusMuscFeet)
                    .HasColumnName("AUS_MuscFeet")
                    .IsUnicode(false);

                entity.Property(e => e.AusMuscFibr)
                    .HasColumnName("AUS_MuscFibr")
                    .IsUnicode(false);

                entity.Property(e => e.AusMuscHip)
                    .HasColumnName("AUS_MuscHip")
                    .IsUnicode(false);

                entity.Property(e => e.AusMuscKnee)
                    .HasColumnName("AUS_MuscKnee")
                    .IsUnicode(false);

                entity.Property(e => e.AusMuscOtherDesc)
                    .HasColumnName("AUS_MuscOtherDesc")
                    .IsUnicode(false);

                entity.Property(e => e.AusMuscOtherName)
                    .HasColumnName("AUS_MuscOtherName")
                    .IsUnicode(false);

                entity.Property(e => e.AusOtherAnemia)
                    .HasColumnName("AUS_OtherAnemia")
                    .IsUnicode(false);

                entity.Property(e => e.AusOtherCancer)
                    .HasColumnName("AUS_OtherCancer")
                    .IsUnicode(false);

                entity.Property(e => e.AusOtherOtherDesc)
                    .HasColumnName("AUS_OtherOtherDesc")
                    .IsUnicode(false);

                entity.Property(e => e.AusOtherOtherName)
                    .HasColumnName("AUS_OtherOtherName")
                    .IsUnicode(false);

                entity.Property(e => e.AusOtherPso)
                    .HasColumnName("AUS_OtherPso")
                    .IsUnicode(false);

                entity.Property(e => e.AusOtherSkin)
                    .HasColumnName("AUS_OtherSkin")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyAnx)
                    .HasColumnName("AUS_PsyAnx")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyDep)
                    .HasColumnName("AUS_PsyDep")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyEat)
                    .HasColumnName("AUS_PsyEat")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyHead)
                    .HasColumnName("AUS_PsyHead")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyOtherDesc)
                    .HasColumnName("AUS_PsyOtherDesc")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyOtherName)
                    .HasColumnName("AUS_PsyOtherName")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyPhob)
                    .HasColumnName("AUS_PsyPhob")
                    .IsUnicode(false);

                entity.Property(e => e.AusPsyStroke)
                    .HasColumnName("AUS_PsyStroke")
                    .IsUnicode(false);

                entity.Property(e => e.AusPulApnea)
                    .HasColumnName("AUS_PulApnea")
                    .IsUnicode(false);

                entity.Property(e => e.AusPulAsthma)
                    .HasColumnName("AUS_PulAsthma")
                    .IsUnicode(false);

                entity.Property(e => e.AusPulEmb)
                    .HasColumnName("AUS_PulEmb")
                    .IsUnicode(false);

                entity.Property(e => e.AusPulOtherDesc)
                    .HasColumnName("AUS_PulOtherDesc")
                    .IsUnicode(false);

                entity.Property(e => e.AusPulOtherName)
                    .HasColumnName("AUS_PulOtherName")
                    .IsUnicode(false);

                entity.Property(e => e.BoldFlag).HasColumnName("Bold_Flag");

                entity.Property(e => e.BoldVisitId)
                    .HasColumnName("BoldVisitID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConsultId).HasColumnName("ConsultID");

                entity.Property(e => e.CvsAngina)
                    .HasColumnName("CVS_Angina")
                    .HasMaxLength(10);

                entity.Property(e => e.CvsCongestive)
                    .HasColumnName("CVS_Congestive")
                    .HasMaxLength(10);

                entity.Property(e => e.CvsDvt)
                    .HasColumnName("CVS_DVT")
                    .HasMaxLength(10);

                entity.Property(e => e.CvsHypertension)
                    .HasColumnName("CVS_Hypertension")
                    .HasMaxLength(10);

                entity.Property(e => e.CvsIschemic)
                    .HasColumnName("CVS_Ischemic")
                    .HasMaxLength(10);

                entity.Property(e => e.CvsLower)
                    .HasColumnName("CVS_Lower")
                    .HasMaxLength(10);

                entity.Property(e => e.CvsPeripheral)
                    .HasColumnName("CVS_Peripheral")
                    .HasMaxLength(10);

                entity.Property(e => e.GasCholelithiasis)
                    .HasColumnName("GAS_Cholelithiasis")
                    .HasMaxLength(10);

                entity.Property(e => e.GasGerd)
                    .HasColumnName("GAS_Gerd")
                    .HasMaxLength(10);

                entity.Property(e => e.GasLiver)
                    .HasColumnName("GAS_Liver")
                    .HasMaxLength(10);

                entity.Property(e => e.GenCerebri)
                    .HasColumnName("GEN_Cerebri")
                    .HasMaxLength(10);

                entity.Property(e => e.GenFunctional)
                    .HasColumnName("GEN_Functional")
                    .HasMaxLength(10);

                entity.Property(e => e.GenHernia)
                    .HasColumnName("GEN_Hernia")
                    .HasMaxLength(10);

                entity.Property(e => e.GenPrevPcisurgery)
                    .HasColumnName("GEN_PrevPCISurgery")
                    .HasMaxLength(10);

                entity.Property(e => e.GenRenalFail)
                    .HasColumnName("GEN_RenalFail")
                    .HasMaxLength(10);

                entity.Property(e => e.GenRenalInsuff)
                    .HasColumnName("GEN_RenalInsuff")
                    .HasMaxLength(10);

                entity.Property(e => e.GenSkin)
                    .HasColumnName("GEN_Skin")
                    .HasMaxLength(10);

                entity.Property(e => e.GenSteroid)
                    .HasColumnName("GEN_Steroid")
                    .HasMaxLength(10);

                entity.Property(e => e.GenStress)
                    .HasColumnName("GEN_Stress")
                    .HasMaxLength(10);

                entity.Property(e => e.GenTherapeutic)
                    .HasColumnName("GEN_Therapeutic")
                    .HasMaxLength(10);

                entity.Property(e => e.LogDateTime).HasColumnType("datetime");

                entity.Property(e => e.MedicationList).IsUnicode(false);

                entity.Property(e => e.MetGlucose)
                    .HasColumnName("MET_Glucose")
                    .HasMaxLength(10);

                entity.Property(e => e.MetGout)
                    .HasColumnName("MET_Gout")
                    .HasMaxLength(10);

                entity.Property(e => e.MetLipids)
                    .HasColumnName("MET_Lipids")
                    .HasMaxLength(10);

                entity.Property(e => e.MusBackPain)
                    .HasColumnName("MUS_BackPain")
                    .HasMaxLength(10);

                entity.Property(e => e.MusFibromyalgia)
                    .HasColumnName("MUS_Fibromyalgia")
                    .HasMaxLength(10);

                entity.Property(e => e.MusMusculoskeletal)
                    .HasColumnName("MUS_Musculoskeletal")
                    .HasMaxLength(10);

                entity.Property(e => e.PatientHeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PatientId)
                    .HasColumnName("PatientID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatientVisitDate).HasColumnType("datetime");

                entity.Property(e => e.PatientWeight).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.PsyAbuse)
                    .HasColumnName("PSY_Abuse")
                    .HasMaxLength(10);

                entity.Property(e => e.PsyAlcohol)
                    .HasColumnName("PSY_Alcohol")
                    .HasMaxLength(10);

                entity.Property(e => e.PsyDepression)
                    .HasColumnName("PSY_Depression")
                    .HasMaxLength(10);

                entity.Property(e => e.PsyImpairment)
                    .HasColumnName("PSY_Impairment")
                    .HasMaxLength(10);

                entity.Property(e => e.PsyMentalHealth)
                    .HasColumnName("PSY_MentalHealth")
                    .HasMaxLength(10);

                entity.Property(e => e.PsyTobacoo)
                    .HasColumnName("PSY_Tobacoo")
                    .HasMaxLength(10);

                entity.Property(e => e.PulAsthma)
                    .HasColumnName("PUL_Asthma")
                    .HasMaxLength(10);

                entity.Property(e => e.PulObesity)
                    .HasColumnName("PUL_Obesity")
                    .HasMaxLength(10);

                entity.Property(e => e.PulObstructive)
                    .HasColumnName("PUL_Obstructive")
                    .HasMaxLength(10);

                entity.Property(e => e.PulPulHypertension)
                    .HasColumnName("PUL_PulHypertension")
                    .HasMaxLength(10);

                entity.Property(e => e.ReprdMenstrual)
                    .HasColumnName("REPRD_Menstrual")
                    .HasMaxLength(10);

                entity.Property(e => e.ReprdPolycystic)
                    .HasColumnName("REPRD_Polycystic")
                    .HasMaxLength(10);

                entity.Property(e => e.SupportGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TblPatientConsultComorbidityId).HasColumnName("tblPatientConsultComorbidity_ID");

                entity.Property(e => e.VitaminDescription)
                    .HasColumnName("Vitamin_Description")
                    .HasMaxLength(255);

                entity.Property(e => e.VitaminList).HasMaxLength(50);
            });

            modelBuilder.Entity<TblPatientDocuments>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.TblPatientDocumentsId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientDocuments");

                entity.Property(e => e.TblPatientDocumentsId)
                    .HasColumnName("tblPatientDocumentsID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DocDescription)
                    .HasColumnName("Doc_Description")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentFileSize).HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventLink)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPatientDocumentsContent>(entity =>
            {
                entity.HasKey(e => new { e.TblPatientDocumentsContentId, e.OrganizationCode });

                entity.ToTable("tblPatientDocumentsContent");

                entity.Property(e => e.TblPatientDocumentsContentId)
                    .HasColumnName("tblPatientDocumentsContentID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContentFile).HasColumnType("image");

                entity.Property(e => e.TblPatientDocumentsId).HasColumnName("tblPatientDocumentsID");
            });

            modelBuilder.Entity<TblPatientDocumentsEventLog>(entity =>
            {
                entity.HasKey(e => new { e.TblPatientDocumentsEventLogId, e.OrganizationCode });

                entity.ToTable("tblPatientDocumentsEventLog");

                entity.Property(e => e.TblPatientDocumentsEventLogId)
                    .HasColumnName("tblPatientDocumentsEventLogID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.TblPatientDocumentsId).HasColumnName("tblPatientDocumentsID");
            });

            modelBuilder.Entity<TblPatientEmr>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.PatientId })
                    .HasName("PK_tblPatientEMR_1")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientEMR");

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.AllergyAnesthetic)
                    .HasColumnName("Allergy_Anesthetic")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyAnestheticRisk)
                    .HasColumnName("Allergy_AnestheticRisk")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyDoDrugs).HasColumnName("Allergy_DoDrugs");

                entity.Property(e => e.AllergyDoDrugsNotes)
                    .HasColumnName("Allergy_DoDrugs_Notes")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyDrinkBeer).HasColumnName("Allergy_DrinkBeer");

                entity.Property(e => e.AllergyDrinkPerDay)
                    .HasColumnName("Allergy_DrinkPerDay")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyDrinkPerWeek)
                    .HasColumnName("Allergy_DrinkPerWeek")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyDrinkSpirits).HasColumnName("Allergy_DrinkSpirits");

                entity.Property(e => e.AllergyDrinkWine).HasColumnName("Allergy_DrinkWine");

                entity.Property(e => e.AllergyExcessBleed).HasColumnName("Allergy_ExcessBleed");

                entity.Property(e => e.AllergyHaveAllergy).HasColumnName("Allergy_HaveAllergy");

                entity.Property(e => e.AllergyHaveDrink)
                    .HasColumnName("Allergy_HaveDrink")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyHaveMedication).HasColumnName("Allergy_HaveMedication");

                entity.Property(e => e.AllergyHaveSmoke).HasColumnName("Allergy_HaveSmoke");

                entity.Property(e => e.AllergyHaveSmokePerDay)
                    .HasColumnName("Allergy_HaveSmokePerDay")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyHaveSmokeStop)
                    .HasColumnName("Allergy_HaveSmokeStop")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyHaveSmokeYears)
                    .HasColumnName("Allergy_HaveSmokeYears")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyLatex).HasColumnName("Allergy_Latex");

                entity.Property(e => e.AllergyListAllergy)
                    .HasColumnName("Allergy_ListAllergy")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyListMedication)
                    .HasColumnName("Allergy_ListMedication")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AllergySmoke)
                    .HasColumnName("Allergy_Smoke")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllergySmokePerDay)
                    .HasColumnName("Allergy_SmokePerDay")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundAsthma)
                    .HasColumnName("Background_Asthma")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundDiabetes)
                    .HasColumnName("Background_Diabetes")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundFamilyHistory)
                    .HasColumnName("Background_FamilyHistory")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundGout)
                    .HasColumnName("Background_Gout")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundHeartDisease)
                    .HasColumnName("Background_HeartDisease")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundHighCholesterol)
                    .HasColumnName("Background_HighCholesterol")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundHypertension)
                    .HasColumnName("Background_Hypertension")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundObesity)
                    .HasColumnName("Background_Obesity")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundPastHealth)
                    .HasColumnName("Background_PastHealth")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundPreviousBariatric)
                    .HasColumnName("Background_PreviousBariatric")
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundPreviousNonBariatric)
                    .HasColumnName("Background_PreviousNonBariatric")
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundSnoring)
                    .HasColumnName("Background_Snoring")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Complaint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComplaintNotes)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.DeceasedDate).HasColumnType("datetime");

                entity.Property(e => e.DetailsAddContact1Address)
                    .HasColumnName("Details_AddContact1Address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact1HomePhone)
                    .HasColumnName("Details_AddContact1HomePhone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact1Mobile)
                    .HasColumnName("Details_AddContact1Mobile")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact1Name)
                    .HasColumnName("Details_AddContact1Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact1Relation)
                    .HasColumnName("Details_AddContact1Relation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact2Address)
                    .HasColumnName("Details_AddContact2Address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact2HomePhone)
                    .HasColumnName("Details_AddContact2HomePhone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact2Mobile)
                    .HasColumnName("Details_AddContact2Mobile")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact2Name)
                    .HasColumnName("Details_AddContact2Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact2Relation)
                    .HasColumnName("Details_AddContact2Relation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsChildren)
                    .HasColumnName("Details_Children")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsDeceasedNote)
                    .HasColumnName("Details_DeceasedNote")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsDeceasedPrimaryProcedure).HasColumnName("Details_DeceasedPrimaryProcedure");

                entity.Property(e => e.DetailsFamilyStructure)
                    .HasColumnName("Details_FamilyStructure")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsLiveAtHome)
                    .HasColumnName("Details_LiveAtHome")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsMedicareNumber)
                    .HasColumnName("Details_MedicareNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsNextOfKinAddress)
                    .HasColumnName("Details_NextOfKinAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsNextOfKinHomePhone)
                    .HasColumnName("Details_NextOfKinHomePhone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsNextOfKinMobile)
                    .HasColumnName("Details_NextOfKinMobile")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsNextOfKinName)
                    .HasColumnName("Details_NextOfKinName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsNextOfKinRelation)
                    .HasColumnName("Details_NextOfKinRelation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsNextOfKinWorkPhone)
                    .HasColumnName("Details_NextOfKinWorkPhone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsOccupation)
                    .HasColumnName("Details_Occupation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsPhotoPath)
                    .HasColumnName("Details_PhotoPath")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsSpouseName)
                    .HasColumnName("Details_SpouseName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExamAa)
                    .HasColumnName("Exam_AA")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamCh)
                    .HasColumnName("Exam_CH")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamCp)
                    .HasColumnName("Exam_CP")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamGao)
                    .HasColumnName("Exam_GAO")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamHng)
                    .HasColumnName("Exam_HNG")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamHnh)
                    .HasColumnName("Exam_HNH")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamHnm)
                    .HasColumnName("Exam_HNM")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamHnn)
                    .HasColumnName("Exam_HNN")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamLsa)
                    .HasColumnName("Exam_LSA")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamLsb)
                    .HasColumnName("Exam_LSB")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamLsr)
                    .HasColumnName("Exam_LSR")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamMf)
                    .HasColumnName("Exam_MF")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamMso)
                    .HasColumnName("Exam_MSO")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamNotes)
                    .HasColumnName("Exam_Notes")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationAbg)
                    .HasColumnName("Investigation_ABG")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationAbs)
                    .HasColumnName("Investigation_ABS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionAbg)
                    .HasColumnName("Investigation_ActionABG")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionAbs)
                    .HasColumnName("Investigation_ActionABS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionBm)
                    .HasColumnName("Investigation_ActionBM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionCx)
                    .HasColumnName("Investigation_ActionCX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionEet)
                    .HasColumnName("Investigation_ActionEET")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionEkg)
                    .HasColumnName("Investigation_ActionEKG")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionEms)
                    .HasColumnName("Investigation_ActionEMS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionP)
                    .HasColumnName("Investigation_ActionP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionRbs)
                    .HasColumnName("Investigation_ActionRBS")
                    .HasMaxLength(10);

                entity.Property(e => e.InvestigationActionRft)
                    .HasColumnName("Investigation_ActionRFT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationBm)
                    .HasColumnName("Investigation_BM")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationCx)
                    .HasColumnName("Investigation_CX")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationEet)
                    .HasColumnName("Investigation_EET")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationEkg)
                    .HasColumnName("Investigation_EKG")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationEms)
                    .HasColumnName("Investigation_EMS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationP)
                    .HasColumnName("Investigation_P")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationRbs)
                    .HasColumnName("Investigation_RBS")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationRft)
                    .HasColumnName("Investigation_RFT")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LabNotes)
                    .HasColumnName("Lab_Notes")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Management)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Medication)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralsAp)
                    .HasColumnName("Referrals_AP")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralsC)
                    .HasColumnName("Referrals_C")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralsE)
                    .HasColumnName("Referrals_E")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralsGm)
                    .HasColumnName("Referrals_GM")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralsO)
                    .HasColumnName("Referrals_O")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralsPa)
                    .HasColumnName("Referrals_PA")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralsRp)
                    .HasColumnName("Referrals_RP")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryAntihypertensives)
                    .HasColumnName("Registry_Antihypertensives")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryDiabetes)
                    .HasColumnName("Registry_Diabetes")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryGerd)
                    .HasColumnName("Registry_Gerd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryHyperlipidemia)
                    .HasColumnName("Registry_Hyperlipidemia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryHypertension)
                    .HasColumnName("Registry_Hypertension")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryInsulin)
                    .HasColumnName("Registry_Insulin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrySleepApnea)
                    .HasColumnName("Registry_SleepApnea")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemCardio)
                    .HasColumnName("ReviewSystem_Cardio")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemEndo)
                    .HasColumnName("ReviewSystem_Endo")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemEnt)
                    .HasColumnName("ReviewSystem_ENT")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemExtr)
                    .HasColumnName("ReviewSystem_Extr")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemEyes)
                    .HasColumnName("ReviewSystem_Eyes")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemGastro)
                    .HasColumnName("ReviewSystem_Gastro")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemGeneral)
                    .HasColumnName("ReviewSystem_General")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemGenito)
                    .HasColumnName("ReviewSystem_Genito")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemHema)
                    .HasColumnName("ReviewSystem_Hema")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemMeds)
                    .HasColumnName("ReviewSystem_Meds")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemMusculo)
                    .HasColumnName("ReviewSystem_Musculo")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemNeuro)
                    .HasColumnName("ReviewSystem_Neuro")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemPfsh)
                    .HasColumnName("ReviewSystem_PFSH")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemPsych)
                    .HasColumnName("ReviewSystem_Psych")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemResp)
                    .HasColumnName("ReviewSystem_Resp")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemSkin)
                    .HasColumnName("ReviewSystem_Skin")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationActionGe)
                    .HasColumnName("SpecialInvestigation_ActionGE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationActionNa)
                    .HasColumnName("SpecialInvestigation_ActionNA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationActionOa)
                    .HasColumnName("SpecialInvestigation_ActionOA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationActionPs)
                    .HasColumnName("SpecialInvestigation_ActionPS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationActionSp)
                    .HasColumnName("SpecialInvestigation_ActionSP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationActionSs)
                    .HasColumnName("SpecialInvestigation_ActionSS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationSuggestedGe)
                    .HasColumnName("SpecialInvestigation_SuggestedGE")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationSuggestedNa)
                    .HasColumnName("SpecialInvestigation_SuggestedNA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationSuggestedOa)
                    .HasColumnName("SpecialInvestigation_SuggestedOA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationSuggestedPs)
                    .HasColumnName("SpecialInvestigation_SuggestedPS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationSuggestedSp)
                    .HasColumnName("SpecialInvestigation_SuggestedSP")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationSuggestedSs)
                    .HasColumnName("SpecialInvestigation_SuggestedSS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryAdviceList)
                    .HasColumnName("WeightHistory_AdviceList")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryAdviceOther)
                    .HasColumnName("WeightHistory_AdviceOther")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryCosmeticList)
                    .HasColumnName("WeightHistory_CosmeticList")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryDietList)
                    .HasColumnName("WeightHistory_DietList")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryGainWeight)
                    .HasColumnName("WeightHistory_GainWeight")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WeightHistoryGainYears)
                    .HasColumnName("WeightHistory_GainYears")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryGroupDuration)
                    .HasColumnName("WeightHistory_GroupDuration")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryGroupList)
                    .HasColumnName("WeightHistory_GroupList")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryGroupLose)
                    .HasColumnName("WeightHistory_GroupLose")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryGroupOther)
                    .HasColumnName("WeightHistory_GroupOther")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryLoseYears)
                    .HasColumnName("WeightHistory_LoseYears")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryOther)
                    .HasColumnName("WeightHistory_Other")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryPillList)
                    .HasColumnName("WeightHistory_PillList")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryPillOther)
                    .HasColumnName("WeightHistory_PillOther")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryTreatmentList)
                    .HasColumnName("WeightHistory_TreatmentList")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryTryMethod)
                    .HasColumnName("WeightHistory_TryMethod")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryWeightBirth)
                    .HasColumnName("WeightHistory_WeightBirth")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryWeightEndHighSchool)
                    .HasColumnName("WeightHistory_WeightEndHighSchool")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryWeightMarriage)
                    .HasColumnName("WeightHistory_WeightMarriage")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryWeightStartHighSchool)
                    .HasColumnName("WeightHistory_WeightStartHighSchool")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryWeightStartSchool)
                    .HasColumnName("WeightHistory_WeightStartSchool")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryWeightWork)
                    .HasColumnName("WeightHistory_WeightWork")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPatientEmrlog>(entity =>
            {
                entity.HasKey(e => e.PatientEmrlogId)
                    .HasName("PK_tblPatientEMRLog_1")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientEMRLog");

                entity.Property(e => e.PatientEmrlogId).HasColumnName("PatientEMRLogID");

                entity.Property(e => e.AllergyAnesthetic)
                    .HasColumnName("Allergy_Anesthetic")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyAnestheticRisk)
                    .HasColumnName("Allergy_AnestheticRisk")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyDoDrugs).HasColumnName("Allergy_DoDrugs");

                entity.Property(e => e.AllergyDoDrugsNotes)
                    .HasColumnName("Allergy_DoDrugs_Notes")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyDrinkBeer).HasColumnName("Allergy_DrinkBeer");

                entity.Property(e => e.AllergyDrinkPerDay)
                    .HasColumnName("Allergy_DrinkPerDay")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyDrinkPerWeek)
                    .HasColumnName("Allergy_DrinkPerWeek")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyDrinkSpirits).HasColumnName("Allergy_DrinkSpirits");

                entity.Property(e => e.AllergyDrinkWine).HasColumnName("Allergy_DrinkWine");

                entity.Property(e => e.AllergyExcessBleed).HasColumnName("Allergy_ExcessBleed");

                entity.Property(e => e.AllergyHaveAllergy).HasColumnName("Allergy_HaveAllergy");

                entity.Property(e => e.AllergyHaveDrink)
                    .HasColumnName("Allergy_HaveDrink")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyHaveMedication).HasColumnName("Allergy_HaveMedication");

                entity.Property(e => e.AllergyHaveSmoke).HasColumnName("Allergy_HaveSmoke");

                entity.Property(e => e.AllergyHaveSmokePerDay)
                    .HasColumnName("Allergy_HaveSmokePerDay")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyHaveSmokeStop)
                    .HasColumnName("Allergy_HaveSmokeStop")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyHaveSmokeYears)
                    .HasColumnName("Allergy_HaveSmokeYears")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyLatex).HasColumnName("Allergy_Latex");

                entity.Property(e => e.AllergyListAllergy)
                    .HasColumnName("Allergy_ListAllergy")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AllergyListMedication)
                    .HasColumnName("Allergy_ListMedication")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.AllergySmoke)
                    .HasColumnName("Allergy_Smoke")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllergySmokePerDay)
                    .HasColumnName("Allergy_SmokePerDay")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundAsthma)
                    .HasColumnName("Background_Asthma")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundDiabetes)
                    .HasColumnName("Background_Diabetes")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundFamilyHistory)
                    .HasColumnName("Background_FamilyHistory")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundGout)
                    .HasColumnName("Background_Gout")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundHeartDisease)
                    .HasColumnName("Background_HeartDisease")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundHighCholesterol)
                    .HasColumnName("Background_HighCholesterol")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundHypertension)
                    .HasColumnName("Background_Hypertension")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundObesity)
                    .HasColumnName("Background_Obesity")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundPastHealth)
                    .HasColumnName("Background_PastHealth")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundPreviousBariatric)
                    .HasColumnName("Background_PreviousBariatric")
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundPreviousNonBariatric)
                    .HasColumnName("Background_PreviousNonBariatric")
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundSnoring)
                    .HasColumnName("Background_Snoring")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Complaint)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ComplaintNotes)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.DeceasedDate).HasColumnType("datetime");

                entity.Property(e => e.DetailsAddContact1Address)
                    .HasColumnName("Details_AddContact1Address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact1HomePhone)
                    .HasColumnName("Details_AddContact1HomePhone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact1Mobile)
                    .HasColumnName("Details_AddContact1Mobile")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact1Name)
                    .HasColumnName("Details_AddContact1Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact1Relation)
                    .HasColumnName("Details_AddContact1Relation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact2Address)
                    .HasColumnName("Details_AddContact2Address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact2HomePhone)
                    .HasColumnName("Details_AddContact2HomePhone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact2Mobile)
                    .HasColumnName("Details_AddContact2Mobile")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact2Name)
                    .HasColumnName("Details_AddContact2Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsAddContact2Relation)
                    .HasColumnName("Details_AddContact2Relation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsChildren)
                    .HasColumnName("Details_Children")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsDeceasedNote)
                    .HasColumnName("Details_DeceasedNote")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsDeceasedPrimaryProcedure).HasColumnName("Details_DeceasedPrimaryProcedure");

                entity.Property(e => e.DetailsFamilyStructure)
                    .HasColumnName("Details_FamilyStructure")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsLiveAtHome)
                    .HasColumnName("Details_LiveAtHome")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsMedicareNumber)
                    .HasColumnName("Details_MedicareNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsNextOfKinAddress)
                    .HasColumnName("Details_NextOfKinAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsNextOfKinHomePhone)
                    .HasColumnName("Details_NextOfKinHomePhone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsNextOfKinMobile)
                    .HasColumnName("Details_NextOfKinMobile")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsNextOfKinName)
                    .HasColumnName("Details_NextOfKinName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsNextOfKinRelation)
                    .HasColumnName("Details_NextOfKinRelation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsNextOfKinWorkPhone)
                    .HasColumnName("Details_NextOfKinWorkPhone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsOccupation)
                    .HasColumnName("Details_Occupation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsPhotoPath)
                    .HasColumnName("Details_PhotoPath")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsSpouseName)
                    .HasColumnName("Details_SpouseName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExamAa)
                    .HasColumnName("Exam_AA")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamCh)
                    .HasColumnName("Exam_CH")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamCp)
                    .HasColumnName("Exam_CP")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamGao)
                    .HasColumnName("Exam_GAO")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamHng)
                    .HasColumnName("Exam_HNG")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamHnh)
                    .HasColumnName("Exam_HNH")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamHnm)
                    .HasColumnName("Exam_HNM")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamHnn)
                    .HasColumnName("Exam_HNN")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamLsa)
                    .HasColumnName("Exam_LSA")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamLsb)
                    .HasColumnName("Exam_LSB")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamLsr)
                    .HasColumnName("Exam_LSR")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamMf)
                    .HasColumnName("Exam_MF")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamMso)
                    .HasColumnName("Exam_MSO")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ExamNotes)
                    .HasColumnName("Exam_Notes")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationAbg)
                    .HasColumnName("Investigation_ABG")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationAbs)
                    .HasColumnName("Investigation_ABS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionAbg)
                    .HasColumnName("Investigation_ActionABG")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionAbs)
                    .HasColumnName("Investigation_ActionABS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionBm)
                    .HasColumnName("Investigation_ActionBM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionCx)
                    .HasColumnName("Investigation_ActionCX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionEet)
                    .HasColumnName("Investigation_ActionEET")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionEkg)
                    .HasColumnName("Investigation_ActionEKG")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionEms)
                    .HasColumnName("Investigation_ActionEMS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionP)
                    .HasColumnName("Investigation_ActionP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationActionRbs)
                    .HasColumnName("Investigation_ActionRBS")
                    .HasMaxLength(10);

                entity.Property(e => e.InvestigationActionRft)
                    .HasColumnName("Investigation_ActionRFT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationBm)
                    .HasColumnName("Investigation_BM")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationCx)
                    .HasColumnName("Investigation_CX")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationEet)
                    .HasColumnName("Investigation_EET")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationEkg)
                    .HasColumnName("Investigation_EKG")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationEms)
                    .HasColumnName("Investigation_EMS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationP)
                    .HasColumnName("Investigation_P")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationRbs)
                    .HasColumnName("Investigation_RBS")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.InvestigationRft)
                    .HasColumnName("Investigation_RFT")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LabNotes)
                    .HasColumnName("Lab_Notes")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.LogDateTime).HasColumnType("datetime");

                entity.Property(e => e.Management)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Medication)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.ReferralsAp)
                    .HasColumnName("Referrals_AP")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralsC)
                    .HasColumnName("Referrals_C")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralsE)
                    .HasColumnName("Referrals_E")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralsGm)
                    .HasColumnName("Referrals_GM")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralsO)
                    .HasColumnName("Referrals_O")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralsPa)
                    .HasColumnName("Referrals_PA")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralsRp)
                    .HasColumnName("Referrals_RP")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryAntihypertensives)
                    .HasColumnName("Registry_Antihypertensives")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryDiabetes)
                    .HasColumnName("Registry_Diabetes")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryGerd)
                    .HasColumnName("Registry_Gerd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryHyperlipidemia)
                    .HasColumnName("Registry_Hyperlipidemia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryHypertension)
                    .HasColumnName("Registry_Hypertension")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryInsulin)
                    .HasColumnName("Registry_Insulin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrySleepApnea)
                    .HasColumnName("Registry_SleepApnea")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemCardio)
                    .HasColumnName("ReviewSystem_Cardio")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemEndo)
                    .HasColumnName("ReviewSystem_Endo")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemEnt)
                    .HasColumnName("ReviewSystem_ENT")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemExtr)
                    .HasColumnName("ReviewSystem_Extr")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemEyes)
                    .HasColumnName("ReviewSystem_Eyes")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemGastro)
                    .HasColumnName("ReviewSystem_Gastro")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemGeneral)
                    .HasColumnName("ReviewSystem_General")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemGenito)
                    .HasColumnName("ReviewSystem_Genito")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemHema)
                    .HasColumnName("ReviewSystem_Hema")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemMeds)
                    .HasColumnName("ReviewSystem_Meds")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemMusculo)
                    .HasColumnName("ReviewSystem_Musculo")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemNeuro)
                    .HasColumnName("ReviewSystem_Neuro")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemPfsh)
                    .HasColumnName("ReviewSystem_PFSH")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemPsych)
                    .HasColumnName("ReviewSystem_Psych")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemResp)
                    .HasColumnName("ReviewSystem_Resp")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewSystemSkin)
                    .HasColumnName("ReviewSystem_Skin")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationActionGe)
                    .HasColumnName("SpecialInvestigation_ActionGE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationActionNa)
                    .HasColumnName("SpecialInvestigation_ActionNA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationActionOa)
                    .HasColumnName("SpecialInvestigation_ActionOA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationActionPs)
                    .HasColumnName("SpecialInvestigation_ActionPS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationActionSp)
                    .HasColumnName("SpecialInvestigation_ActionSP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationActionSs)
                    .HasColumnName("SpecialInvestigation_ActionSS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationSuggestedGe)
                    .HasColumnName("SpecialInvestigation_SuggestedGE")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationSuggestedNa)
                    .HasColumnName("SpecialInvestigation_SuggestedNA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationSuggestedOa)
                    .HasColumnName("SpecialInvestigation_SuggestedOA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationSuggestedPs)
                    .HasColumnName("SpecialInvestigation_SuggestedPS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationSuggestedSp)
                    .HasColumnName("SpecialInvestigation_SuggestedSP")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInvestigationSuggestedSs)
                    .HasColumnName("SpecialInvestigation_SuggestedSS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryAdviceList)
                    .HasColumnName("WeightHistory_AdviceList")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryAdviceOther)
                    .HasColumnName("WeightHistory_AdviceOther")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryCosmeticList)
                    .HasColumnName("WeightHistory_CosmeticList")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryDietList)
                    .HasColumnName("WeightHistory_DietList")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryGainWeight)
                    .HasColumnName("WeightHistory_GainWeight")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WeightHistoryGainYears)
                    .HasColumnName("WeightHistory_GainYears")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryGroupDuration)
                    .HasColumnName("WeightHistory_GroupDuration")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryGroupList)
                    .HasColumnName("WeightHistory_GroupList")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryGroupLose)
                    .HasColumnName("WeightHistory_GroupLose")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryGroupOther)
                    .HasColumnName("WeightHistory_GroupOther")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryLoseYears)
                    .HasColumnName("WeightHistory_LoseYears")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryOther)
                    .HasColumnName("WeightHistory_Other")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryPillList)
                    .HasColumnName("WeightHistory_PillList")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryPillOther)
                    .HasColumnName("WeightHistory_PillOther")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryTreatmentList)
                    .HasColumnName("WeightHistory_TreatmentList")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryTryMethod)
                    .HasColumnName("WeightHistory_TryMethod")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryWeightBirth)
                    .HasColumnName("WeightHistory_WeightBirth")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryWeightEndHighSchool)
                    .HasColumnName("WeightHistory_WeightEndHighSchool")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryWeightMarriage)
                    .HasColumnName("WeightHistory_WeightMarriage")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryWeightStartHighSchool)
                    .HasColumnName("WeightHistory_WeightStartHighSchool")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryWeightStartSchool)
                    .HasColumnName("WeightHistory_WeightStartSchool")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeightHistoryWeightWork)
                    .HasColumnName("WeightHistory_WeightWork")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPatientPathology>(entity =>
            {
                entity.HasKey(e => new { e.PathologyId, e.OrganizationCode, e.PatientId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientPathology");

                entity.Property(e => e.PathologyId)
                    .HasColumnName("PathologyID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PathologyBaseline)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PathologyDate).HasColumnType("datetime");

                entity.Property(e => e.RefDr)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPatientPathologyData>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.PatientId, e.PathologyId, e.TestId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientPathologyData");

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.PathologyId).HasColumnName("PathologyID");

                entity.Property(e => e.TestId)
                    .HasColumnName("TestID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PathologyDataDate).HasColumnType("datetime");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.TestName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TestRange)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TestStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TestUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TestValue).IsUnicode(false);
            });

            modelBuilder.Entity<TblPatientWeightData>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.PatientId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientWeightData");

                entity.HasIndex(e => new { e.OrganizationCode, e.PatientId, e.StartWeight })
                    .HasName("IX_tblPatientWeightData_WeightLoss1");

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.Approach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArthritisCurrentLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ArthritisResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.ArthritisResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.ArthritisResolvedLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Asacode)
                    .HasColumnName("ASACode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AsthmaCurrentLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AsthmaResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.AsthmaResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.AsthmaResolvedLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BackCurrentLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BackResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.BackResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.BackResolvedLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseAlbumin)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseAlkPhos)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseAlt)
                    .HasColumnName("BaseALT")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseArthritisDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseArthritisLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseArthritisProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseAssessmentDate).HasColumnType("datetime");

                entity.Property(e => e.BaseAst)
                    .HasColumnName("BaseAST")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseAsthmaDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseAsthmaLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseAsthmaProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseB12)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBackDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseBackPainLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseBackProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBaselineHstatus)
                    .HasColumnName("BaseBaselineHStatus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBicarbonate)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBilirubin)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBloodGlucoseLevel)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBloodPressureRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBloodPressureRxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseBmc)
                    .HasColumnName("BaseBMC")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBmipercentile)
                    .HasColumnName("BaseBMIPercentile")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBmr)
                    .HasColumnName("BaseBMR")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBodyFat)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBodyFatPc)
                    .HasColumnName("BaseBodyFatPC")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseCalcium)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseChloride)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseCholesterolProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseCpk)
                    .HasColumnName("BaseCPK")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseCreatinine)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseCvddetails)
                    .HasColumnName("BaseCVDDetails")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCvdlevel)
                    .HasColumnName("BaseCVDLevel")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCvdproblems)
                    .HasColumnName("BaseCVDProblems")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseDiabetesProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseDiabetesRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseDiabetesRxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseDiastolicBp)
                    .HasColumnName("BaseDiastolicBP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFatMass)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFatPerCent)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFbloodGlucose)
                    .HasColumnName("BaseFBloodGlucose")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFerritin)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFertilityDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseFertilityLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseFertilityProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFolate)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFreeFatMass)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFserumInsulin)
                    .HasColumnName("BaseFSerumInsulin")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseGgt)
                    .HasColumnName("BaseGGT")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseHba1c)
                    .HasColumnName("BaseHBA1C")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseHdlcholesterol)
                    .HasColumnName("BaseHDLCholesterol")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseHdlcholesterolProblems)
                    .HasColumnName("BaseHDLCholesterolProblems")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseHemoglobin)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseHomocysteine).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseHypertensionProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseIbc)
                    .HasColumnName("BaseIBC")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseImpedance)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseIncontinenceDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseIncontinenceLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseIncontinenceProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseIron)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseLdlcholesterol)
                    .HasColumnName("BaseLDLCholesterol")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseLeanBodyMass)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseLipidProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseLipidRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseLipidRxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseOtherDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseOtherProblems).HasColumnType("datetime");

                entity.Property(e => e.BaseOtherRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseOtherRxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BasePhosphate)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BasePlatelets)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BasePotassium)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseReason7)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseReason8)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseRefluxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseRefluxLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseRefluxProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseSleepDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseSleepLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseSleepProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseSodium)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseSystolicBp)
                    .HasColumnName("BaseSystolicBP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseT3).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseT4).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseTotalBodyWater)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseTotalCholesterol)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseTprotein)
                    .HasColumnName("BaseTProtein")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseTransferrin)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseTriglycerideProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseTriglycerides)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseTsh)
                    .HasColumnName("BaseTSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseUrea)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseUserField1)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUserField2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUserField3)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUserField4)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUserField5)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUserMemoField1)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUserMemoField2)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BaseVitD)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseWcc)
                    .HasColumnName("BaseWCC")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseZscore)
                    .HasColumnName("BaseZScore")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BloodTransfusion).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bmi)
                    .HasColumnName("BMI")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bmiheight)
                    .HasColumnName("BMIHeight")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Category)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comdata)
                    .HasColumnName("COMData")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComorbidityMonths)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComorbidtyOnFile).HasDefaultValueSql("((0))");

                entity.Property(e => e.Concurrent).IsUnicode(false);

                entity.Property(e => e.CurrentWeight)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CvdlevelCurrentLevel)
                    .HasColumnName("CVDLevelCurrentLevel")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CvdlevelResolved)
                    .HasColumnName("CVDLevelResolved")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CvdlevelResolvedDate)
                    .HasColumnName("CVDLevelResolvedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CvdlevelResolvedLevel)
                    .HasColumnName("CVDLevelResolvedLevel")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DiabetesResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiabetesResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.DiabetesResolvedFbglucose)
                    .HasColumnName("DiabetesResolvedFBglucose")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.Excluded).HasDefaultValueSql("((0))");

                entity.Property(e => e.FertilityCurrentLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FertilityResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.FertilityResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.FertilityResolvedLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FirstAssistant)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FirstVisitWeight)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Group)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Height)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HypertensionResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.HypertensionResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.HypertensionResolvedDiastolic).HasDefaultValueSql("((0))");

                entity.Property(e => e.HypertensionResolvedSystolic).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdealWeight)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InRoomTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IncontinenceCurrentLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IncontinenceResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.IncontinenceResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.IncontinenceResolvedLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LapBandDate).HasColumnType("datetime");

                entity.Property(e => e.LapbandSize)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LapbandType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastImageDate).HasColumnType("datetime");

                entity.Property(e => e.LastImageLocation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastReservoirVol)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LipidsResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.LipidsResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.Losttofollowup)
                    .HasColumnName("losttofollowup")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxWeight)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxWeightYr)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NextComorbidVisit).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.OpBmiweight)
                    .HasColumnName("OpBMIWeight")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpWeight)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherProcedure).IsUnicode(false);

                entity.Property(e => e.OutRoomTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PatientReport).HasDefaultValueSql("((0))");

                entity.Property(e => e.PreopAlbumin)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PreopAlbuminDate).HasColumnType("datetime");

                entity.Property(e => e.PreopHematocrit)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PreopHematocritDate).HasColumnType("datetime");

                entity.Property(e => e.ProcedureReport).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefluxCurrentLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RefluxResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefluxResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.RefluxResolvedLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SleepCurrentLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SleepResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.SleepResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.SleepResolvedLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StartBmiweight)
                    .HasColumnName("StartBMIWeight")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartBp1)
                    .HasColumnName("StartBP1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartBp2)
                    .HasColumnName("StartBP2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartHip)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartNeck)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartPr)
                    .HasColumnName("StartPR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartRr)
                    .HasColumnName("StartRR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartWaist)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartWeight)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartWeightDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeryEndTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeryStartTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeryType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TargetWeight)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TempFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Updated).HasDefaultValueSql("((0))");

                entity.Property(e => e.VisitWeeksFlag).HasDefaultValueSql("((4))");

                entity.Property(e => e.ZeroDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPatientWeightDataLog>(entity =>
            {
                entity.HasKey(e => e.PatientWeightDataLogId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientWeightDataLog");

                entity.Property(e => e.PatientWeightDataLogId).HasColumnName("PatientWeightDataLogID");

                entity.Property(e => e.Approach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArthritisCurrentLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ArthritisResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.ArthritisResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.ArthritisResolvedLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Asacode)
                    .HasColumnName("ASACode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AsthmaCurrentLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AsthmaResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.AsthmaResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.AsthmaResolvedLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BackCurrentLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BackResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.BackResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.BackResolvedLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseAlbumin)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseAlkPhos)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseAlt)
                    .HasColumnName("BaseALT")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseArthritisDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseArthritisLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseArthritisProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseAssessmentDate).HasColumnType("datetime");

                entity.Property(e => e.BaseAst)
                    .HasColumnName("BaseAST")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseAsthmaDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseAsthmaLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseAsthmaProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseB12)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBackDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseBackPainLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseBackProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBaselineHstatus)
                    .HasColumnName("BaseBaselineHStatus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBicarbonate)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBilirubin)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBloodGlucoseLevel)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBloodPressureRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBloodPressureRxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseBmc)
                    .HasColumnName("BaseBMC")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBmipercentile)
                    .HasColumnName("BaseBMIPercentile")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBmr)
                    .HasColumnName("BaseBMR")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBodyFat)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseBodyFatPc)
                    .HasColumnName("BaseBodyFatPC")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseCalcium)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseChloride)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseCholesterolProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseCpk)
                    .HasColumnName("BaseCPK")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseCreatinine)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseCvddetails)
                    .HasColumnName("BaseCVDDetails")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCvdlevel)
                    .HasColumnName("BaseCVDLevel")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCvdproblems)
                    .HasColumnName("BaseCVDProblems")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseDiabetesProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseDiabetesRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseDiabetesRxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseDiastolicBp)
                    .HasColumnName("BaseDiastolicBP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFatMass)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFatPerCent)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFbloodGlucose)
                    .HasColumnName("BaseFBloodGlucose")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFerritin)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFertilityDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseFertilityLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseFertilityProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFolate)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFreeFatMass)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseFserumInsulin)
                    .HasColumnName("BaseFSerumInsulin")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseGgt)
                    .HasColumnName("BaseGGT")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseHba1c)
                    .HasColumnName("BaseHBA1C")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseHdlcholesterol)
                    .HasColumnName("BaseHDLCholesterol")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseHdlcholesterolProblems)
                    .HasColumnName("BaseHDLCholesterolProblems")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseHemoglobin)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseHomocysteine).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseHypertensionProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseIbc)
                    .HasColumnName("BaseIBC")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseImpedance)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseIncontinenceDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseIncontinenceLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseIncontinenceProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseIron)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseLdlcholesterol)
                    .HasColumnName("BaseLDLCholesterol")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseLeanBodyMass)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseLipidProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseLipidRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseLipidRxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseOtherDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseOtherProblems).HasColumnType("datetime");

                entity.Property(e => e.BaseOtherRx).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseOtherRxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BasePhosphate)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BasePlatelets)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BasePotassium)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseReason7)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseReason8)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseRefluxDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseRefluxLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseRefluxProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseSleepDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BaseSleepLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BaseSleepProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseSodium)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseSystolicBp)
                    .HasColumnName("BaseSystolicBP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseT3).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseT4).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseTotalBodyWater)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseTotalCholesterol)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseTprotein)
                    .HasColumnName("BaseTProtein")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseTransferrin)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseTriglycerideProblems).HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseTriglycerides)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseTsh)
                    .HasColumnName("BaseTSH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseUrea)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseUserField1)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUserField2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUserField3)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUserField4)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUserField5)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUserMemoField1)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUserMemoField2)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.BaseVitD)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseWcc)
                    .HasColumnName("BaseWCC")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BaseZscore)
                    .HasColumnName("BaseZScore")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BloodTransfusion).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bmi)
                    .HasColumnName("BMI")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bmiheight)
                    .HasColumnName("BMIHeight")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Category)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comdata)
                    .HasColumnName("COMData")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComorbidityMonths)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ComorbidtyOnFile).HasDefaultValueSql("((0))");

                entity.Property(e => e.Concurrent).IsUnicode(false);

                entity.Property(e => e.CurrentWeight)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CvdlevelCurrentLevel)
                    .HasColumnName("CVDLevelCurrentLevel")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CvdlevelResolved)
                    .HasColumnName("CVDLevelResolved")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CvdlevelResolvedDate)
                    .HasColumnName("CVDLevelResolvedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CvdlevelResolvedLevel)
                    .HasColumnName("CVDLevelResolvedLevel")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DiabetesResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiabetesResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.DiabetesResolvedFbglucose)
                    .HasColumnName("DiabetesResolvedFBglucose")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.Excluded).HasDefaultValueSql("((0))");

                entity.Property(e => e.FertilityCurrentLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FertilityResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.FertilityResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.FertilityResolvedLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FirstAssistant)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FirstVisitWeight)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Group)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Height)
                    .HasColumnType("decimal(18, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HypertensionResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.HypertensionResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.HypertensionResolvedDiastolic).HasDefaultValueSql("((0))");

                entity.Property(e => e.HypertensionResolvedSystolic).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdealWeight)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InRoomTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IncontinenceCurrentLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IncontinenceResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.IncontinenceResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.IncontinenceResolvedLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LapBandDate).HasColumnType("datetime");

                entity.Property(e => e.LapbandSize)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LapbandType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastImageDate).HasColumnType("datetime");

                entity.Property(e => e.LastImageLocation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastReservoirVol)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LipidsResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.LipidsResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.LogDateTime).HasColumnType("datetime");

                entity.Property(e => e.Losttofollowup)
                    .HasColumnName("losttofollowup")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxWeight)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxWeightYr)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NextComorbidVisit).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.OpBmiweight)
                    .HasColumnName("OpBMIWeight")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpWeight)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherProcedure).IsUnicode(false);

                entity.Property(e => e.OutRoomTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.PatientReport).HasDefaultValueSql("((0))");

                entity.Property(e => e.PreopAlbumin)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PreopAlbuminDate).HasColumnType("datetime");

                entity.Property(e => e.PreopHematocrit)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.PreopHematocritDate).HasColumnType("datetime");

                entity.Property(e => e.ProcedureReport).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefluxCurrentLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RefluxResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefluxResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.RefluxResolvedLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SleepCurrentLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SleepResolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.SleepResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.SleepResolvedLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StartBmiweight)
                    .HasColumnName("StartBMIWeight")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartBp1)
                    .HasColumnName("StartBP1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartBp2)
                    .HasColumnName("StartBP2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartHip)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartNeck)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartPr)
                    .HasColumnName("StartPR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartRr)
                    .HasColumnName("StartRR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartWaist)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartWeight)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartWeightDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeryEndTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeryStartTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeryType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TargetWeight)
                    .HasColumnType("decimal(18, 9)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TempFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Updated).HasDefaultValueSql("((0))");

                entity.Property(e => e.VisitWeeksFlag).HasDefaultValueSql("((4))");

                entity.Property(e => e.ZeroDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPatients>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.PatientId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatients");

                entity.HasIndex(e => new { e.OrganizationCode, e.PatientId, e.DateLastVisit, e.DateDeleted })
                    .HasName("IX_tblPatients");

                entity.HasIndex(e => new { e.OrganizationCode, e.PatientId, e.DateLastVisit, e.DateDeleted, e.Birthdate })
                    .HasName("IX_tblPatients_WeightLoss2");

                entity.Property(e => e.PatientId)
                    .HasColumnName("Patient Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.ConsultationDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedByComputer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByWindowsUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateFirstVisit)
                    .HasColumnName("Date First Visit")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateLastVisit)
                    .HasColumnName("Date Last Visit")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateNextVisit)
                    .HasColumnName("Date Next Visit")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorId)
                    .HasColumnName("Doctor Id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasColumnName("Home Phone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Insurance)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.MaritalStatus)
                    .HasColumnName("Marital status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalSummary).IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByComputer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByWindowsUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameId)
                    .HasColumnName("Name Id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PatientMdId).HasColumnName("Patient MD Id");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Race)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrDate1).HasColumnType("datetime");

                entity.Property(e => e.RefDrDate2).HasColumnType("datetime");

                entity.Property(e => e.RefDrDate3).HasColumnType("datetime");

                entity.Property(e => e.RefDrDuration1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrDuration2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrDuration3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrId1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrId2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrId3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrStatus1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrStatus2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrStatus3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceId)
                    .HasColumnName("Reference Id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralDate).HasColumnType("datetime");

                entity.Property(e => e.ReferralDuration)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteDrId)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Select).HasDefaultValueSql("((0))");

                entity.Property(e => e.Select2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Select3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sex)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SocialHistory)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasDefaultValueSql("((0))");

                entity.Property(e => e.WebExport).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkPhone)
                    .HasColumnName("Work Phone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ZeroDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPatientsBold>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.PatientId })
                    .HasName("PK_tbl_Patients_BOLD");

                entity.ToTable("tblPatients_BOLD");

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.BoldChartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DietryWeightLoss)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentStatus)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HasConsentedToSrc).HasColumnName("HasConsentedToSRC");

                entity.Property(e => e.InsuranceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iqtesting).HasColumnName("IQTesting");

                entity.Property(e => e.IsCoverProcedure).HasDefaultValueSql("((-1))");

                entity.Property(e => e.LowestWeightAchieved).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LowestWeightAchievedActual).HasColumnName("LowestWeightAchieved_Actual");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OriginalWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalWeightActual).HasColumnName("OriginalWeight_Actual");

                entity.Property(e => e.PatientCustomId)
                    .HasColumnName("Patient_CustomId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PbsEvent)
                    .HasColumnName("PBS_Event")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PbsProcedure)
                    .HasColumnName("PBS_Procedure")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PbsSurgeonId).HasColumnName("PBS_SurgeonID");

                entity.Property(e => e.PbsYear).HasColumnName("PBS_Year");

                entity.Property(e => e.PnbsProcedure)
                    .HasColumnName("PNBS_Procedure")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreCertificationOther)
                    .HasColumnName("PreCertification_Other")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreOperativeWeightLoss).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SecondaryInsurance)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SocialSecurityNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TertiaryInsurance)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPatientsBoldlog>(entity =>
            {
                entity.HasKey(e => e.PatientBoldLogId)
                    .HasName("PK_tbl_Patients_BOLDLog");

                entity.ToTable("tblPatients_BOLDLog");

                entity.Property(e => e.PatientBoldLogId).HasColumnName("PatientBoldLogID");

                entity.Property(e => e.BoldChartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DietryWeightLoss)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentStatus)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.HasConsentedToSrc).HasColumnName("HasConsentedToSRC");

                entity.Property(e => e.InsuranceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iqtesting).HasColumnName("IQTesting");

                entity.Property(e => e.IsCoverProcedure).HasDefaultValueSql("((-1))");

                entity.Property(e => e.LogDateTime).HasColumnType("datetime");

                entity.Property(e => e.LowestWeightAchieved).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LowestWeightAchievedActual).HasColumnName("LowestWeightAchieved_Actual");

                entity.Property(e => e.OriginalWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalWeightActual).HasColumnName("OriginalWeight_Actual");

                entity.Property(e => e.PatientCustomId)
                    .HasColumnName("Patient_CustomId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.PbsEvent)
                    .HasColumnName("PBS_Event")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PbsProcedure)
                    .HasColumnName("PBS_Procedure")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PbsSurgeonId).HasColumnName("PBS_SurgeonID");

                entity.Property(e => e.PbsYear).HasColumnName("PBS_Year");

                entity.Property(e => e.PnbsProcedure)
                    .HasColumnName("PNBS_Procedure")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreCertificationOther)
                    .HasColumnName("PreCertification_Other")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreOperativeWeightLoss).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SecondaryInsurance)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SocialSecurityNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TertiaryInsurance)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPatientsLog>(entity =>
            {
                entity.HasKey(e => e.PatientIdlog)
                    .HasName("PK_tblPatientsLog_1")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblPatientsLog");

                entity.Property(e => e.PatientIdlog).HasColumnName("PatientIDLog");

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.ConsultationDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedByComputer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByWindowsUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateFirstVisit)
                    .HasColumnName("Date First Visit")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateLastVisit)
                    .HasColumnName("Date Last Visit")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateNextVisit)
                    .HasColumnName("Date Next Visit")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorId)
                    .HasColumnName("Doctor Id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasColumnName("Home Phone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Insurance)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LogDateTime).HasColumnType("datetime");

                entity.Property(e => e.MaritalStatus)
                    .HasColumnName("Marital status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalSummary).IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByComputer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByWindowsUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameId)
                    .HasColumnName("Name Id")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient Id");

                entity.Property(e => e.PatientMdId).HasColumnName("Patient MD Id");

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Race)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrDate1).HasColumnType("datetime");

                entity.Property(e => e.RefDrDate2).HasColumnType("datetime");

                entity.Property(e => e.RefDrDate3).HasColumnType("datetime");

                entity.Property(e => e.RefDrDuration1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrDuration2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrDuration3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrId1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrId2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrId3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrStatus1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrStatus2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefDrStatus3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceId)
                    .HasColumnName("Reference Id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralDate).HasColumnType("datetime");

                entity.Property(e => e.ReferralDuration)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteDrId)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Select).HasDefaultValueSql("((0))");

                entity.Property(e => e.Select2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Select3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sex)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SocialHistory)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasDefaultValueSql("((0))");

                entity.Property(e => e.WebExport).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkPhone)
                    .HasColumnName("Work Phone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ZeroDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPermissionLevel>(entity =>
            {
                entity.HasKey(e => e.PermissionLvl);

                entity.ToTable("tblPermissionLevel");

                entity.Property(e => e.PermissionLvl)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPrevOp>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.PrevOpId });

                entity.ToTable("tblPrevOp");

                entity.Property(e => e.CreatedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedByUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LowestWeightAchieved).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LowestWeightAchievedActual).HasColumnName("LowestWeightAchieved_Actual");

                entity.Property(e => e.ModifiedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByWindowsUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalWeightActual).HasColumnName("OriginalWeight_Actual");

                entity.Property(e => e.PrevOpEvent)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrevOpSurgery)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblReferringDoctors>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.RefDrId });

                entity.ToTable("tblReferringDoctors");

                entity.Property(e => e.RefDrId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRegions>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.RegionId })
                    .HasName("PK_tblRegions_1");

                entity.ToTable("tblRegions");

                entity.Property(e => e.RegionId)
                    .HasColumnName("Region Id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasColumnName("Region Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblReportTemplates>(entity =>
            {
                entity.HasKey(e => new { e.ReportTemplateName, e.UserPracticeCode })
                    .HasName("PK_tblReportTemplates_1");

                entity.ToTable("tblReportTemplates");

                entity.Property(e => e.ReportTemplateName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.ToTable("tblRole");

                entity.HasIndex(e => e.RoleName)
                    .HasName("IX_tblRole")
                    .IsUnique();

                entity.Property(e => e.TblRoleId)
                    .HasColumnName("tblRoleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSrcsystemCode>(entity =>
            {
                entity.HasKey(e => e.SrcsystemCodeId);

                entity.ToTable("tblSRCSystemCode");

                entity.HasIndex(e => new { e.Category, e.LapbaseCode })
                    .HasName("IX_tblSRCSystemCode_1");

                entity.HasIndex(e => new { e.Category, e.Srccode })
                    .HasName("IX_tblSRCSystemCode");

                entity.Property(e => e.SrcsystemCodeId).HasColumnName("SRCSystemCodeID");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.LapbaseCode).HasMaxLength(10);

                entity.Property(e => e.Srccode)
                    .HasColumnName("SRCCode")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblSystemCodes>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.CategoryCode });

                entity.ToTable("tblSystemCodes");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BoldCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Score)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSystemCodesBold>(entity =>
            {
                entity.HasKey(e => new { e.BoldCode, e.CategoryCode });

                entity.ToTable("tblSystemCodes_BOLD");

                entity.Property(e => e.BoldCode).HasMaxLength(20);

                entity.Property(e => e.CategoryCode).HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RegistryDescription).HasMaxLength(255);

                entity.Property(e => e.Scode)
                    .HasColumnName("SCode")
                    .HasMaxLength(10);

                entity.Property(e => e.SrccomorBidityText)
                    .HasColumnName("SRCComorBidityText")
                    .HasMaxLength(100);

                entity.Property(e => e.SrccomorbidityCode)
                    .HasColumnName("SRCComorbidityCode")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TblSystemDetails>(entity =>
            {
                entity.HasKey(e => new { e.SystemId, e.UserPracticeCode });

                entity.ToTable("tblSystemDetails");

                entity.Property(e => e.SystemId).ValueGeneratedOnAdd();

                entity.Property(e => e.AutoSave).HasDefaultValueSql("((0))");

                entity.Property(e => e.BackUpLocation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ComordityVisitMonths).HasDefaultValueSql("((0))");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cv).HasColumnName("CV");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateInstalled).HasColumnType("datetime");

                entity.Property(e => e.EwperCent)
                    .HasColumnName("EWPerCent")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FacilityName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fu1).HasColumnName("FU1");

                entity.Property(e => e.Fu1y)
                    .HasColumnName("FU1Y")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Fu2).HasColumnName("FU2");

                entity.Property(e => e.Fu2y)
                    .HasColumnName("FU2Y")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Fu3).HasColumnName("FU3");

                entity.Property(e => e.Fu3y)
                    .HasColumnName("FU3Y")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Fu4y)
                    .HasColumnName("FU4Y")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Fucom)
                    .IsRequired()
                    .HasColumnName("FUCom")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fuinv)
                    .IsRequired()
                    .HasColumnName("FUinv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fupnotes)
                    .IsRequired()
                    .HasColumnName("FUPNotes")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdealOnBmi)
                    .IsRequired()
                    .HasColumnName("IdealOnBMI")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Imperial)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LetterheadMargin).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mfu12)
                    .HasColumnName("MFU12")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Mfu3)
                    .HasColumnName("MFU3")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Mfu6)
                    .HasColumnName("MFU6")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByComputer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUser)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatCom)
                    .IsRequired()
                    .HasColumnName("PatCOM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PatInv)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rd1).HasColumnName("RD1");

                entity.Property(e => e.Rd2).HasColumnName("RD2");

                entity.Property(e => e.ReferenceBmi)
                    .HasColumnName("ReferenceBMI")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SystemName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SystemType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TargetBmi)
                    .HasColumnName("TargetBMI")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Woscale)
                    .HasColumnName("WOScale")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSystemNormals>(entity =>
            {
                entity.HasKey(e => new { e.UserPracticeCode, e.Code });

                entity.ToTable("tblSystemNormals");

                entity.Property(e => e.Code).HasMaxLength(30);

                entity.Property(e => e.ConversionImpToMetric).HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ImperialHigh).HasMaxLength(50);

                entity.Property(e => e.ImperialHighF)
                    .HasColumnName("ImperialHigh_F")
                    .HasMaxLength(50);

                entity.Property(e => e.ImperialLow).HasMaxLength(5);

                entity.Property(e => e.ImperialLowF)
                    .HasColumnName("ImperialLow_F")
                    .HasMaxLength(5);

                entity.Property(e => e.ImperialUnits).HasMaxLength(5);

                entity.Property(e => e.MetricHigh).HasMaxLength(5);

                entity.Property(e => e.MetricHighF)
                    .HasColumnName("MetricHigh_F")
                    .HasMaxLength(5);

                entity.Property(e => e.MetricLow).HasMaxLength(5);

                entity.Property(e => e.MetricLowF)
                    .HasColumnName("MetricLow_F")
                    .HasMaxLength(5);

                entity.Property(e => e.MetricUnits).HasMaxLength(10);

                entity.Property(e => e.TestType).HasMaxLength(25);
            });

            modelBuilder.Entity<TblTempWeightLossReport>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.GroupByMonthNo, e.PatientId })
                    .HasName("PK_tblTempWeightLossReport_1");

                entity.ToTable("tblTempWeightLossReport");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.Bmi)
                    .HasColumnName("BMI")
                    .HasColumnType("decimal(10, 1)");

                entity.Property(e => e.CustomPatientId)
                    .HasColumnName("CustomPatientID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateSeen).HasColumnType("datetime");

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorNameTitle)
                    .HasColumnName("DoctorName_Title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ewlgroup025)
                    .HasColumnName("EWLGroup025")
                    .HasColumnType("decimal(10, 1)");

                entity.Property(e => e.Ewlgroup2550)
                    .HasColumnName("EWLGroup2550")
                    .HasColumnType("decimal(10, 1)");

                entity.Property(e => e.Ewlgroup5075)
                    .HasColumnName("EWLGroup5075")
                    .HasColumnType("decimal(10, 1)");

                entity.Property(e => e.Ewlgroup75100)
                    .HasColumnName("EWLGroup75100")
                    .HasColumnType("decimal(10, 1)");

                entity.Property(e => e.Ewll).HasColumnName("EWLL");

                entity.Property(e => e.HospitalName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalNameTitle)
                    .HasColumnName("HospitalName_Title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdealWeight).HasColumnType("decimal(10, 1)");

                entity.Property(e => e.InitBmi)
                    .HasColumnName("InitBMI")
                    .HasColumnType("decimal(10, 1)");

                entity.Property(e => e.InitFilApproach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InitFilBirthdate).HasColumnType("datetime");

                entity.Property(e => e.InitFilBmi).HasColumnName("InitFilBMI");

                entity.Property(e => e.InitFilCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InitFilGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InitFilHospitalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InitFilLapBandDate).HasColumnType("datetime");

                entity.Property(e => e.InitFilLapbandSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InitFilLapbandType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InitFilRegionId)
                    .HasColumnName("InitFilRegionID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InitFilSurgeryType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LapbandDate)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StartEw)
                    .HasColumnName("StartEW")
                    .HasColumnType("decimal(10, 1)");

                entity.Property(e => e.StartWeight).HasColumnType("decimal(10, 1)");

                entity.Property(e => e.StrEwll)
                    .HasColumnName("strEWLL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("decimal(10, 1)");

                entity.Property(e => e.WeightMeasurment)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserAccessPermission>(entity =>
            {
                entity.ToTable("tblUserAccessPermission");

                entity.Property(e => e.TblUserAccessPermissionId).HasColumnName("tblUserAccessPermissionID");

                entity.Property(e => e.TblAppschemaCode).HasColumnName("tblAPPSCHEMA_CODE");
            });

            modelBuilder.Entity<TblUserActivationCode>(entity =>
            {
                entity.ToTable("tblUserActivationCode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblUserApplicationData>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.UserPracticeCode });

                entity.ToTable("tblUserApplicationData");

                entity.Property(e => e.ComplicationId).HasColumnName("ComplicationID");

                entity.Property(e => e.CultureInfo).HasMaxLength(10);

                entity.Property(e => e.CunsultId).HasColumnName("CunsultID");

                entity.Property(e => e.Direction).HasMaxLength(3);

                entity.Property(e => e.LanguageCode).HasMaxLength(10);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblUserRole>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationCode, e.UserPracticeCode });

                entity.ToTable("tblUserRole");

                entity.Property(e => e.TblRoleId).HasColumnName("tblRoleID");

                entity.Property(e => e.TblUserRolesId)
                    .HasColumnName("tblUserRolesID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblUserTrust>(entity =>
            {
                entity.HasKey(e => new { e.TblUserTrustId, e.OrganizationCode });

                entity.ToTable("tblUserTrust");

                entity.Property(e => e.TblUserTrustId).HasColumnName("tblUserTrust_ID");

                entity.Property(e => e.Fdate)
                    .HasColumnName("FDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Tdate)
                    .HasColumnName("TDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrustUserPracticeCode).HasColumnName("Trust_UserPracticeCode");

                entity.Property(e => e.TrusteeUserPracticeCode).HasColumnName("Trustee_UserPracticeCode");
            });

            modelBuilder.Entity<TblUsers>(entity =>
            {
                entity.HasKey(e => e.UserPracticeCode);

                entity.ToTable("tblUSERS");

                entity.HasIndex(e => new { e.Userid, e.Userpw })
                    .HasName("IX_tblUSERS");

                entity.Property(e => e.ActivateDate).HasColumnType("datetime");

                entity.Property(e => e.CultureInfo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("LANGUAGE_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionFlag).HasColumnName("PERMISSION_FLAG");

                entity.Property(e => e.PermissionLevel)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('5n')");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SurgeonId).HasColumnName("SurgeonID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserSirname)
                    .IsRequired()
                    .HasColumnName("USER_SIRNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("USERID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Userpw)
                    .IsRequired()
                    .HasColumnName("USERPW")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblUsersPasswordsHistory>(entity =>
            {
                entity.ToTable("tblUsersPasswordsHistory");

                entity.Property(e => e.TblUsersPasswordsHistoryId).HasColumnName("tblUsersPasswordsHistory_ID");

                entity.Property(e => e.OldActivateDate).HasColumnType("datetime");

                entity.Property(e => e.OldPassword)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblUsysUserObjectLogs>(entity =>
            {
                entity.HasKey(e => e.TblUsysUserObjectLogsSno);

                entity.ToTable("tblUsysUserObjectLogs");

                entity.Property(e => e.TblUsysUserObjectLogsSno).HasColumnName("tblUsysUserObjectLogs_SNo");

                entity.Property(e => e.AccessUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActionName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OpenTime).HasColumnType("smalldatetime");

                entity.Property(e => e.SchemaCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SystemUsername)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVersionLog>(entity =>
            {
                entity.HasKey(e => e.Version);

                entity.ToTable("tblVersionLog");

                entity.Property(e => e.Version).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.ChangeLog)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.VersionNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
