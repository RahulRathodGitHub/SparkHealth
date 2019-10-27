using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class calorieLostAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: new Guid("806985f7-3350-41ce-ba9f-d7405897e7b2"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("1d21a5b2-0a1f-4045-a807-92027fd450d4"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("218947dc-0943-434a-ba62-c07451b22dd5"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("353b57cb-827e-4644-8cc0-e42e3db38ab3"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3d33bf0d-c112-4d32-96bc-73c92ca8060b"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("5a32e492-e2d3-4cf8-9359-837112cb1d95"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("5bf7fdbf-fc4d-4196-ae39-72b819b305fe"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("7c6f60cc-c0d9-4208-be5e-535796f478da"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("98eac67f-ef73-4a33-9404-1e863b780875"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("9c3c7f4c-6738-47e3-8c8a-f5c82a576082"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("b6b7dad4-a4ca-4f53-bb4d-8aadb1d41e4a"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("cd0274ea-3552-4b9e-ba57-313b6490836d"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("cf366673-7b3c-4c46-9f3e-7fe5ea598143"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("d9a296f2-7e8a-457d-9da0-85e7d35012d0"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("e5acb476-8bba-4278-b35e-20fa5b60e904"));

            migrationBuilder.RenameColumn(
                name: "Calories",
                table: "TaskInput",
                newName: "CaloriesLost");

            migrationBuilder.AddColumn<decimal>(
                name: "CaloriesGained",
                table: "TaskInput",
                nullable: false,
                defaultValue: 0m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CaloriesGained",
                table: "TaskInput");

            migrationBuilder.RenameColumn(
                name: "CaloriesLost",
                table: "TaskInput",
                newName: "Calories");

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "CalorieCount", "Name", "pictureUrl" },
                values: new object[] { new Guid("806985f7-3350-41ce-ba9f-d7405897e7b2"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("218947dc-0943-434a-ba62-c07451b22dd5"), 295, "Burger", "piece" },
                    { new Guid("3d33bf0d-c112-4d32-96bc-73c92ca8060b"), 40, "Onion", "piece" },
                    { new Guid("98eac67f-ef73-4a33-9404-1e863b780875"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("5a32e492-e2d3-4cf8-9359-837112cb1d95"), 96, "White bread", "slice" },
                    { new Guid("cd0274ea-3552-4b9e-ba57-313b6490836d"), 44, "Apple", "apple" },
                    { new Guid("5bf7fdbf-fc4d-4196-ae39-72b819b305fe"), 107, "Banana", "banana" },
                    { new Guid("353b57cb-827e-4644-8cc0-e42e3db38ab3"), 30, "Tomato", "tomato" },
                    { new Guid("1d21a5b2-0a1f-4045-a807-92027fd450d4"), 50, "Roti", "slice" },
                    { new Guid("d9a296f2-7e8a-457d-9da0-85e7d35012d0"), 40, "Rice", "cup" },
                    { new Guid("e5acb476-8bba-4278-b35e-20fa5b60e904"), 600, "Halal Pork", "piece" },
                    { new Guid("cf366673-7b3c-4c46-9f3e-7fe5ea598143"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("9c3c7f4c-6738-47e3-8c8a-f5c82a576082"), 300, "Meat Platter", "platter" },
                    { new Guid("7c6f60cc-c0d9-4208-be5e-535796f478da"), 350, "Mooncake", "mooncake" },
                    { new Guid("b6b7dad4-a4ca-4f53-bb4d-8aadb1d41e4a"), 400, "HSP", "box" }
                });
        }
    }
}
