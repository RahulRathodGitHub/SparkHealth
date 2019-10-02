using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("186e3000-a371-42eb-8f47-2dad8b20ecde"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("2f51dc3a-4571-4f75-b4be-cd15ce67c582"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("443033cd-20c4-4869-b226-458afef8eef7"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("44395ef4-4671-43e0-b71f-e41432df3b97"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("561677db-3df7-4630-8f1a-6ffb432a917f"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("73a6ce3d-8e73-4e1c-b060-29612c892d5c"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("81536904-8b8d-4ea2-93fd-76e7e34e1609"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("aa1d7a08-2cd2-4f03-a7c1-0283f5f8186d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("b5d4c175-c662-410d-b375-255539f1569e"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("bb77c1e9-38de-4874-a44f-b0b84204e59a"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("c569a633-cb7d-43e3-a6f9-51be52457a9a"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("d5e81b3a-77a6-4b9e-9b89-06a2914c1c29"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("fafe0675-44b4-4849-a8aa-79cf2f53cc38"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("fe5c5f6f-220c-4a61-bb22-f76b6c3d4f0d"));

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "CaloryCount", "Name", "PatientId", "pictureUrl" },
                values: new object[] { new Guid("9444292c-91d7-482c-8465-b2a4064e5300"), 54, "PUSHUPS", 1, null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("bc4a096a-c6ff-45d1-8841-2f09354bdace"), 295, "Burger", "piece" },
                    { new Guid("c4930c3f-7681-462d-be95-9b2ae82b3d96"), 40, "Onion", "piece" },
                    { new Guid("33038a76-2d1c-4462-8055-ce4043df54b1"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("a8993d38-f959-44c9-872b-770140e33e34"), 96, "White bread", "slice" },
                    { new Guid("abba6485-2fab-4f59-9170-eed977a68244"), 44, "Apple", "apple" },
                    { new Guid("b37f3d75-fc77-4e10-b525-25c92eb4c888"), 107, "Banana", "banana" },
                    { new Guid("f24c56db-dbef-4314-b150-57a8a8b92bc5"), 30, "Tomato", "tomato" },
                    { new Guid("f9c7f6e2-58b0-4952-b86a-aac1b220489b"), 50, "Roti", "slice" },
                    { new Guid("566bcc7a-5e2f-429f-a582-a0edd5fb8578"), 40, "Rice", "cup" },
                    { new Guid("7a7b2496-88e1-4d93-84d0-a9929098f130"), 600, "Halal Pork", "piece" },
                    { new Guid("818f9de1-e16b-4ca8-afd1-d82d602744e5"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("ca0b4282-22cf-49f9-b8e5-201585b8d3b7"), 300, "Meat Platter", "platter" },
                    { new Guid("cab7aafc-b7a5-436b-bfc2-190bc8269c91"), 350, "Mooncake", "mooncake" },
                    { new Guid("e8595646-c951-45ac-94d2-196a4108929d"), 400, "HSP", "box" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: new Guid("9444292c-91d7-482c-8465-b2a4064e5300"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("33038a76-2d1c-4462-8055-ce4043df54b1"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("566bcc7a-5e2f-429f-a582-a0edd5fb8578"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("7a7b2496-88e1-4d93-84d0-a9929098f130"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("818f9de1-e16b-4ca8-afd1-d82d602744e5"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("a8993d38-f959-44c9-872b-770140e33e34"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("abba6485-2fab-4f59-9170-eed977a68244"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("b37f3d75-fc77-4e10-b525-25c92eb4c888"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("bc4a096a-c6ff-45d1-8841-2f09354bdace"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("c4930c3f-7681-462d-be95-9b2ae82b3d96"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("ca0b4282-22cf-49f9-b8e5-201585b8d3b7"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("cab7aafc-b7a5-436b-bfc2-190bc8269c91"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("e8595646-c951-45ac-94d2-196a4108929d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("f24c56db-dbef-4314-b150-57a8a8b92bc5"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("f9c7f6e2-58b0-4952-b86a-aac1b220489b"));

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("561677db-3df7-4630-8f1a-6ffb432a917f"), 295, "Burger", "piece" },
                    { new Guid("443033cd-20c4-4869-b226-458afef8eef7"), 40, "Onion", "piece" },
                    { new Guid("fe5c5f6f-220c-4a61-bb22-f76b6c3d4f0d"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("73a6ce3d-8e73-4e1c-b060-29612c892d5c"), 96, "White bread", "slice" },
                    { new Guid("c569a633-cb7d-43e3-a6f9-51be52457a9a"), 44, "Apple", "apple" },
                    { new Guid("81536904-8b8d-4ea2-93fd-76e7e34e1609"), 107, "Banana", "banana" },
                    { new Guid("bb77c1e9-38de-4874-a44f-b0b84204e59a"), 30, "Tomato", "tomato" },
                    { new Guid("186e3000-a371-42eb-8f47-2dad8b20ecde"), 50, "Roti", "slice" },
                    { new Guid("44395ef4-4671-43e0-b71f-e41432df3b97"), 40, "Rice", "cup" },
                    { new Guid("aa1d7a08-2cd2-4f03-a7c1-0283f5f8186d"), 600, "Halal Pork", "piece" },
                    { new Guid("b5d4c175-c662-410d-b375-255539f1569e"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("2f51dc3a-4571-4f75-b4be-cd15ce67c582"), 300, "Meat Platter", "platter" },
                    { new Guid("d5e81b3a-77a6-4b9e-9b89-06a2914c1c29"), 350, "Mooncake", "mooncake" },
                    { new Guid("fafe0675-44b4-4849-a8aa-79cf2f53cc38"), 400, "HSP", "box" }
                });
        }
    }
}
