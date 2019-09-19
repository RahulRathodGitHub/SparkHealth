using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class taskInputDto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_ExerciseList_ExerciseListId",
                table: "Exercise");

            migrationBuilder.DropTable(
                name: "ExerciseList");

            migrationBuilder.DropTable(
                name: "FoodIntakeList");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Exercise_ExerciseListId",
                table: "Exercise");

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("273f73c4-bbe7-43a4-aea6-f86dc9cbd210"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("27b7828b-a468-416f-9888-d223a3c5287e"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3a738593-6dfd-4d5b-9a6c-1dc1ef8b5d2e"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("6f92d220-04da-4c66-b1ed-272a2df7b498"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("90ef91fb-8dee-4c40-9043-138533944cbc"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("a53f8448-dc7b-496c-bdc2-da91ff93d74c"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("e4074654-a1b5-430d-b01f-0e8111097673"));

            migrationBuilder.DropColumn(
                name: "ExerciseListId",
                table: "Exercise");

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("f04fdf6d-9b20-416a-8575-876c00391b16"), 295, "Burger", "piece" },
                    { new Guid("cb1e718a-c27f-482e-8c5d-e3569bd7bcd9"), 40, "Onion", "piece" },
                    { new Guid("0f54e112-7548-40f7-ae15-523bd2915322"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("4869df53-99d4-4132-abe0-a31fb620613d"), 96, "White bread", "slice" },
                    { new Guid("1296c2c5-7684-45c4-ad74-b1a6258b70e2"), 44, "Apple", "apple" },
                    { new Guid("1c90b120-8c76-4665-91f5-0ebc63610f38"), 107, "Banana", "banana" },
                    { new Guid("4f923bd6-932f-44ad-8aae-90777512869d"), 30, "Tomato", "tomato" }
                });

            migrationBuilder.InsertData(
                table: "TaskInput",
                columns: new[] { "Id", "Calories", "Completed", "DateAssigned", "ExerciseReps", "Exercises", "FoodQuantities", "Foods", "IntakeTimes", "OrganizationCode", "PatientId", "Weight" },
                values: new object[] { new Guid("8531fc1f-a368-412b-9ad0-83d6544d55e6"), 100m, false, new DateTimeOffset(new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "1", "pushups", "1 2 1", "Onion Burger Apple", "Breakfast, Lunch, Dinner", 1, 1, 10m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("0f54e112-7548-40f7-ae15-523bd2915322"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("1296c2c5-7684-45c4-ad74-b1a6258b70e2"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("1c90b120-8c76-4665-91f5-0ebc63610f38"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("4869df53-99d4-4132-abe0-a31fb620613d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("4f923bd6-932f-44ad-8aae-90777512869d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("cb1e718a-c27f-482e-8c5d-e3569bd7bcd9"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("f04fdf6d-9b20-416a-8575-876c00391b16"));

            migrationBuilder.DeleteData(
                table: "TaskInput",
                keyColumn: "Id",
                keyValue: new Guid("8531fc1f-a368-412b-9ad0-83d6544d55e6"));

            migrationBuilder.AddColumn<Guid>(
                name: "ExerciseListId",
                table: "Exercise",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ExerciseList",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Reps = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodIntakeList",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Food = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    intakeTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodIntakeList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AdvisorId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false),
                    Repetition = table.Column<int>(nullable: false),
                    RepetitionInterval = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTimeOffset>(nullable: false),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Task_Advisor_AdvisorId",
                        column: x => x.AdvisorId,
                        principalTable: "Advisor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Task_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("90ef91fb-8dee-4c40-9043-138533944cbc"), 295, "Burger", "piece" },
                    { new Guid("27b7828b-a468-416f-9888-d223a3c5287e"), 40, "Onion", "piece" },
                    { new Guid("e4074654-a1b5-430d-b01f-0e8111097673"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("273f73c4-bbe7-43a4-aea6-f86dc9cbd210"), 96, "White bread", "slice" },
                    { new Guid("a53f8448-dc7b-496c-bdc2-da91ff93d74c"), 44, "Apple", "apple" },
                    { new Guid("6f92d220-04da-4c66-b1ed-272a2df7b498"), 107, "Banana", "banana" },
                    { new Guid("3a738593-6dfd-4d5b-9a6c-1dc1ef8b5d2e"), 30, "Tomato", "tomato" }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "AdvisorId", "PatientId", "Repetition", "RepetitionInterval", "StartDate", "Type" },
                values: new object[] { new Guid("eff5e281-8b22-4bee-b910-6b45f27e0d7d"), 1, 1, 1, 1, new DateTimeOffset(new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_ExerciseListId",
                table: "Exercise",
                column: "ExerciseListId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_AdvisorId",
                table: "Task",
                column: "AdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_PatientId",
                table: "Task",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_ExerciseList_ExerciseListId",
                table: "Exercise",
                column: "ExerciseListId",
                principalTable: "ExerciseList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
