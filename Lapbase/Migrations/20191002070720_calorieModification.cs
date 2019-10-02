using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class calorieModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "CaloryCount",
                table: "Exercise",
                newName: "CalorieCount");

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "CalorieCount", "Name", "PatientId", "pictureUrl" },
                values: new object[] { new Guid("315bb555-f469-4816-b105-33d845bd60f9"), 54, "PUSHUPS", 1, null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("432ff744-9776-4b54-9985-0708f9eeadd9"), 295, "Burger", "piece" },
                    { new Guid("6f184e1b-fbf9-4c20-a443-3c82ec9ac7f8"), 40, "Onion", "piece" },
                    { new Guid("0e4e3717-aa47-43f5-97c5-de05e8dd343b"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("57fdc1af-49c9-42a0-b631-8ebc63b7c681"), 96, "White bread", "slice" },
                    { new Guid("265f5795-d5c0-4c2c-9f2b-613afb79b4c5"), 44, "Apple", "apple" },
                    { new Guid("7c9fa00e-2c1d-40a5-8e86-c89667b68adb"), 107, "Banana", "banana" },
                    { new Guid("5e06a7c2-c381-473e-b4a8-2ccb3c261f14"), 30, "Tomato", "tomato" },
                    { new Guid("d1187683-c668-4205-8296-7a6c35929fb2"), 50, "Roti", "slice" },
                    { new Guid("87a76a2f-4d56-4d6a-a375-a1d761f79f56"), 40, "Rice", "cup" },
                    { new Guid("8abdab2c-c2a8-4826-aeeb-95234f70b5e4"), 600, "Halal Pork", "piece" },
                    { new Guid("e5efb226-6219-4adf-b319-f86ef9acf3cb"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("3e37e586-59a8-497c-a64c-fcdc9bebd0cc"), 300, "Meat Platter", "platter" },
                    { new Guid("168964e7-76ca-4f85-a1ee-d350c0b33020"), 350, "Mooncake", "mooncake" },
                    { new Guid("21153b2e-fffc-4e45-9938-70a28ab15aa2"), 400, "HSP", "box" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: new Guid("315bb555-f469-4816-b105-33d845bd60f9"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("0e4e3717-aa47-43f5-97c5-de05e8dd343b"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("168964e7-76ca-4f85-a1ee-d350c0b33020"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("21153b2e-fffc-4e45-9938-70a28ab15aa2"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("265f5795-d5c0-4c2c-9f2b-613afb79b4c5"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3e37e586-59a8-497c-a64c-fcdc9bebd0cc"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("432ff744-9776-4b54-9985-0708f9eeadd9"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("57fdc1af-49c9-42a0-b631-8ebc63b7c681"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("5e06a7c2-c381-473e-b4a8-2ccb3c261f14"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("6f184e1b-fbf9-4c20-a443-3c82ec9ac7f8"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("7c9fa00e-2c1d-40a5-8e86-c89667b68adb"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("87a76a2f-4d56-4d6a-a375-a1d761f79f56"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("8abdab2c-c2a8-4826-aeeb-95234f70b5e4"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("d1187683-c668-4205-8296-7a6c35929fb2"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("e5efb226-6219-4adf-b319-f86ef9acf3cb"));

            migrationBuilder.RenameColumn(
                name: "CalorieCount",
                table: "Exercise",
                newName: "CaloryCount");

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
    }
}
