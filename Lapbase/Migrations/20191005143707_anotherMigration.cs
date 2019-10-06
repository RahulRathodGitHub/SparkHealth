using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class anotherMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: new Guid("eb8e7cfd-d87c-4005-9c52-176a48f972c6"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("0154f740-8147-4163-b527-89c3e7e30c1a"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("0724bf6b-9041-4b94-a463-9aae413ffcb4"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("07f40eea-3aa3-44e4-ac7f-c185288eaca0"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("0d6302f6-44f9-4da1-a87c-7b35bbdee5f4"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("14392f57-02b8-4026-87fa-199cbad05089"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("215d4d02-f92c-4caa-94c5-19306a6e0ea9"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3b795e8f-66ac-44e0-8f3d-e43078c782f8"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("4a016a6d-cffa-4c3b-aa84-d2ea24eb0203"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("72a333c4-33d4-4bf4-b90b-a3c5aa32c04b"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("734a258f-37d4-426c-bcba-5e24df30f574"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("8eba859f-2daf-4648-b9b6-4d97106bf20c"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("de8b7c9c-c5cf-4461-9c44-6d8550f14048"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("e4787d32-33be-4b7d-8dad-72475d6bc8d6"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("ff722beb-6767-4e0c-806c-b258acc2b62d"));

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "CalorieCount", "Name", "pictureUrl" },
                values: new object[] { new Guid("442450db-0929-4644-ac35-3fd30aa9519c"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("c7c6e226-256a-44de-a3cc-87e1f4c90bcf"), 295, "Burger", "piece" },
                    { new Guid("00cd2239-90d7-4871-90b9-a4e92eb89549"), 40, "Onion", "piece" },
                    { new Guid("06e94734-a843-4fe7-9593-ca9e157e33c4"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("cfe5e754-0f7c-4722-b440-7acd5162ab8f"), 96, "White bread", "slice" },
                    { new Guid("7bbfde74-c358-4955-afe9-c8719e5272d7"), 44, "Apple", "apple" },
                    { new Guid("6363998d-42a2-44ae-93f0-fcffebd52bc4"), 107, "Banana", "banana" },
                    { new Guid("1a81b799-0144-4c2f-980b-d6c5b065669f"), 30, "Tomato", "tomato" },
                    { new Guid("d04234ba-9556-42ad-a4c4-6c22b4fac10a"), 50, "Roti", "slice" },
                    { new Guid("5d2f3d88-e202-451d-be2b-86bea95e183d"), 40, "Rice", "cup" },
                    { new Guid("8ec33129-e59c-44a5-80dc-95a401398d49"), 600, "Halal Pork", "piece" },
                    { new Guid("56a15732-5961-418a-930c-96afdfbcec93"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("6a05c726-1720-418a-939b-4a1c4f63181c"), 300, "Meat Platter", "platter" },
                    { new Guid("3048ff3e-4853-48d6-8c2f-6d76a3870923"), 350, "Mooncake", "mooncake" },
                    { new Guid("0951d9c8-7755-4bb9-8314-4b835c019f9e"), 400, "HSP", "box" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: new Guid("442450db-0929-4644-ac35-3fd30aa9519c"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("00cd2239-90d7-4871-90b9-a4e92eb89549"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("06e94734-a843-4fe7-9593-ca9e157e33c4"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("0951d9c8-7755-4bb9-8314-4b835c019f9e"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("1a81b799-0144-4c2f-980b-d6c5b065669f"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3048ff3e-4853-48d6-8c2f-6d76a3870923"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("56a15732-5961-418a-930c-96afdfbcec93"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("5d2f3d88-e202-451d-be2b-86bea95e183d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("6363998d-42a2-44ae-93f0-fcffebd52bc4"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("6a05c726-1720-418a-939b-4a1c4f63181c"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("7bbfde74-c358-4955-afe9-c8719e5272d7"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("8ec33129-e59c-44a5-80dc-95a401398d49"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("c7c6e226-256a-44de-a3cc-87e1f4c90bcf"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("cfe5e754-0f7c-4722-b440-7acd5162ab8f"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("d04234ba-9556-42ad-a4c4-6c22b4fac10a"));

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "CalorieCount", "Name", "pictureUrl" },
                values: new object[] { new Guid("eb8e7cfd-d87c-4005-9c52-176a48f972c6"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("ff722beb-6767-4e0c-806c-b258acc2b62d"), 295, "Burger", "piece" },
                    { new Guid("0154f740-8147-4163-b527-89c3e7e30c1a"), 40, "Onion", "piece" },
                    { new Guid("734a258f-37d4-426c-bcba-5e24df30f574"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("e4787d32-33be-4b7d-8dad-72475d6bc8d6"), 96, "White bread", "slice" },
                    { new Guid("4a016a6d-cffa-4c3b-aa84-d2ea24eb0203"), 44, "Apple", "apple" },
                    { new Guid("215d4d02-f92c-4caa-94c5-19306a6e0ea9"), 107, "Banana", "banana" },
                    { new Guid("8eba859f-2daf-4648-b9b6-4d97106bf20c"), 30, "Tomato", "tomato" },
                    { new Guid("72a333c4-33d4-4bf4-b90b-a3c5aa32c04b"), 50, "Roti", "slice" },
                    { new Guid("3b795e8f-66ac-44e0-8f3d-e43078c782f8"), 40, "Rice", "cup" },
                    { new Guid("de8b7c9c-c5cf-4461-9c44-6d8550f14048"), 600, "Halal Pork", "piece" },
                    { new Guid("07f40eea-3aa3-44e4-ac7f-c185288eaca0"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("0724bf6b-9041-4b94-a463-9aae413ffcb4"), 300, "Meat Platter", "platter" },
                    { new Guid("14392f57-02b8-4026-87fa-199cbad05089"), 350, "Mooncake", "mooncake" },
                    { new Guid("0d6302f6-44f9-4da1-a87c-7b35bbdee5f4"), 400, "HSP", "box" }
                });
        }
    }
}
