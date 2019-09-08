using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class Weight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
