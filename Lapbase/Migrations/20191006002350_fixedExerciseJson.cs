using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class fixedExerciseJson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("62e034db-1c9a-4ecd-a34d-125c67dc968d"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("368bbff4-4838-4fe7-96b2-3d077c240ee5"), 295, "Burger", "piece" },
                    { new Guid("f4f114bc-2495-4ff9-b1f0-78e531b43c48"), 40, "Onion", "piece" },
                    { new Guid("448c911f-8c0e-42c3-95a6-fc658afca2ba"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("7a343486-a7ef-42d4-b88a-60480ef2b20b"), 96, "White bread", "slice" },
                    { new Guid("b59a24fb-db0b-44d0-a4ca-5dd66462199a"), 44, "Apple", "apple" },
                    { new Guid("010419a2-bc9e-4fb3-af98-75f37b47f476"), 107, "Banana", "banana" },
                    { new Guid("c8c60eb4-2aa9-40f0-acc8-c4952ac8009b"), 30, "Tomato", "tomato" },
                    { new Guid("99ec3177-055c-4a7c-a5d7-fd608fafcd2d"), 50, "Roti", "slice" },
                    { new Guid("58c699e3-2924-432f-9dc1-8b3515183314"), 40, "Rice", "cup" },
                    { new Guid("443e8b4d-f559-48f6-bfb3-da735a28baaf"), 600, "Halal Pork", "piece" },
                    { new Guid("e308d151-6f13-4241-958b-ffd492e8f0d5"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("81428753-3735-4e2e-9c04-00c098f3e2bf"), 300, "Meat Platter", "platter" },
                    { new Guid("4bef722d-0bb4-404d-b78c-8eda8976833e"), 350, "Mooncake", "mooncake" },
                    { new Guid("5b1cba13-078f-4797-933e-bb4bf166557f"), 400, "HSP", "box" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: new Guid("62e034db-1c9a-4ecd-a34d-125c67dc968d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("010419a2-bc9e-4fb3-af98-75f37b47f476"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("368bbff4-4838-4fe7-96b2-3d077c240ee5"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("443e8b4d-f559-48f6-bfb3-da735a28baaf"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("448c911f-8c0e-42c3-95a6-fc658afca2ba"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("4bef722d-0bb4-404d-b78c-8eda8976833e"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("58c699e3-2924-432f-9dc1-8b3515183314"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("5b1cba13-078f-4797-933e-bb4bf166557f"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("7a343486-a7ef-42d4-b88a-60480ef2b20b"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("81428753-3735-4e2e-9c04-00c098f3e2bf"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("99ec3177-055c-4a7c-a5d7-fd608fafcd2d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("b59a24fb-db0b-44d0-a4ca-5dd66462199a"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("c8c60eb4-2aa9-40f0-acc8-c4952ac8009b"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("e308d151-6f13-4241-958b-ffd492e8f0d5"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("f4f114bc-2495-4ff9-b1f0-78e531b43c48"));

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
    }
}
