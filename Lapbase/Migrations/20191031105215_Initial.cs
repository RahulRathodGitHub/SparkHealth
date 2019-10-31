using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class Initial : Migration
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
                values: new object[] { new Guid("e0eb0e85-86c3-4dd0-a5ac-1720b3567d3e"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("224714ed-535f-48ff-a600-443728337842"), 295, "Burger", "piece" },
                    { new Guid("8c53e9d7-35de-4fa9-a028-e6acee4cc1f4"), 40, "Onion", "piece" },
                    { new Guid("9a318bcf-7d1e-42ce-83ad-b3f3a466dd38"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("6219da55-c3df-4f63-b516-6e361de844aa"), 96, "White bread", "slice" },
                    { new Guid("bbafc491-064e-4359-87ec-d29305e2496c"), 44, "Apple", "apple" },
                    { new Guid("a6e94c5b-e33b-4d26-8995-ed7cffe5ceac"), 107, "Banana", "banana" },
                    { new Guid("a27329b4-5615-43c1-845c-7b04e8f1a81a"), 30, "Tomato", "tomato" },
                    { new Guid("28d7c9f0-20f1-4a59-8502-7e183cb4194c"), 50, "Roti", "slice" },
                    { new Guid("b1810de1-7b44-4118-91f4-e912d98e0aaa"), 40, "Rice", "cup" },
                    { new Guid("c5f3bc2f-85f4-48d4-90c0-a537e7ff0522"), 600, "Halal Pork", "piece" },
                    { new Guid("10c613e8-fb51-43d1-8d7f-ef73f19e42da"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("8bd9d2d0-9902-4219-8d9e-16e38bbee07f"), 300, "Meat Platter", "platter" },
                    { new Guid("190c9565-8a77-4e26-9cbc-df919f75688f"), 350, "Mooncake", "mooncake" },
                    { new Guid("ad6aa00a-e643-45f5-b919-05e8ddbee7f2"), 400, "HSP", "box" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "Deleted", "OrganisationCode", "PatientCode", "Username", "ValidFrom", "ValidTo", "WhenCreated" },
                values: new object[] { 1, false, 2, 2756, "Test@SparkHealthhotmailcom.onmicrosoft.com", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

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
