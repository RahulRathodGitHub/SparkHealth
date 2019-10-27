using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class hello : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: new Guid("b0df17c2-2ef5-46c9-9bae-231729334886"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("08e983e2-0079-4d8e-94b0-9416ea9115e9"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("370ecb7d-5f28-4d69-bc93-2aa876d46c4f"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("39e0f3aa-ba45-457a-beed-e811b397d873"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3f28f7ce-a588-47c8-b597-79a434dd5833"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("474bfbc4-fd9b-48ea-b555-1425c6f1df63"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("522117f0-1a4d-409b-baa4-ed96442bae8c"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("68f9136d-544b-422d-b4f0-8b09d3bd32d7"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("723fdb04-8cc1-4f00-898c-c8c62fd75d7e"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("b27d8053-28c0-46b6-92e6-11209dc2a726"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("bb3b789c-91f9-42ea-8c67-3bb4e318a148"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("bb5a4788-6fe6-418e-8a71-6b395b9dc1ac"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("d8bab3e4-9eab-4348-9903-186dfd221e68"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("ff0236eb-9a0e-495a-9168-38937832724d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("ff02503f-5d7e-44c3-8223-4a7f3eb73dc3"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("b0df17c2-2ef5-46c9-9bae-231729334886"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("08e983e2-0079-4d8e-94b0-9416ea9115e9"), 295, "Burger", "piece" },
                    { new Guid("bb3b789c-91f9-42ea-8c67-3bb4e318a148"), 40, "Onion", "piece" },
                    { new Guid("3f28f7ce-a588-47c8-b597-79a434dd5833"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("723fdb04-8cc1-4f00-898c-c8c62fd75d7e"), 96, "White bread", "slice" },
                    { new Guid("474bfbc4-fd9b-48ea-b555-1425c6f1df63"), 44, "Apple", "apple" },
                    { new Guid("d8bab3e4-9eab-4348-9903-186dfd221e68"), 107, "Banana", "banana" },
                    { new Guid("ff02503f-5d7e-44c3-8223-4a7f3eb73dc3"), 30, "Tomato", "tomato" },
                    { new Guid("370ecb7d-5f28-4d69-bc93-2aa876d46c4f"), 50, "Roti", "slice" },
                    { new Guid("ff0236eb-9a0e-495a-9168-38937832724d"), 40, "Rice", "cup" },
                    { new Guid("68f9136d-544b-422d-b4f0-8b09d3bd32d7"), 600, "Halal Pork", "piece" },
                    { new Guid("39e0f3aa-ba45-457a-beed-e811b397d873"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("b27d8053-28c0-46b6-92e6-11209dc2a726"), 300, "Meat Platter", "platter" },
                    { new Guid("bb5a4788-6fe6-418e-8a71-6b395b9dc1ac"), 350, "Mooncake", "mooncake" },
                    { new Guid("522117f0-1a4d-409b-baa4-ed96442bae8c"), 400, "HSP", "box" }
                });
        }
    }
}
