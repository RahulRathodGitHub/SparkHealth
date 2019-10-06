using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class fixedExercises : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: new Guid("28734a7b-9320-4715-a7e2-d97fc6c4e792"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("0384b39f-6bef-4668-aa9e-3264b88ef2ff"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("3153e76d-a5ce-4646-aa67-3e9bdfc05a86"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("352d8e7d-aabe-4eff-bcb8-7e8b7316b950"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("7d46de2b-e2fd-4568-8c12-f07824a01859"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("88045e5d-7604-46db-bfc2-0577e4bee4c5"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("8ad6dc0d-733d-47be-afd9-79e7af8e0caa"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("8b22cd60-a653-4b89-b2ec-f71e38626977"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("8cf5053e-c741-4e4b-9481-07fcd1caeb26"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("92ba26ba-3c56-4854-b0d9-cb3607118ec3"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("a1bb6f8c-f367-4857-93f8-640042a79f0e"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("c0ba6223-085f-445a-9891-850843967ba4"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("d343fe52-df8a-46a8-8266-8db01595a082"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("eb018b73-2983-4ab9-a6da-77c3e2896206"));

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: new Guid("f3c907d1-363a-49ce-a526-895f4b26cba6"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("28734a7b-9320-4715-a7e2-d97fc6c4e792"), 54, "PUSHUPS", null });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CalorieCount", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("f3c907d1-363a-49ce-a526-895f4b26cba6"), 295, "Burger", "piece" },
                    { new Guid("8cf5053e-c741-4e4b-9481-07fcd1caeb26"), 40, "Onion", "piece" },
                    { new Guid("a1bb6f8c-f367-4857-93f8-640042a79f0e"), 90, "Uncle Keith's Kappuccino", "cup" },
                    { new Guid("352d8e7d-aabe-4eff-bcb8-7e8b7316b950"), 96, "White bread", "slice" },
                    { new Guid("7d46de2b-e2fd-4568-8c12-f07824a01859"), 44, "Apple", "apple" },
                    { new Guid("88045e5d-7604-46db-bfc2-0577e4bee4c5"), 107, "Banana", "banana" },
                    { new Guid("c0ba6223-085f-445a-9891-850843967ba4"), 30, "Tomato", "tomato" },
                    { new Guid("3153e76d-a5ce-4646-aa67-3e9bdfc05a86"), 50, "Roti", "slice" },
                    { new Guid("8b22cd60-a653-4b89-b2ec-f71e38626977"), 40, "Rice", "cup" },
                    { new Guid("0384b39f-6bef-4668-aa9e-3264b88ef2ff"), 600, "Halal Pork", "piece" },
                    { new Guid("8ad6dc0d-733d-47be-afd9-79e7af8e0caa"), 300, "Habib-Style Shwarma", "shwarma" },
                    { new Guid("92ba26ba-3c56-4854-b0d9-cb3607118ec3"), 300, "Meat Platter", "platter" },
                    { new Guid("d343fe52-df8a-46a8-8266-8db01595a082"), 350, "Mooncake", "mooncake" },
                    { new Guid("eb018b73-2983-4ab9-a6da-77c3e2896206"), 400, "HSP", "box" }
                });
        }
    }
}
