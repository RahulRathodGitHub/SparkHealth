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
                    Calories = table.Column<decimal>(nullable: false),
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
                values: new object[] { new Guid("806985f7-3350-41ce-ba9f-d7405897e7b2"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("218947dc-0943-434a-ba62-c07451b22dd5"), 295, "Burger", "piece" },
                    { new Guid("3d33bf0d-c112-4d32-96bc-73c92ca8060b"), 40, "Onion", "piece" },
                    { new Guid("98eac67f-ef73-4a33-9404-1e863b780875"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("5a32e492-e2d3-4cf8-9359-837112cb1d95"), 96, "White bread", "slice" },
                    { new Guid("cd0274ea-3552-4b9e-ba57-313b6490836d"), 44, "Apple", "apple" },
                    { new Guid("5bf7fdbf-fc4d-4196-ae39-72b819b305fe"), 107, "Banana", "banana" },
                    { new Guid("353b57cb-827e-4644-8cc0-e42e3db38ab3"), 30, "Tomato", "tomato" },
                    { new Guid("1d21a5b2-0a1f-4045-a807-92027fd450d4"), 50, "Roti", "slice" },
                    { new Guid("d9a296f2-7e8a-457d-9da0-85e7d35012d0"), 40, "Rice", "cup" },
                    { new Guid("e5acb476-8bba-4278-b35e-20fa5b60e904"), 600, "Halal Pork", "piece" },
                    { new Guid("cf366673-7b3c-4c46-9f3e-7fe5ea598143"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("9c3c7f4c-6738-47e3-8c8a-f5c82a576082"), 300, "Meat Platter", "platter" },
                    { new Guid("7c6f60cc-c0d9-4208-be5e-535796f478da"), 350, "Mooncake", "mooncake" },
                    { new Guid("b6b7dad4-a4ca-4f53-bb4d-8aadb1d41e4a"), 400, "HSP", "box" }
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
