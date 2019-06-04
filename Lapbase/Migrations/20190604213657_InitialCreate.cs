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

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTimeOffset>(nullable: false),
                    Repetition = table.Column<int>(nullable: false),
                    RepetitionInterval = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false),
                    AdvisorId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "TaskInput",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateEntered = table.Column<DateTimeOffset>(nullable: false),
                    TaskId = table.Column<Guid>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Reps = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskInput", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskInput_Task_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Task",
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
                    PatientId = table.Column<int>(nullable: false),
                    ExerciseListId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercise_TaskInput_ExerciseListId",
                        column: x => x.ExerciseListId,
                        principalTable: "TaskInput",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exercise_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CalorieCount = table.Column<int>(nullable: false),
                    Unit = table.Column<string>(nullable: true),
                    PatientId = table.Column<int>(nullable: false),
                    FoodIntakeListId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Food_TaskInput_FoodIntakeListId",
                        column: x => x.FoodIntakeListId,
                        principalTable: "TaskInput",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Food_Patient_PatientId",
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
                table: "Patient",
                columns: new[] { "Id", "AdvisorId", "Deleted", "Username", "ValidFrom", "ValidTo", "WhenCreated" },
                values: new object[] { 1, 1, false, "test@test.com", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "AdvisorId", "PatientId", "Repetition", "RepetitionInterval", "StartDate", "Type" },
                values: new object[] { new Guid("ecfeca5b-b7f3-41a9-ae4d-8e9504f91857"), 1, 1, 1, 1, new DateTimeOffset(new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_ExerciseListId",
                table: "Exercise",
                column: "ExerciseListId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_PatientId",
                table: "Exercise",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_PatientId",
                table: "Feedback",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Food_FoodIntakeListId",
                table: "Food",
                column: "FoodIntakeListId");

            migrationBuilder.CreateIndex(
                name: "IX_Food_PatientId",
                table: "Food",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_AdvisorId",
                table: "Patient",
                column: "AdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_AdvisorId",
                table: "Task",
                column: "AdvisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_PatientId",
                table: "Task",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskInput_TaskId",
                table: "TaskInput",
                column: "TaskId");
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
                name: "Task");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Advisor");
        }
    }
}
