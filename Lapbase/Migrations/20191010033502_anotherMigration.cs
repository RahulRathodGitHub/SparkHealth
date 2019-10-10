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
                keyValue: new Guid("3f3db903-5655-4b5d-ae23-64bf3369a155"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("08122b58-e4fa-4fa8-a982-0e780ebe4c59"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("34e490ba-acc4-47c1-a069-9c2b2724b053"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3fc5642d-d999-41ff-acbd-ad102e30ae26"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("66893ca4-af0f-4eb1-a23e-254f85464c51"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("696e4918-5fba-4a56-a6a5-c608bb0e0acf"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("743f9085-c95a-4a1f-99bf-c6903efbddd5"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("7b5b5f8f-46fa-41ef-9685-1ea304f0b302"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("95fcdc9e-5e5f-4c4f-9fb4-115885ba5fcc"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("a17e65c4-f58d-4df4-afcb-42b22cfbad8f"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("b9da34d8-8755-452b-96ae-2a4664e3b994"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("ca83dcb6-dcdd-4d00-8d2a-c74783901e33"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("e0cf031d-55d8-4a2f-8ccc-c4a1b99da1fb"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("e7a4827d-4bb9-488c-969e-ec97be0884c2"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("e88d8e1b-0b2f-4595-ac8f-bf0325284771"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("3f3db903-5655-4b5d-ae23-64bf3369a155"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("ca83dcb6-dcdd-4d00-8d2a-c74783901e33"), 295, "Burger", "piece" },
                    { new Guid("3fc5642d-d999-41ff-acbd-ad102e30ae26"), 40, "Onion", "piece" },
                    { new Guid("b9da34d8-8755-452b-96ae-2a4664e3b994"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("08122b58-e4fa-4fa8-a982-0e780ebe4c59"), 96, "White bread", "slice" },
                    { new Guid("7b5b5f8f-46fa-41ef-9685-1ea304f0b302"), 44, "Apple", "apple" },
                    { new Guid("e7a4827d-4bb9-488c-969e-ec97be0884c2"), 107, "Banana", "banana" },
                    { new Guid("34e490ba-acc4-47c1-a069-9c2b2724b053"), 30, "Tomato", "tomato" },
                    { new Guid("e88d8e1b-0b2f-4595-ac8f-bf0325284771"), 50, "Roti", "slice" },
                    { new Guid("e0cf031d-55d8-4a2f-8ccc-c4a1b99da1fb"), 40, "Rice", "cup" },
                    { new Guid("696e4918-5fba-4a56-a6a5-c608bb0e0acf"), 600, "Halal Pork", "piece" },
                    { new Guid("95fcdc9e-5e5f-4c4f-9fb4-115885ba5fcc"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("743f9085-c95a-4a1f-99bf-c6903efbddd5"), 300, "Meat Platter", "platter" },
                    { new Guid("a17e65c4-f58d-4df4-afcb-42b22cfbad8f"), 350, "Mooncake", "mooncake" },
                    { new Guid("66893ca4-af0f-4eb1-a23e-254f85464c51"), 400, "HSP", "box" }
                });
        }
    }
}
