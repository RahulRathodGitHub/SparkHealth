using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CalorieCount = table.Column<int>(nullable: false),
                    pictureUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CalorieCount = table.Column<int>(nullable: false),
                    Unit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    WhenCreated = table.Column<DateTimeOffset>(nullable: false),
                    ValidFrom = table.Column<DateTimeOffset>(nullable: false),
                    ValidTo = table.Column<DateTimeOffset>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    PatientCode = table.Column<int>(nullable: false),
                    OrganisationCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskInput",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PatientId = table.Column<int>(nullable: false),
                    OrganizationCode = table.Column<int>(nullable: false),
                    DateAssigned = table.Column<DateTimeOffset>(nullable: false),
                    Completed = table.Column<bool>(nullable: false),
                    CaloriesGained = table.Column<decimal>(nullable: false),
                    CaloriesLost = table.Column<decimal>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    Foods = table.Column<string>(nullable: true),
                    FoodQuantities = table.Column<string>(nullable: true),
                    MealTimes = table.Column<string>(nullable: true),
                    Exercises = table.Column<string>(nullable: true),
                    ExerciseReps = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskInput", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTimeOffset>(nullable: false),
                    content = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedback_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "CalorieCount", "Name", "pictureUrl" },
                values: new object[] { new Guid("942f4c92-4b34-4ee4-bd29-572a550c3496"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("9e35c9ea-6c17-4f0a-8256-a4c23ba9d87b"), 295, "Burger", "piece" },
                    { new Guid("b13c3e1c-e8d6-4982-a321-34276bf3d3ea"), 40, "Onion", "piece" },
                    { new Guid("96d5e6d4-0d90-48b6-9b58-e5144fc44ac2"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("32360a6f-3ca2-4d9a-b1aa-ba8742332241"), 96, "White bread", "slice" },
                    { new Guid("71626fab-e107-40d0-8ce1-50f49bd4f0e3"), 44, "Apple", "apple" },
                    { new Guid("666b24da-5d12-4121-9e16-8fa1fbfaeac1"), 107, "Banana", "banana" },
                    { new Guid("3182ac0b-f6db-4206-aefc-cb46d01900c8"), 30, "Tomato", "tomato" },
                    { new Guid("abdd086b-1648-415c-9299-12b881c46e48"), 50, "Roti", "slice" },
                    { new Guid("cc1a64ec-952f-4c5f-85af-8476cf1fe13d"), 40, "Rice", "cup" },
                    { new Guid("ae00c3bc-72b6-4249-b89e-93397777aac6"), 600, "Halal Pork", "piece" },
                    { new Guid("a79ff234-6ae7-4a76-8097-315f1bbb4a3d"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("70b97884-f185-4845-90ea-12267c2bf35c"), 300, "Meat Platter", "platter" },
                    { new Guid("a72d995f-72a3-4ba5-bb1c-fb75a538cbbb"), 350, "Mooncake", "mooncake" },
                    { new Guid("afcd9845-71ea-4982-b5ef-c2a3842cdb4e"), 400, "HSP", "box" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "Deleted", "OrganisationCode", "PatientCode", "Username", "ValidFrom", "ValidTo", "WhenCreated" },
                values: new object[] { 1, false, 1, 2756, "Test@SparkHealthhotmailcom.onmicrosoft.com", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_PatientId",
                table: "Feedback",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "TaskInput");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
