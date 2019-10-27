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
                table: "Exercise",
                columns: new[] { "Id", "CalorieCount", "Name", "pictureUrl" },
                values: new object[] { new Guid("3a913ad6-ef97-46fa-a8f1-e7fca79d7e85"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("dbbf5c2a-f196-422e-96e0-51d991f315e9"), 295, "Burger", "piece" },
                    { new Guid("e404ff6d-7e8d-4d71-8b3b-7e62c7e2b8ab"), 40, "Onion", "piece" },
                    { new Guid("09ba286a-2073-4e0c-8c43-aa4804c73c99"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("214b732e-3597-4042-af6e-b37fa063f121"), 96, "White bread", "slice" },
                    { new Guid("95987751-a24e-4475-8ed5-ae82469487a8"), 44, "Apple", "apple" },
                    { new Guid("e0d6cce6-7b40-4eda-ae9d-35dcd222baf6"), 107, "Banana", "banana" },
                    { new Guid("0b4a59e1-a74d-4372-9aa7-d9d840db89c4"), 30, "Tomato", "tomato" },
                    { new Guid("c6707ce0-9dce-4167-aae3-f72db5dd567d"), 50, "Roti", "slice" },
                    { new Guid("54d03758-b450-46d2-8421-dabde77db003"), 40, "Rice", "cup" },
                    { new Guid("449ba1c0-b2ea-4aa6-b001-34b966904533"), 600, "Halal Pork", "piece" },
                    { new Guid("7e824698-63ff-4743-ba45-8aecd5270c6b"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("395a9bff-9279-44bb-8170-7ec9b4fde192"), 300, "Meat Platter", "platter" },
                    { new Guid("d76bd3b3-7caf-4092-a1a4-753b6a2748c6"), 350, "Mooncake", "mooncake" },
                    { new Guid("2be9f841-c2db-4807-8110-6d698a21749c"), 400, "HSP", "box" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "AdvisorId", "Deleted", "Username", "ValidFrom", "ValidTo", "WhenCreated" },
                values: new object[] { 1, 1, false, "test@test.com", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

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
