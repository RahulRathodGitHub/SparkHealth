using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class helloEric : Migration
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
                values: new object[] { new Guid("740c6162-484c-4756-a1df-afa60735aa4e"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("61b17d04-54b5-4759-b0a1-eaac11d56c48"), 295, "Burger", "piece" },
                    { new Guid("dab648e9-9e4a-49a1-afec-aa42c07b2cb2"), 40, "Onion", "piece" },
                    { new Guid("be65a193-4c92-4f4b-9d73-d28832fa15df"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("3b32ed61-c978-4965-a788-f6bc21992936"), 96, "White bread", "slice" },
                    { new Guid("dd554f1c-d12b-428b-9ad5-a6dc046f8af4"), 44, "Apple", "apple" },
                    { new Guid("feabffdc-e7ac-48a2-b2d5-52a15490b4db"), 107, "Banana", "banana" },
                    { new Guid("ed3219ce-cbbf-48d4-8867-c3ed80ff1eb4"), 30, "Tomato", "tomato" },
                    { new Guid("05d99d2c-8459-4444-9056-37b9b77d3738"), 50, "Roti", "slice" },
                    { new Guid("7cf00dac-7c8b-4708-b7d3-99cc2bfddfea"), 40, "Rice", "cup" },
                    { new Guid("64bc4369-2c9f-4603-937a-4accd5f4d4ca"), 600, "Halal Pork", "piece" },
                    { new Guid("bea51681-2a74-47bb-982f-4d7f37c0a774"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("aec1179d-ea11-45f7-b370-18b270aa28c8"), 300, "Meat Platter", "platter" },
                    { new Guid("1e8bfa4e-74d4-4a3b-87e4-4999e684358e"), 350, "Mooncake", "mooncake" },
                    { new Guid("bf46235a-4371-41a6-ae8a-8a6f4ceda448"), 400, "HSP", "box" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: new Guid("740c6162-484c-4756-a1df-afa60735aa4e"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("05d99d2c-8459-4444-9056-37b9b77d3738"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("1e8bfa4e-74d4-4a3b-87e4-4999e684358e"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3b32ed61-c978-4965-a788-f6bc21992936"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("61b17d04-54b5-4759-b0a1-eaac11d56c48"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("64bc4369-2c9f-4603-937a-4accd5f4d4ca"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("7cf00dac-7c8b-4708-b7d3-99cc2bfddfea"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("aec1179d-ea11-45f7-b370-18b270aa28c8"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("be65a193-4c92-4f4b-9d73-d28832fa15df"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("bea51681-2a74-47bb-982f-4d7f37c0a774"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("bf46235a-4371-41a6-ae8a-8a6f4ceda448"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("dab648e9-9e4a-49a1-afec-aa42c07b2cb2"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("dd554f1c-d12b-428b-9ad5-a6dc046f8af4"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("ed3219ce-cbbf-48d4-8867-c3ed80ff1eb4"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("feabffdc-e7ac-48a2-b2d5-52a15490b4db"));

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
