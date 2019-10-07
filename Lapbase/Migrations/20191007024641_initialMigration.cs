using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class initialMigration : Migration
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

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "CalorieCount", "Name", "pictureUrl" },
                values: new object[] { new Guid("414f9e69-edbe-4959-9500-9401f7290363"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("11a64ef9-0f18-4bc5-8425-9091c3b4eaf2"), 295, "Burger", "piece" },
                    { new Guid("28173ebc-37fc-4ba5-90c7-9f63a354b6dd"), 40, "Onion", "piece" },
                    { new Guid("06f08fa3-880b-4b54-87f1-10a06eb0737e"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("973685b3-0f6d-41eb-a251-e0933a3a775c"), 96, "White bread", "slice" },
                    { new Guid("1bf8a930-904e-47d9-9db9-37fc15f8c9ee"), 44, "Apple", "apple" },
                    { new Guid("3abc244d-e8b0-47bc-ae18-3218976cf2e9"), 107, "Banana", "banana" },
                    { new Guid("f62084f1-a9b3-45bc-8f06-eb5eefef76f7"), 30, "Tomato", "tomato" },
                    { new Guid("338c1fdf-b811-4a60-a3a0-e6429b4fabe2"), 50, "Roti", "slice" },
                    { new Guid("b47ea68c-2f4a-40a3-9491-cf1596152f2f"), 40, "Rice", "cup" },
                    { new Guid("824dd9c5-9155-4364-ab47-ba539e6bbf91"), 600, "Halal Pork", "piece" },
                    { new Guid("e793d0d0-739f-40fd-a263-1600af0185df"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("c049470b-64b1-4dc3-806a-e0dd6a149ae3"), 300, "Meat Platter", "platter" },
                    { new Guid("632d0d77-0d40-4f65-9c2b-95d345943e61"), 350, "Mooncake", "mooncake" },
                    { new Guid("24196c1f-0301-4843-bc32-89eb162633e1"), 400, "HSP", "box" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: new Guid("414f9e69-edbe-4959-9500-9401f7290363"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("06f08fa3-880b-4b54-87f1-10a06eb0737e"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("11a64ef9-0f18-4bc5-8425-9091c3b4eaf2"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("1bf8a930-904e-47d9-9db9-37fc15f8c9ee"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("24196c1f-0301-4843-bc32-89eb162633e1"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("28173ebc-37fc-4ba5-90c7-9f63a354b6dd"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("338c1fdf-b811-4a60-a3a0-e6429b4fabe2"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3abc244d-e8b0-47bc-ae18-3218976cf2e9"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("632d0d77-0d40-4f65-9c2b-95d345943e61"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("824dd9c5-9155-4364-ab47-ba539e6bbf91"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("973685b3-0f6d-41eb-a251-e0933a3a775c"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("b47ea68c-2f4a-40a3-9491-cf1596152f2f"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("c049470b-64b1-4dc3-806a-e0dd6a149ae3"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("e793d0d0-739f-40fd-a263-1600af0185df"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("f62084f1-a9b3-45bc-8f06-eb5eefef76f7"));

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
