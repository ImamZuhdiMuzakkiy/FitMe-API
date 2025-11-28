using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitMe.API.Migrations
{
    /// <inheritdoc />
    public partial class Revisi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_workout_session_tbl_workout_program_workout_program_id",
                table: "tbl_workout_session");

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("3cf441d2-daa3-4eb1-9b87-6f8ddf58d198"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("71226f4b-b3b5-44df-9e60-37aa782dfa6c"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("dc876428-245d-4ad6-ae11-ae536d81dd11"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("e81e5d36-9e96-4b32-94ae-b3e46f64c1d8"));

            migrationBuilder.AlterColumn<int>(
                name: "duration_weeks",
                table: "tbl_workout_program",
                type: "int",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "tbl_user",
                columns: new[] { "user_id", "age", "CreatedAt", "email", "Expired", "gender", "height", "IsUsed", "Otp", "password", "role_id", "UpdatedAt", "weight" },
                values: new object[,]
                {
                    { new Guid("11263469-1d43-4b9c-9e5b-89492c9560e3"), 30, new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3560), "member1@gmail.com", null, "Female", 175.0, false, null, "123", new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3561), 65.0 },
                    { new Guid("55b6322f-7068-4cb0-a599-4ddeb95df7dc"), 30, new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3552), "coach2@gmail.com", null, "Female", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3553), 65.0 },
                    { new Guid("949561eb-b7cd-4244-85c3-6c9c127198cd"), 25, new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3503), "admin1@gmail.com", null, "Male", 175.0, false, null, "12345", new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3520), 65.0 },
                    { new Guid("a99b02a2-cc2b-4328-8d2d-85fb0c2df930"), 30, new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3527), "coach1@gmail.com", null, "Male", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 28, 10, 14, 37, 742, DateTimeKind.Local).AddTicks(3528), 65.0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_workout_session_tbl_workout_program_workout_program_id",
                table: "tbl_workout_session",
                column: "workout_program_id",
                principalTable: "tbl_workout_program",
                principalColumn: "workout_program_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_workout_session_tbl_workout_program_workout_program_id",
                table: "tbl_workout_session");

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("11263469-1d43-4b9c-9e5b-89492c9560e3"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("55b6322f-7068-4cb0-a599-4ddeb95df7dc"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("949561eb-b7cd-4244-85c3-6c9c127198cd"));

            migrationBuilder.DeleteData(
                table: "tbl_user",
                keyColumn: "user_id",
                keyValue: new Guid("a99b02a2-cc2b-4328-8d2d-85fb0c2df930"));

            migrationBuilder.AlterColumn<string>(
                name: "duration_weeks",
                table: "tbl_workout_program",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "tbl_user",
                columns: new[] { "user_id", "age", "CreatedAt", "email", "Expired", "gender", "height", "IsUsed", "Otp", "password", "role_id", "UpdatedAt", "weight" },
                values: new object[,]
                {
                    { new Guid("3cf441d2-daa3-4eb1-9b87-6f8ddf58d198"), 30, new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8876), "member1@gmail.com", null, "Female", 175.0, false, null, "123", new Guid("10000000-0000-0000-0000-000000000003"), new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8877), 65.0 },
                    { new Guid("71226f4b-b3b5-44df-9e60-37aa782dfa6c"), 30, new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8868), "coach1@gmail.com", null, "Male", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8869), 65.0 },
                    { new Guid("dc876428-245d-4ad6-ae11-ae536d81dd11"), 30, new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8873), "coach2@gmail.com", null, "Female", 175.0, false, null, "123456", new Guid("10000000-0000-0000-0000-000000000002"), new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8873), 65.0 },
                    { new Guid("e81e5d36-9e96-4b32-94ae-b3e46f64c1d8"), 25, new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8828), "admin1@gmail.com", null, "Male", 175.0, false, null, "12345", new Guid("10000000-0000-0000-0000-000000000001"), new DateTime(2025, 11, 26, 11, 12, 54, 777, DateTimeKind.Local).AddTicks(8842), 65.0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_workout_session_tbl_workout_program_workout_program_id",
                table: "tbl_workout_session",
                column: "workout_program_id",
                principalTable: "tbl_workout_program",
                principalColumn: "workout_program_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
