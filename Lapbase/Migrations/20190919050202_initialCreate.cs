using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advisor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advisor", x => x.Id);
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
                name: "TaskInput",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PatientId = table.Column<int>(nullable: false),
                    OrganizationCode = table.Column<int>(nullable: false),
                    DateAssigned = table.Column<DateTimeOffset>(nullable: false),
                    Completed = table.Column<bool>(nullable: false),
                    Calories = table.Column<decimal>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    Foods = table.Column<string>(nullable: true),
                    FoodQuantities = table.Column<string>(nullable: true),
                    IntakeTimes = table.Column<string>(nullable: true),
                    Exercises = table.Column<string>(nullable: true),
                    ExerciseReps = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskInput", x => x.Id);
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
                    AdvisorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_Advisor_AdvisorId",
                        column: x => x.AdvisorId,
                        principalTable: "Advisor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CaloryCount = table.Column<int>(nullable: false),
                    pictureUrl = table.Column<string>(nullable: true),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercise_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                table: "Advisor",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("45d4586c-bd7c-47bc-9720-f06bba786f69"), 295, "Burger", "piece" },
                    { new Guid("43040b2b-53cb-40d6-ac1b-0651a95bbec1"), 40, "Onion", "piece" },
                    { new Guid("76fc7bdf-a8fe-4a0b-8841-b0dc6dd4f1bb"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("f5cd503d-3726-4053-825d-d82927248895"), 96, "White bread", "slice" },
                    { new Guid("7d69206a-d14a-4460-b7ca-c33f5509d929"), 44, "Apple", "apple" },
                    { new Guid("047d3d9b-5593-44d2-9613-1e17ccbaf0d6"), 107, "Banana", "banana" },
                    { new Guid("1afd0ed8-ce45-49e0-b812-aeebf9dca32a"), 30, "Tomato", "tomato" }
                });

            migrationBuilder.InsertData(
                table: "TaskInput",
                columns: new[] { "Id", "Calories", "Completed", "DateAssigned", "ExerciseReps", "Exercises", "FoodQuantities", "Foods", "IntakeTimes", "OrganizationCode", "PatientId", "Weight" },
                values: new object[] { new Guid("09cecf0d-fb22-4618-870b-a14af771a3a6"), 100m, false, new DateTimeOffset(new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "pushups", "1 2 1", "Onion Burger Apple", "Breakfast, Lunch, Dinner", 1, 1, 10m });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "AdvisorId", "Deleted", "Username", "ValidFrom", "ValidTo", "WhenCreated" },
                values: new object[] { 1, 1, false, "test@test.com", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_PatientId",
                table: "Exercise",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_PatientId",
                table: "Feedback",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_AdvisorId",
                table: "Patient",
                column: "AdvisorId");
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

            migrationBuilder.DropTable(
                name: "Advisor");
        }
    }
}
