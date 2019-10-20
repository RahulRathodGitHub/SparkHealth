using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class argwegwgargergs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("bc32599d-f600-4c4e-a3b7-54fc260dd3be"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("3f35f3e6-2678-4813-bdb3-2c34549722ac"), 295, "Burger", "piece" },
                    { new Guid("487b5772-5707-4cb6-9212-0bf1a4bff41e"), 40, "Onion", "piece" },
                    { new Guid("342345dc-2ba7-4e4c-974f-754fcf846767"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("c23fe00e-599c-4c86-8f06-570e17aa50d2"), 96, "White bread", "slice" },
                    { new Guid("c43adabf-9589-4023-bfc4-4ee9e945830b"), 44, "Apple", "apple" },
                    { new Guid("23246296-20e2-4a21-892d-fbe116ae6fb8"), 107, "Banana", "banana" },
                    { new Guid("78c2749d-ae9d-441e-8d57-35b5dc6afaab"), 30, "Tomato", "tomato" },
                    { new Guid("b9ee9330-ef7a-4918-acd2-3e584af09389"), 50, "Roti", "slice" },
                    { new Guid("5f838700-3494-4d48-a73e-4105aea6e352"), 40, "Rice", "cup" },
                    { new Guid("7019619f-c149-4eda-a709-ff160d2bc8ad"), 600, "Halal Pork", "piece" },
                    { new Guid("59fc22d2-80cc-42b5-ba86-350f159c42cd"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("d1c0cacb-19ea-43ee-9b8b-0feece79daa8"), 300, "Meat Platter", "platter" },
                    { new Guid("3ff549a1-25f5-4781-bb60-4ebf225fe31d"), 350, "Mooncake", "mooncake" },
                    { new Guid("8ac9258a-52be-4593-bc12-b8dc11978cfc"), 400, "HSP", "box" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: new Guid("bc32599d-f600-4c4e-a3b7-54fc260dd3be"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("23246296-20e2-4a21-892d-fbe116ae6fb8"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("342345dc-2ba7-4e4c-974f-754fcf846767"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3f35f3e6-2678-4813-bdb3-2c34549722ac"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3ff549a1-25f5-4781-bb60-4ebf225fe31d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("487b5772-5707-4cb6-9212-0bf1a4bff41e"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("59fc22d2-80cc-42b5-ba86-350f159c42cd"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("5f838700-3494-4d48-a73e-4105aea6e352"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("7019619f-c149-4eda-a709-ff160d2bc8ad"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("78c2749d-ae9d-441e-8d57-35b5dc6afaab"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("8ac9258a-52be-4593-bc12-b8dc11978cfc"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("b9ee9330-ef7a-4918-acd2-3e584af09389"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("c23fe00e-599c-4c86-8f06-570e17aa50d2"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("c43adabf-9589-4023-bfc4-4ee9e945830b"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("d1c0cacb-19ea-43ee-9b8b-0feece79daa8"));

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
    }
}
