using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class hello2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: new Guid("f651cadf-8e87-4346-a514-febd02605643"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("007fdd8c-7c45-48c4-928e-9e7643b392f2"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("1d4b7f21-60ea-48ef-bc0d-f08af89c60d4"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("24c86afe-2d0e-4e43-b980-a4f543f62a5a"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("331752b9-6f93-44ee-9ba1-8f208330aee2"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3bc37f19-6036-4557-afe2-a11d60d889b1"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("54f904fc-5cbc-4c0a-ba3c-67c58f9db529"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("5c531430-6065-47d7-8edc-c5023b846974"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("64d3ea10-e572-4a34-9f0b-661e2c2237a1"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("74120f05-1578-4ec2-a496-97a7e34473de"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("8b4461a5-044e-4fe9-b8e7-4aadb1fe2c71"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("958caba3-c512-4e8c-8f29-8c8ff1579fe3"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("b2578026-c021-4c3f-8aa3-0cad833f9faa"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("c332456e-50f7-4035-b687-86300be929c2"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("eeaba5a7-5dba-477e-86a6-2949a8a66c5e"));

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "CalorieCount", "Name", "pictureUrl" },
                values: new object[] { new Guid("ed217a9d-25a0-456b-b382-cbbf5deeb54e"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("1ad625fc-b82f-4291-b154-406b234976e6"), 295, "Burger", "piece" },
                    { new Guid("48d17af9-637d-46b0-8c54-60ed50c30d84"), 40, "Onion", "piece" },
                    { new Guid("fcde9d58-c5c0-48dd-86a9-a1a02cc0a565"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("50110a6d-bb2f-4881-94a5-62e256d72893"), 96, "White bread", "slice" },
                    { new Guid("767a1c61-c486-4445-ac15-5a64732e1030"), 44, "Apple", "apple" },
                    { new Guid("28a1e531-16e1-46f8-9b7e-82dc6b4ddbad"), 107, "Banana", "banana" },
                    { new Guid("0605d79f-a2fa-42ae-8890-b6183f90881f"), 30, "Tomato", "tomato" },
                    { new Guid("1560ed77-0123-4dde-8e98-9c23a20f0bbc"), 50, "Roti", "slice" },
                    { new Guid("d2941061-92df-4dc4-9c4c-4bf260907ab8"), 40, "Rice", "cup" },
                    { new Guid("10ea8c10-adce-470e-84ec-8f2230615b69"), 600, "Halal Pork", "piece" },
                    { new Guid("e5997733-edd5-4554-b8fa-bf4e63391e8d"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("7bfd76e6-89e5-4b6d-85cf-0024be575c84"), 300, "Meat Platter", "platter" },
                    { new Guid("38fa83a7-a67d-4c22-b984-9198793eba8b"), 350, "Mooncake", "mooncake" },
                    { new Guid("ec1393db-a1e6-4da7-9695-2a4f70434084"), 400, "HSP", "box" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: new Guid("ed217a9d-25a0-456b-b382-cbbf5deeb54e"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("0605d79f-a2fa-42ae-8890-b6183f90881f"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("10ea8c10-adce-470e-84ec-8f2230615b69"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("1560ed77-0123-4dde-8e98-9c23a20f0bbc"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("1ad625fc-b82f-4291-b154-406b234976e6"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("28a1e531-16e1-46f8-9b7e-82dc6b4ddbad"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("38fa83a7-a67d-4c22-b984-9198793eba8b"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("48d17af9-637d-46b0-8c54-60ed50c30d84"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("50110a6d-bb2f-4881-94a5-62e256d72893"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("767a1c61-c486-4445-ac15-5a64732e1030"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("7bfd76e6-89e5-4b6d-85cf-0024be575c84"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("d2941061-92df-4dc4-9c4c-4bf260907ab8"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("e5997733-edd5-4554-b8fa-bf4e63391e8d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("ec1393db-a1e6-4da7-9695-2a4f70434084"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("fcde9d58-c5c0-48dd-86a9-a1a02cc0a565"));

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "CalorieCount", "Name", "pictureUrl" },
                values: new object[] { new Guid("f651cadf-8e87-4346-a514-febd02605643"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("007fdd8c-7c45-48c4-928e-9e7643b392f2"), 295, "Burger", "piece" },
                    { new Guid("958caba3-c512-4e8c-8f29-8c8ff1579fe3"), 40, "Onion", "piece" },
                    { new Guid("eeaba5a7-5dba-477e-86a6-2949a8a66c5e"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("1d4b7f21-60ea-48ef-bc0d-f08af89c60d4"), 96, "White bread", "slice" },
                    { new Guid("5c531430-6065-47d7-8edc-c5023b846974"), 44, "Apple", "apple" },
                    { new Guid("8b4461a5-044e-4fe9-b8e7-4aadb1fe2c71"), 107, "Banana", "banana" },
                    { new Guid("24c86afe-2d0e-4e43-b980-a4f543f62a5a"), 30, "Tomato", "tomato" },
                    { new Guid("c332456e-50f7-4035-b687-86300be929c2"), 50, "Roti", "slice" },
                    { new Guid("54f904fc-5cbc-4c0a-ba3c-67c58f9db529"), 40, "Rice", "cup" },
                    { new Guid("64d3ea10-e572-4a34-9f0b-661e2c2237a1"), 600, "Halal Pork", "piece" },
                    { new Guid("b2578026-c021-4c3f-8aa3-0cad833f9faa"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("331752b9-6f93-44ee-9ba1-8f208330aee2"), 300, "Meat Platter", "platter" },
                    { new Guid("3bc37f19-6036-4557-afe2-a11d60d889b1"), 350, "Mooncake", "mooncake" },
                    { new Guid("74120f05-1578-4ec2-a496-97a7e34473de"), 400, "HSP", "box" }
                });
        }
    }
}
