using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lapbase.Migrations
{
    public partial class modifiedExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercise_Patient_PatientId",
                table: "Exercise");

            migrationBuilder.DropIndex(
                name: "IX_Exercise_PatientId",
                table: "Exercise");

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

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Exercise");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Exercise",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_PatientId",
                table: "Exercise",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercise_Patient_PatientId",
                table: "Exercise",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
