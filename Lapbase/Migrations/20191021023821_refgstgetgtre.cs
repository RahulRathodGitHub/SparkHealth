using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class refgstgetgtre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("886a3747-c1da-474d-8a94-4f0a285c019a"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("52319486-3481-4591-b7cc-5b630ab321a3"), 295, "Burger", "piece" },
                    { new Guid("a4de84bb-dc77-4462-bf03-ec93992ef9de"), 40, "Onion", "piece" },
                    { new Guid("3cc5b1ab-7753-4234-bd6c-73087387a63e"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("540915e2-3f4d-436b-ae5c-7dc6c2be7f32"), 96, "White bread", "slice" },
                    { new Guid("55a002a7-b4bf-4b83-b8ab-b0c28e62e545"), 44, "Apple", "apple" },
                    { new Guid("34e5fa59-c6d5-48d3-86ed-cfc0ffd6bdfc"), 107, "Banana", "banana" },
                    { new Guid("5e3bc61a-a4ca-45f6-8268-35674cdca1d5"), 30, "Tomato", "tomato" },
                    { new Guid("c29c8b5d-25b7-48cc-b249-5082b97cb87a"), 50, "Roti", "slice" },
                    { new Guid("319ce7d3-b52b-4784-96be-9d51442d3d82"), 40, "Rice", "cup" },
                    { new Guid("3a31f91c-182c-4abb-9c98-6b51db3e1a6d"), 600, "Halal Pork", "piece" },
                    { new Guid("01dd60b0-330d-4d65-a468-845183e84b2a"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("d63a1b25-edfa-487c-abb1-db7601948bd6"), 300, "Meat Platter", "platter" },
                    { new Guid("b4363f25-695d-4417-bedf-b8dd71a87a4f"), 350, "Mooncake", "mooncake" },
                    { new Guid("ae6cac3d-8825-4ac9-9f5a-1c7f3de95725"), 400, "HSP", "box" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: new Guid("886a3747-c1da-474d-8a94-4f0a285c019a"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("01dd60b0-330d-4d65-a468-845183e84b2a"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("319ce7d3-b52b-4784-96be-9d51442d3d82"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("34e5fa59-c6d5-48d3-86ed-cfc0ffd6bdfc"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3a31f91c-182c-4abb-9c98-6b51db3e1a6d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3cc5b1ab-7753-4234-bd6c-73087387a63e"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("52319486-3481-4591-b7cc-5b630ab321a3"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("540915e2-3f4d-436b-ae5c-7dc6c2be7f32"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("55a002a7-b4bf-4b83-b8ab-b0c28e62e545"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("5e3bc61a-a4ca-45f6-8268-35674cdca1d5"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("a4de84bb-dc77-4462-bf03-ec93992ef9de"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("ae6cac3d-8825-4ac9-9f5a-1c7f3de95725"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("b4363f25-695d-4417-bedf-b8dd71a87a4f"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("c29c8b5d-25b7-48cc-b249-5082b97cb87a"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("d63a1b25-edfa-487c-abb1-db7601948bd6"));

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
    }
}
