using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class taskinput : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_TaskInput_ExerciseListId",
                table: "Exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskInput_Task_TaskId",
                table: "TaskInput");

            migrationBuilder.DropIndex(
                name: "IX_TaskInput_TaskId",
                table: "TaskInput");

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("09fea5c9-e328-4e6a-85fa-8e2af924699d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("2577969d-93da-4a17-94bf-0b984855f7c9"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("66ab8883-68ec-434b-af05-66f2c2256245"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("6b6c9e33-3d86-44a2-b97d-c50c1cefbcab"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("7223eb94-fe59-4f62-b082-b216d5622b0f"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("7437ee36-e38f-4526-bf1a-78f2ba19436f"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("ba2a7b79-7fab-4bed-b22f-b2d0e5c47007"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: new Guid("ac2fbfe3-5557-4c52-95d6-a9f2655f9a36"));

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "TaskInput");

            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "TaskInput");

            migrationBuilder.RenameColumn(
                name: "DateEntered",
                table: "TaskInput",
                newName: "DateAssigned");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "TaskInput",
                newName: "IntakeTimes");

            migrationBuilder.RenameColumn(
                name: "Food",
                table: "TaskInput",
                newName: "Foods");

            migrationBuilder.RenameColumn(
                name: "Reps",
                table: "TaskInput",
                newName: "FoodQuantities");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "TaskInput",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Calories",
                table: "TaskInput",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "TaskInput",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ExerciseReps",
                table: "TaskInput",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Exercises",
                table: "TaskInput",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationCode",
                table: "TaskInput",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "TaskInput",
                nullable: false,
                defaultValue: 0);

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
                    intakeTime = table.Column<int>(nullable: false),
                    Food = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodIntakeList", x => x.Id);
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

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_ExerciseList_ExerciseListId",
                table: "Exercise",
                column: "ExerciseListId",
                principalTable: "ExerciseList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_ExerciseList_ExerciseListId",
                table: "Exercise");

            migrationBuilder.DropTable(
                name: "ExerciseList");

            migrationBuilder.DropTable(
                name: "FoodIntakeList");

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

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: new Guid("eff5e281-8b22-4bee-b910-6b45f27e0d7d"));

            migrationBuilder.DropColumn(
                name: "Completed",
                table: "TaskInput");

            migrationBuilder.DropColumn(
                name: "ExerciseReps",
                table: "TaskInput");

            migrationBuilder.DropColumn(
                name: "Exercises",
                table: "TaskInput");

            migrationBuilder.DropColumn(
                name: "OrganizationCode",
                table: "TaskInput");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "TaskInput");

            migrationBuilder.RenameColumn(
                name: "DateAssigned",
                table: "TaskInput",
                newName: "DateEntered");

            migrationBuilder.RenameColumn(
                name: "IntakeTimes",
                table: "TaskInput",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "Foods",
                table: "TaskInput",
                newName: "Food");

            migrationBuilder.RenameColumn(
                name: "FoodQuantities",
                table: "TaskInput",
                newName: "Reps");

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "TaskInput",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "Calories",
                table: "TaskInput",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "TaskInput",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "TaskId",
                table: "TaskInput",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("2577969d-93da-4a17-94bf-0b984855f7c9"), 295, "Burger", "piece" },
                    { new Guid("7223eb94-fe59-4f62-b082-b216d5622b0f"), 40, "Onion", "piece" },
                    { new Guid("6b6c9e33-3d86-44a2-b97d-c50c1cefbcab"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("09fea5c9-e328-4e6a-85fa-8e2af924699d"), 96, "White bread", "slice" },
                    { new Guid("7437ee36-e38f-4526-bf1a-78f2ba19436f"), 44, "Apple", "apple" },
                    { new Guid("ba2a7b79-7fab-4bed-b22f-b2d0e5c47007"), 107, "Banana", "banana" },
                    { new Guid("66ab8883-68ec-434b-af05-66f2c2256245"), 30, "Tomato", "tomato" }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "AdvisorId", "PatientId", "Repetition", "RepetitionInterval", "StartDate", "Type" },
                values: new object[] { new Guid("ac2fbfe3-5557-4c52-95d6-a9f2655f9a36"), 1, 1, 1, 1, new DateTimeOffset(new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0 });

            migrationBuilder.CreateIndex(
                name: "IX_TaskInput_TaskId",
                table: "TaskInput",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_TaskInput_ExerciseListId",
                table: "Exercise",
                column: "ExerciseListId",
                principalTable: "TaskInput",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskInput_Task_TaskId",
                table: "TaskInput",
                column: "TaskId",
                principalTable: "Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
