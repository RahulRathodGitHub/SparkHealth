using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class Calories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("0f2d789a-8396-4f16-998e-572df3127bbe"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("1ab813e8-3422-45c0-874e-305f5fe98670"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("29288a5f-c974-4a26-b653-d7d6785e4704"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3a4a2766-e6e9-421e-b192-b2a228f44806"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3c170f21-8e83-4bd9-9f7f-13282c178d59"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("408141ce-5fc7-4d4d-9f45-0f175a84a649"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("f189b875-11de-407c-9785-8efa3e076f82"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: new Guid("3183825e-2297-43f8-9785-16ccdfbe1b0e"));

            migrationBuilder.AddColumn<decimal>(
                name: "Calories",
                table: "TaskInput",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "TaskInput",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("e5ebdf1c-1454-47cd-a4cf-a2e2aec1bb8d"), 295, "Burger", "piece" },
                    { new Guid("559b001e-4155-4b3d-bc5c-38d680f819e3"), 40, "Onion", "piece" },
                    { new Guid("563fd512-bcc0-4b41-95aa-9c5b0a7dc602"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("b6936473-3f91-4d92-b9b9-78974a7a898c"), 96, "White bread", "slice" },
                    { new Guid("5df631a6-33be-4244-918e-6c34bd03dcb3"), 44, "Apple", "apple" },
                    { new Guid("8201cc59-33be-4c29-9dc1-028bbaea79b3"), 107, "Banana", "banana" },
                    { new Guid("e53c6f1a-bbef-4b34-91ce-4627a91a23f1"), 30, "Tomato", "tomato" }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "AdvisorId", "PatientId", "Repetition", "RepetitionInterval", "StartDate", "Type" },
                values: new object[] { new Guid("46468ae6-5d81-4de2-a962-9595629d5b1e"), 1, 1, 1, 1, new DateTimeOffset(new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("559b001e-4155-4b3d-bc5c-38d680f819e3"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("563fd512-bcc0-4b41-95aa-9c5b0a7dc602"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("5df631a6-33be-4244-918e-6c34bd03dcb3"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("8201cc59-33be-4c29-9dc1-028bbaea79b3"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("b6936473-3f91-4d92-b9b9-78974a7a898c"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("e53c6f1a-bbef-4b34-91ce-4627a91a23f1"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("e5ebdf1c-1454-47cd-a4cf-a2e2aec1bb8d"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "Id",
                keyValue: new Guid("46468ae6-5d81-4de2-a962-9595629d5b1e"));

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "TaskInput");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "TaskInput");

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("29288a5f-c974-4a26-b653-d7d6785e4704"), 295, "Burger", "piece" },
                    { new Guid("1ab813e8-3422-45c0-874e-305f5fe98670"), 40, "Onion", "piece" },
                    { new Guid("0f2d789a-8396-4f16-998e-572df3127bbe"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("f189b875-11de-407c-9785-8efa3e076f82"), 96, "White bread", "slice" },
                    { new Guid("3c170f21-8e83-4bd9-9f7f-13282c178d59"), 44, "Apple", "apple" },
                    { new Guid("3a4a2766-e6e9-421e-b192-b2a228f44806"), 107, "Banana", "banana" },
                    { new Guid("408141ce-5fc7-4d4d-9f45-0f175a84a649"), 30, "Tomato", "tomato" }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "AdvisorId", "PatientId", "Repetition", "RepetitionInterval", "StartDate", "Type" },
                values: new object[] { new Guid("3183825e-2297-43f8-9785-16ccdfbe1b0e"), 1, 1, 1, 1, new DateTimeOffset(new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0 });
        }
    }
}
